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
    public partial class TableSwap : Form
    {
        string strTemp = @$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetCurrentDirectory()}\B&A_DB.accdb";
        int toTable = 0;
        int fromTable_;
        List<MenüItem> Warenkorb;
        public TableSwap(int fromTable, List<MenüItem> Waren)
        {
            fromTable_ = fromTable;
            Warenkorb = Waren;
            InitializeComponent();
        }

        private void Swap()
        {
            using (OleDbConnection dataConnection = new OleDbConnection(strTemp))
            {
                dataConnection.Open();
                using (OleDbCommand dataCommand = dataConnection.CreateCommand())
                {
                    dataCommand.Connection = dataConnection;
                    dataCommand.CommandText = @$"
                        UPDATE 
                            Bestellung 
                        SET TischID = {toTable}
                        WHERE 
                            TischID = {fromTable_}
                        AND
                            Bedient = false;";
                    dataCommand.ExecuteNonQuery();
                }
            }

            this.Hide();
            new TableView(toTable, Warenkorb).ShowDialog();
        }

        private void TableSwapBtn1_Click(object sender, EventArgs e)
        {
            toTable = 1;
            Swap();
        }

        private void TableSwapBtn2_Click(object sender, EventArgs e)
        {
            toTable = 2;
            Swap();
        }

        private void TableSwapBtn3_Click(object sender, EventArgs e)
        {
            toTable = 3;
            Swap();
        }

        private void TableSwapBtn4_Click(object sender, EventArgs e)
        {
            toTable = 4;
            Swap();
        }

        private void TableSwapBtn5_Click(object sender, EventArgs e)
        {
            toTable = 5;
            Swap();
        }

        private void TableSwapBtn6_Click(object sender, EventArgs e)
        {
            toTable = 6;
            Swap();
        }

        private void TableSwapBtn7_Click(object sender, EventArgs e)
        {
            toTable = 7;
            Swap();
        }
        private void TableSwapBtn8_Click(object sender, EventArgs e)
        {
            toTable = 8;
            Swap();
        }

        private void TableSwapBtn9_Click(object sender, EventArgs e)
        {
            toTable = 9;
            Swap();
        }


        private void TableSwapBtn10_Click(object sender, EventArgs e)
        {
            toTable = 10;
            Swap();
        }
        private void TableSwapBtn11_Click(object sender, EventArgs e)
        {
            toTable = 11;
            Swap();
        }

        private void TableSwapBtn12_Click(object sender, EventArgs e)
        {
            toTable = 12;
            Swap();
        }

        private void TableSwapBtn13_Click(object sender, EventArgs e)
        {
            toTable = 13;
            Swap();
        }

        private void TableSwapBtn14_Click(object sender, EventArgs e)
        {
            toTable = 14;
            Swap();
        }

        private void TableSwapBtn15_Click(object sender, EventArgs e)
        {
            toTable = 15;
            Swap();
        }

        private void TableSwapBtn16_Click(object sender, EventArgs e)
        {
            toTable = 16;
            Swap();
        }

        private void TableSwapBtn17_Click(object sender, EventArgs e)
        {
            toTable = 17;
            Swap();
        }

        private void TableSwapBtn18_Click(object sender, EventArgs e)
        {
            toTable = 18;
            Swap();
        }

        private void TableSwapBtn19_Click(object sender, EventArgs e)
        {
            toTable = 19;
            Swap();
        }

        private void TableSwapBtn20_Click(object sender, EventArgs e)
        {
            toTable = 20;
            Swap();
        }

        private void TableSwapBtn21_Click(object sender, EventArgs e)
        {
            toTable = 21;
            Swap();
        }

        private void TableSwapBtn22_Click(object sender, EventArgs e)
        {
            toTable = 22;
            Swap();
        }


        private void TableSwapBtn23_Click(object sender, EventArgs e)
        {
            toTable = 23;
            Swap();
        }

        private void TableSwapBtn24_Click(object sender, EventArgs e)
        {
            toTable = 24;
            Swap();
        }

        private void TableSwapBtn25_Click(object sender, EventArgs e)
        {
            toTable = 25;
            Swap();
        }
    }
}
