using System;
using System.Data.OleDb;
using System.Data;

namespace B_A_Software
{
    public class Program
    {
        static string ConnectionString = @$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetCurrentDirectory()}\B&A_DB.accdb;";
        OleDbConnection connection;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            OleDbConnection connection = new OleDbConnection(ConnectionString);

            connection.Open();

            ApplicationConfiguration.Initialize();
            Application.Run(new Login(connection));
        }
    }
}