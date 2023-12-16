using B_A_Software.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_A_Software
{
    public class DBHandler
    {
        public static void DB_Load()
        {
            //string strTemp = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = TeilnehmerITB13.accdb";
            //OleDbConnection dataConnection = new OleDbConnection(strTemp);
            //OleDbCommand dataCommand;
            //List<Datensatz> data = new List<Datensatz>();

            //dataConnection.Open();
            //dataCommand = dataConnection.CreateCommand();
            //dataCommand.Connection = dataConnection;
            //dataCommand.CommandText = commandString;

            string strTemp = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=H:\\Documents\\LF_11\\B&A Projekt\\B&A-Software\\B&A-Software\\bin\\Debug\\B&A_DB.accdb";
            OleDbConnection dataConnection = new OleDbConnection(strTemp);

            try
            {
                dataConnection.Open();
                MessageBox.Show("Zugriff erfolgreich");

                OleDbCommand dataCommand = dataConnection.CreateCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "Select * From MenüItem";
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Zugriff auf die Datenbank");
            }
            finally { dataConnection.Close(); }


        }

        public static List<Tisch> GetTables()
        {
            var tischliste = new List<Tisch>();

            string dbConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=H:\\Documents\\LF_11\\B&A Projekt\\B&A-Software\\B&A-Software\\bin\\Debug\\B&A_DB.accdb";
            using (OleDbConnection dataConnection = new OleDbConnection(dbConnectionString))
            {

                dataConnection.Open();

                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.Connection = dataConnection;
                    dataCommand.CommandText = "Select TischID, Besetzt, Plätze, MitarbeiterID From Tisch";
                    var reader = dataCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Tisch neuerTisch = new Tisch();
                        neuerTisch.TischID = reader.GetInt32(0);
                        neuerTisch.Besetzt = reader.GetBoolean(1);
                        neuerTisch.Plätze = reader.GetInt32(2);
                        neuerTisch.MitarbeiterID = reader.GetInt32(3);
                        tischliste.Add(neuerTisch);
                    }
                }
            }

            return tischliste;
        }

        public static Tisch GetTable(int tischId)
        {
            Tisch neuerTisch = new Tisch();
            string dbConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=H:\\Documents\\LF_11\\B&A Projekt\\B&A-Software\\B&A-Software\\bin\\Debug\\B&A_DB.accdb";
            using (OleDbConnection dataConnection = new OleDbConnection(dbConnectionString))
            {

                dataConnection.Open();

                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.Connection = dataConnection;
                    dataCommand.CommandText = $"Select TischID, Besetzt, Plätze, MitarbeiterID From Tisch WHERE TischID = {tischId};";
                    var reader = dataCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        neuerTisch.TischID = reader.GetInt32(0);
                        neuerTisch.Besetzt = reader.GetBoolean(1);
                        neuerTisch.Plätze = reader.GetInt32(2);
                        neuerTisch.MitarbeiterID = reader.GetInt32(3);
                    }
                    else
                    {
                        throw new Exception("Hier könnte meine Fehlermeldung stehen");
                    }
                }
            }

            return neuerTisch;
        }
    }
}
