using B_A_Software.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_A_Software
{
    public partial class TableView : Form
    {
        List<MenüItem> Warenkorb = new List<MenüItem>();
        int tischnummer_;
        string strTemp = @$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetCurrentDirectory()}\B&A_DB.accdb";
        public TableView(int tischnummer, List<MenüItem> Waren)
        {
            this.Warenkorb = Waren;
            InitializeComponent();
            // TODO Warenkorb laden?
            tischnummer_ = tischnummer;
            if (Warenkorb.Count == 0)
                Warenkorb = LoadData();
            TableLab.Text += tischnummer.ToString();
        }

        private List<MenüItem> LoadData()
        {
            List<MenüItem> Warenkorb_ = new List<MenüItem>();
            using (OleDbConnection dataConnection = new OleDbConnection(strTemp))
            {
                dataConnection.Open();
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.Connection = dataConnection;
                    // TODO : kann weg, wenn funktioniert
                    //dataCommand.CommandText = @$"
                    //    SELECT 
                    //        BestellungID,
                    //        ExtraBestellung,
                    //        Datum,
                    //        MenüItemID,
                    //        ReachnungID
                    //    FROM Bestellung 
                    //    WHERE 
                    //        Bedient = false, 
                    //        TischID = {tischnummer_};";
                    dataCommand.CommandText = @$"
                        SELECT 
                            MenüItemID
                        FROM Bestellung 
                        WHERE 
                            Bedient = false
                        AND
                            TischID = {tischnummer_};";
                    using (var reader = dataCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // TODO : kann weg, wenn funktioniert
                            //MenüItem newPosition = new MenüItem();
                            //newPosition.MenüItemID = reader.GetInt32(0);
                            MenüItem newPosition = GetItem(reader.GetInt32(0));
                            Warenkorb_.Add(newPosition);
                        }
                    }
                }
            }
            return Warenkorb_;
        }

        private MenüItem GetItem(int menüItemID)
        {
            MenüItem menüItem_ = new MenüItem();
            using (OleDbConnection dataConnection = new OleDbConnection(strTemp))
            {
                dataConnection.Open();
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.Connection = dataConnection;
                    dataCommand.CommandText = @$"
                        SELECT 
                            Kategorie,
                            Speisenname,
                            Preis,
                            Beschreibung
                        FROM MenüItem 
                        WHERE 
                            MenüItemID = {menüItemID};";
                    using (var reader = dataCommand.ExecuteReader())
                    {
                        reader.Read();
                        menüItem_.MenüItemID = menüItemID;
                        menüItem_.Ketegorie = reader.GetString(0);
                        menüItem_.Speisenname = reader.GetString(1);
                        menüItem_.Preis = reader.GetValue(2).ToString(); // TODO mimimi
                        menüItem_.Beschreibung = reader["Beschreibung"].ToString();
                        return menüItem_;
                    }
                }
            }
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderView(tischnummer_, Warenkorb).ShowDialog();
        }

        private void TableSwapBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TableSwap(tischnummer_, Warenkorb).ShowDialog();
        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BillView(Warenkorb, tischnummer_).ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TableSelect(tischnummer_, Warenkorb).ShowDialog();
        }

        private void EmptyTableBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tisch geleert");
            // TODO : Logik implementieren


            //TableSelect tableselect = new TableSelect();

            //this.Hide();

            //if (tableselect.ShowDialog() == DialogResult.OK)
            //{

            //}
        }
    }
}
