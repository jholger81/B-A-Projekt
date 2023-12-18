using B_A_Software.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_A_Software
{
    public partial class TogetherBillView : Form
    {
        string strTemp = @$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetCurrentDirectory()}\B&A_DB.accdb";
        private List<MenüItem> speisenliste;
        List<MenüItem> Warenkorb = new List<MenüItem>();
        int tischnummer_;
        int mitarbeiterID;
        public TogetherBillView(List<MenüItem> Waren, int tischnummer)
        {
            this.Warenkorb = Waren;
            InitializeComponent();
            tischnummer_ = tischnummer;
            speisenliste = LoadData();
            ShowData();
            mitarbeiterID = LoadMitarbeiter();
        }

        private void ShowData()
        {
            double betrag = 0.0;
            foreach (var item in Warenkorb)
            {
                listBox1.Items.Add(item.Speisenname);
                betrag += Convert.ToDouble((item.Preis));
            }
            AmountTxtBox.Text = betrag.ToString();
        }

        private int LoadMitarbeiter()
        {
            int mitarbeiterID_;
            using (OleDbConnection dataConnection = new OleDbConnection(strTemp))
            {
                dataConnection.Open();
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.Connection = dataConnection;
                    dataCommand.CommandText = @$"
                        SELECT 
                            MitarbeiterID 
                        FROM Tisch 
                        WHERE 
                            TischID = {tischnummer_};";
                    using (var reader = dataCommand.ExecuteReader())
                    {
                        reader.Read();
                        mitarbeiterID_ = reader.GetInt32(0);
                    }
                }
            }
            return mitarbeiterID_;
        }

        private List<MenüItem> LoadData()
        {
            using (OleDbConnection dataConnection = new OleDbConnection(strTemp))
            {
                List<MenüItem> speisenListeLocal = new List<MenüItem>();

                dataConnection.Open();

                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.Connection = dataConnection;
                    dataCommand.CommandText = "Select MenüItemID, Kategorie, Speisenname, Preis, Beschreibung From MenüItem;";
                    using (var reader = dataCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MenüItem newItem = new MenüItem();
                            newItem.MenüItemID = reader.GetInt32(0);
                            newItem.Ketegorie = reader.GetString(1);
                            newItem.Speisenname = reader.GetString(2);
                            newItem.Preis = reader.GetValue(3).ToString();
                            newItem.Beschreibung = reader.GetValue(4).ToString();
                            speisenListeLocal.Add(newItem);
                        }
                    }
                }
                return speisenListeLocal;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BillView(Warenkorb, tischnummer_).ShowDialog();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintDocument docToPrint = new PrintDocument();
            string stringToPrint = "";
            string header = "Rechnung\r\n\r\n\n";
            stringToPrint += $"Datum: {DateTime.Now.ToString()}\r\n";
            stringToPrint += $"Tisch: {tischnummer_}\r\n";

            List<MenüItem> menuitems = new List<MenüItem>();
            foreach (var item in listBox1.Items)
            {
                var item_ = GetMenuItemFromString((string)item);
                menuitems.Add(item_);
            }

            //double gesamtbetrag = 0.0;
            foreach (var item in menuitems)
            {
                stringToPrint += $"{item.Preis} € - {item.Speisenname}\r\n";
                //gesamtbetrag += Convert.ToDouble(item.Preis);
            }

            stringToPrint += $"\r\nZu bezahlender Betrag: {AmountTxtBox.Text} €";
            stringToPrint += $"\r\nBezahlter Betrag: {PayedTxtBox.Text} €";

            docToPrint.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(header, new Font("Arial", 25), new SolidBrush(Color.Black), new RectangleF(0, 0, docToPrint.DefaultPageSettings.PrintableArea.Width, docToPrint.DefaultPageSettings.PrintableArea.Height));
                e1.Graphics.DrawString(stringToPrint, new Font("Arial", 15), new SolidBrush(Color.Black), new RectangleF(0, 50, docToPrint.DefaultPageSettings.PrintableArea.Width, docToPrint.DefaultPageSettings.PrintableArea.Height));
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.AllowSomePages = true;
            printDialog.ShowHelp = true;
            printDialog.Document = docToPrint;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

        private void SplitPayBtn_Click(object sender, EventArgs e)
        {
            List<MenüItem> menuitems = new List<MenüItem>();
            foreach (var item in listBox1.Items)
            {
                var item_ = GetMenuItemFromString((string)item);
                menuitems.Add(item_);
            }

            using (OleDbConnection dataConnection = new OleDbConnection(strTemp))
            {
                dataConnection.Open();
                int rechnungID;

                // Einfügen in Rechnung
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.Connection = dataConnection;
                    DateTime theDate = DateTime.Now;

                    dataCommand.CommandText = @$"
                            INSERT INTO Rechnung(
                                Trinkgeld,
                                Betrag,
                                Datum,
                                MitarbeiterID)
                            VALUES(
                                @trinkgeld,
                                @betrag,
                                @mydate,
                                @mitarbeiterID);";
                    double trinkgeld = Convert.ToDouble(TipTxtBox.Text) * 1.0;
                    double betrag = Convert.ToDouble(AmountTxtBox.Text) * 1.0;
                    dataCommand.Parameters.AddWithValue("@trinkgeld", trinkgeld);
                    dataCommand.Parameters.AddWithValue("@betrag", betrag);
                    dataCommand.Parameters.Add("@mydate", OleDbType.Date).Value = theDate;
                    dataCommand.Parameters.AddWithValue("@mitarbeiterID", mitarbeiterID);
                    dataCommand.ExecuteNonQuery();

                    // ID wieder auslesen
                    dataCommand.Parameters.Clear();
                    dataCommand.CommandText = "SELECT @@IDENTITY";
                    rechnungID = Convert.ToInt32(dataCommand.ExecuteScalar());
                }

                foreach (var item in menuitems)
                {
                    int bestellungID;

                    // Erste Bestellung des Tisches mit dem Entsprechenden Menütimem holen
                    using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                    {
                        dataCommand.Connection = dataConnection;
                        dataCommand.CommandText = @$"
                                SELECT
                                    BestellungID
                                FROM
                                    Bestellung
                                WHERE TischID = {tischnummer_}
                                AND MenüItemID = {item.MenüItemID}
                                AND Bedient = false;";
                        using (OleDbDataReader reader = dataCommand.ExecuteReader())
                        {
                            reader.Read();
                            bestellungID = reader.GetInt32(0);
                        }
                    }

                    // Bestellung updaten
                    using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                    {
                        dataCommand.Connection = dataConnection;
                        dataCommand.CommandText = @$"
                                UPDATE Bestellung
                                SET 
                                    Bedient = true, 
                                    RechnungID = {rechnungID}
                                WHERE BestellungID = {bestellungID}";
                        dataCommand.ExecuteNonQuery();
                    }
                }
                Warenkorb.Remove(Warenkorb.FirstOrDefault(item => item.MenüItemID == item.MenüItemID));
                this.Hide();
                new TableView(tischnummer_, Warenkorb).ShowDialog();
            }
        }

        private MenüItem GetMenuItemFromString(string speisenName)
        {
            var speise = speisenliste.FirstOrDefault(x => x.Speisenname == speisenName);
            return speise;
        }

        private void PayedTxtBox_TextChanged(object sender, EventArgs e)
        {
            double betrag;
            double gegeben;
            if (Double.TryParse(PayedTxtBox.Text, out gegeben))
            {
                if (Double.TryParse(AmountTxtBox.Text, out betrag))
                {
                    double trinkgeld = gegeben - betrag;
                    TipTxtBox.Text = Math.Round(trinkgeld, 2).ToString();
                }
            }
        }
    }

}
