using B_A_Software.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public TableView(int tischnummer, List<MenüItem> Waren)
        {
            this.Warenkorb = Waren;
            InitializeComponent();
            TableLab.Text += tischnummer.ToString();
            tischnummer_ = tischnummer;
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            OrderView orderview = new OrderView(tischnummer_);

            this.Hide();

            if (orderview.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void TableSwapBtn_Click(object sender, EventArgs e)
        {
            TableSwap tableswap = new TableSwap();

            this.Hide();

            if (tableswap.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            BillView billview = new BillView(Warenkorb);

            this.Hide();

            if (billview.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AreaSelect areaselect = new AreaSelect();

            this.Hide();

            if (areaselect.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void EmptyTableBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tisch geleert");

            //TableSelect tableselect = new TableSelect();

            //this.Hide();

            //if (tableselect.ShowDialog() == DialogResult.OK)
            //{

            //}
        }
    }
}
