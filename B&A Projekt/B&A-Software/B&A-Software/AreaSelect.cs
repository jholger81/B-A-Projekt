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
    public partial class AreaSelect : Form
    {
        public AreaSelect()
        {
            InitializeComponent();
        }

        private void AreaBtn1_Click(object sender, EventArgs e)
        {
            TableSelect tableselect = new TableSelect(1, new List<MenüItem>());

            this.Hide();

            if (tableselect.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void AreaBtn2_Click(object sender, EventArgs e)
        {
            TableSelect tableselect = new TableSelect(2, new List<MenüItem>());

            this.Hide();

            if (tableselect.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void AreaBtn3_Click(object sender, EventArgs e)
        {
            TableSelect tableselect = new TableSelect(3, new List<MenüItem>());

            this.Hide();

            if (tableselect.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void AreaBtn4_Click(object sender, EventArgs e)
        {
            TableSelect tableselect = new TableSelect(4, new List<MenüItem>());

            this.Hide();

            if (tableselect.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void AreaBtn5_Click(object sender, EventArgs e)
        {
            TableSelect tableselect = new TableSelect(5, new List<MenüItem>());

            this.Hide();

            if (tableselect.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
