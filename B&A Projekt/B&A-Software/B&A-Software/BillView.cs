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
        public BillView(List<MenüItem> Waren)
        {
            this.Warenkorb = Waren;
            InitializeComponent();
        }

        private void TogetherBillBtn_Click(object sender, EventArgs e)
        {
            TogetherBillView togetherbillview = new TogetherBillView(Warenkorb);

            this.Hide();

            if (togetherbillview.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void SplitBillBtn_Click(object sender, EventArgs e)
        {
            SplitBillView splitbillview = new SplitBillView(Warenkorb);

            this.Hide();

            if (splitbillview.ShowDialog() == DialogResult.OK)
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
