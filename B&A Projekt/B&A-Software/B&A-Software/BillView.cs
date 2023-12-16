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
    public partial class BillView : Form
    {
        List<MenüItem> Warenkorb = new List<MenüItem>();
        int tischnummer_;
        public BillView(List<MenüItem> Waren, int tischnummer)
        {
            this.Warenkorb = Waren;
            InitializeComponent();
            tischnummer_ = tischnummer;
        }

        private void TogetherBillBtn_Click(object sender, EventArgs e)
        {
            TogetherBillView togetherbillview = new TogetherBillView(Warenkorb, tischnummer_);

            this.Hide();

            if (togetherbillview.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void SplitBillBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SplitBillView(Warenkorb, tischnummer_).ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TableView(tischnummer_, Warenkorb).ShowDialog();
        }
    }
}
