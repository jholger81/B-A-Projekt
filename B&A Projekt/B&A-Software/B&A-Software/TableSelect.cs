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
    public partial class TableSelect : Form
    {
        List<MenüItem> Warenkorb = new List<MenüItem>();
        int bereich_;
        public TableSelect(int bereich, List<MenüItem> Waren)
        {
            this.Warenkorb = Waren;
            InitializeComponent();
            TableBtn1.Text += $"{(bereich - 1) * 5 + 1}";
            TableBtn2.Text += $"{(bereich - 1) * 5 + 2}";
            TableBtn3.Text += $"{(bereich - 1) * 5 + 3}";
            TableBtn4.Text += $"{(bereich - 1) * 5 + 4}";
            TableBtn5.Text += $"{(bereich - 1) * 5 + 5}";
            AreaNumLab.Text += bereich.ToString();
            
            bereich_ = bereich;
        }

        private void TableBtn1_Click(object sender, EventArgs e)
        {
            // TODO : Form anpassen in schöne
            TableView tableview = new TableView((bereich_ - 1) * 5 + 1, Warenkorb);

            this.Hide();

            if (tableview.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void TableBtn2_Click(object sender, EventArgs e)
        {
            TableView tableview = new TableView((bereich_ - 1) * 5 + 2, Warenkorb);

            this.Hide();

            if (tableview.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void TableBtn3_Click(object sender, EventArgs e)
        {
            TableView tableview = new TableView((bereich_ - 1) * 5 + 3, Warenkorb);

            this.Hide();

            if (tableview.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void TableBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TableView((bereich_ - 1) * 5 + 4, Warenkorb).ShowDialog();
        }

        private void TableBtn5_Click(object sender, EventArgs e)
        {
            TableView tableview = new TableView((bereich_ - 1) * 5 + 5, Warenkorb);

            this.Hide();

            if (tableview.ShowDialog() == DialogResult.OK)
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
    }
}
