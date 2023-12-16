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
    public partial class SplitBillView : Form
    {
        string strTemp = @$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetCurrentDirectory()}\B&A_DB.accdb";
        private List<MenüItem> speisenliste;
        List<MenüItem> Warenkorb = new List<MenüItem>();
        int tischnummer_;
        int mitarbeiterID;
        public SplitBillView(List<MenüItem> Waren, int tischnummer)
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
            foreach (var item in Warenkorb)
            {
                OrderListBox.Items.Add(item.Speisenname);
            }
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

        private void OrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderListBox.SelectedIndex != -1)
            {
                string selectedText = OrderListBox.SelectedItem.ToString();
                PayListBox.Items.Add(selectedText);
                OrderListBox.Items.RemoveAt(OrderListBox.SelectedIndex);
            }
            // TODO : Betrag berechnen anhand von PayListBox
            double betrag = 0.0;
            foreach (string item in PayListBox.Items)
            {
                betrag += Convert.ToDouble(GetMenuItemFromString(item).Preis);
            }
            string betragString = betrag.ToString();
            decimal betragDecimal = decimal.Parse(betragString);
            string text = betragDecimal.ToString("N2");
            this.AmountTxtBox.Text = text;
        }

        private void PayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PayListBox.SelectedIndex != -1)
            {
                string selectedText = PayListBox.SelectedItem.ToString();
                OrderListBox.Items.Add(selectedText);
                PayListBox.Items.RemoveAt(PayListBox.SelectedIndex);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintDocument docToPrint = new PrintDocument();
            string stringToPrint = "";
            string header = "Rechnung\r\n\r\n\n";
            stringToPrint += $"Datum: {DateTime.Now.ToString()}\r\n";
            stringToPrint += $"Tisch: dummy\r\n";
            // TODO : implementieren

            //var billedItems = notpayed.selledItems;

            //foreach (var item in billedItems)
            //{
            //    stringToPrint += $"{item.ToString()}\r\n";
            //}

            //stringToPrint += $"\r\nZu begleichender Betrag: {inttopayinCent / 100}€";
            //stringToPrint += $"\r\nBezahlter Betrag:{rtbmoneygive.Text}€";

            stringToPrint += $"\r\nZu bezahlender Betrag: Dummy €";
            stringToPrint += $"\r\nBezahlter Betrag: Dummy €";

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
            foreach (var item in PayListBox.Items)
            {
                var item_ = GetMenuItemFromString((string)item);
                menuitems.Add(item_);
            }

            using (OleDbConnection dataConnection = new OleDbConnection(strTemp))
            {
                dataConnection.Open();
                foreach (var item in menuitems)
                {
                    int rechnungID;
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
                                {Convert.ToInt32(TipTxtBox.Text)},
                                {Convert.ToInt32(Convert.ToDouble(AmountTxtBox.Text) * 100)},
                                @mydate,
                                {mitarbeiterID});";
                        dataCommand.Parameters.Add("@mydate", OleDbType.Date).Value = theDate;
                        dataCommand.ExecuteNonQuery();

                        // ID wieder auslesen
                        dataCommand.Parameters.Clear();
                        dataCommand.CommandText = "SELECT @@IDENTITY";
                        rechnungID = Convert.ToInt32(dataCommand.ExecuteScalar());
                    }

                    // Bestellung updaten
                    using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                    {
                        dataCommand.Connection = dataConnection;
                        dataCommand.CommandText = @$"
                                UPDATE Bestellung(
                                SET 
                                    Bedient = true, 
                                    RechnungID = {rechnungID}
                                WHERE BestellungID = {bestellungID}";
                        dataCommand.ExecuteNonQuery();
                    }
                }
                Warenkorb.Remove(Warenkorb.FirstOrDefault(item => item.MenüItemID == item.MenüItemID));
            }
            // die strings wieder in positionen (bestellungen) umwandeln für den tisch
            // ==> liste daraus erstellen
            // foreach item in liste 
            // daten aus Bestellung löschen und daten in Rechnung eintragen
            // Warenkorb anpassen
        }

        private MenüItem GetMenuItemFromString(string speisenName)
        {
            var speise = speisenliste.FirstOrDefault(x => x.Speisenname == speisenName);
            return speise;
        }
    }
}
