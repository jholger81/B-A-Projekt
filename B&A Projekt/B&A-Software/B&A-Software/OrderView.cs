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
    public partial class OrderView : Form
    {
        string strTemp = @$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetCurrentDirectory()}\B&A_DB.accdb";
        List<MenüItem> Warenkorb = new List<MenüItem>();
        List<MenüItem> WarenkorbBisher = new List<MenüItem>();
        List<MenüItem> speisenListe = new List<MenüItem>();
        int tischnummer_;
        public OrderView(int tischnummer, List<MenüItem> Waren)
        {
            InitializeComponent();
            FoodListBox.SelectedIndexChanged += (sender, EventArgs) => { FoodListBox_SelectedIndexChanged(sender, EventArgs, connection); };
            LoadFood();
            LoadDrinks();
            tischnummer_ = tischnummer;
            WarenkorbBisher = Waren;
        }

        private void LoadFood()
        {
            string strTemp = @$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetCurrentDirectory()}\B&A_DB.accdb";
            using OleDbConnection dataConnection = new OleDbConnection(strTemp);
            List<MenüItem> speisenListeLocal = new List<MenüItem>();

            try
            {
                dataConnection.Open();

                OleDbCommand dataCommand = dataConnection.CreateCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "Select MenüItemID, Kategorie, Speisenname, Preis, Beschreibung From MenüItem WHERE Kategorie IN ('Vorspeise', 'Hauptspeise', 'Dessert')";
                var reader = dataCommand.ExecuteReader();
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
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Zugriff auf die Datenbank");
            }
            finally { dataConnection.Close(); }
            foreach (var item in speisenListeLocal)
            {
                FoodListBox.Items.Add(item.Speisenname);
            }
            speisenListe.AddRange(speisenListeLocal);
        }

        private void LoadDrinks()
        {
            string strTemp = @$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetCurrentDirectory()}\B&A_DB.accdb";
            using OleDbConnection dataConnection = new OleDbConnection(strTemp);
            List<MenüItem> speisenListeLocal = new List<MenüItem>();

            try
            {
                dataConnection.Open();

                OleDbCommand dataCommand = dataConnection.CreateCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "Select MenüItemID, Kategorie, Speisenname, Preis, Beschreibung From MenüItem WHERE Kategorie IN ('Alkoholfreies Getränk', 'Alkoholisches Getränk')";
                var reader = dataCommand.ExecuteReader();
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
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Zugriff auf die Datenbank");
            }
            finally { dataConnection.Close(); }
            foreach (var item in speisenListeLocal)
            {
                DrinksListBox.Items.Add(item.Speisenname);
            }
            speisenListe.AddRange(speisenListeLocal);
        }

        private MenüItem GetMenuItemFromString(string speisenName)
        {
            var speise = speisenListe.FirstOrDefault(x => x.Speisenname == speisenName);
            return speise;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TableView(tischnummer_, Warenkorb).ShowDialog();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            using (OleDbConnection dataConnection = new OleDbConnection(strTemp))
            {
                dataConnection.Open();
                try
                {

                    using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                    {
                        dataCommand.Connection = dataConnection;
                        DateTime theDate = DateTime.Now;
                        foreach (var item in Warenkorb)
                        {
                            dataCommand.CommandText = @$"
                            INSERT INTO Bestellung(
                                ExtraBestellung,
                                Bedient,
                                Datum,
                                TischID,
                                MenüItemID,
                                RechnungID)
                            VALUES(
                                '{tbExtras.Text}',
                                false,
                                @mydate,
                                {tischnummer_},
                                {item.MenüItemID},
                                0
                            )";
                            dataCommand.Parameters.Add("@mydate", OleDbType.Date).Value = theDate;
                            dataCommand.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Bestellung aufgegeben");
                }
                catch (Exception)
                {
                    MessageBox.Show("Fehler beim Zugriff auf die Datenbank");
                }

                finally
                {
                    dataConnection.Close();
                }
            }
            this.Hide();
            WarenkorbBisher.AddRange(Warenkorb);
            new TableView(tischnummer_, WarenkorbBisher).ShowDialog();
        }

        private void FoodListBox_SelectedIndexChanged(object sender, EventArgs e, OleDbConnection connection)
        {
            if (FoodListBox.SelectedIndex != -1)
            {
                string selectedText = FoodListBox.SelectedItem.ToString();

                WKListBox.Items.Add(selectedText);

                var toAdd = GetMenuItemFromString(FoodListBox.SelectedItem.ToString());
                if (toAdd != null)
                    Warenkorb.Add(toAdd);

            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DrinksListBox.SelectedIndex != -1)
            {
                string selectedText = DrinksListBox.SelectedItem.ToString();

                WKListBox.Items.Add(selectedText);

                var toAdd = GetMenuItemFromString(DrinksListBox.SelectedItem.ToString());
                if (toAdd != null)
                    Warenkorb.Add(toAdd);
            }
        }

        private void WKListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WKListBox.SelectedIndex != -1)
            {
                WKListBox.Items.RemoveAt(WKListBox.SelectedIndex);

                var toRemove = GetMenuItemFromString(FoodListBox.SelectedItem.ToString());
                if (toRemove != null)
                    Warenkorb.Remove(toRemove);
            }
        }

        private void FoodListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

