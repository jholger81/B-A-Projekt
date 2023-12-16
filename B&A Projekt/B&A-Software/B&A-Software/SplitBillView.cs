using B_A_Software.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_A_Software
{
    public partial class SplitBillView : Form
    {
        List<MenüItem> Warenkorb = new List<MenüItem>();
        public SplitBillView(List<MenüItem> Waren)
        {
            this.Warenkorb = Waren;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PayLab_Click(object sender, EventArgs e)
        {

        }

        private void OrderLab_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BillView billview = new BillView(Warenkorb);

            this.Hide();

            if (billview.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void OrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (var item in )
            //{
            //    OrderListBox.Items.Add(item.Speisenname);
            //}
        }

        private void PayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintDocument docToPrint = new PrintDocument();
            string stringToPrint = "";
            string header = "Rechnung\r\n\r\n\n";
            stringToPrint += $"Datum: {DateTime.Now.ToString()}\r\n";
            stringToPrint += $"Tisch: dummy\r\n";

            //var billedItems = notpayed.selledItems;

            //foreach (var item in billedItems)
            //{
            //    stringToPrint += $"{item.ToString()}\r\n";
            //}

            //stringToPrint += $"\r\nZu begleichender Betrag: {inttopayinCent / 100}€";
            //stringToPrint += $"\r\nBezahlter Betrag:{rtbmoneygive.Text}€";

            stringToPrint += $"\r\nZu bezahlender Betrag: Dummy €";
            stringToPrint += $"\r\nBezahlter Betrag: Dummy €";

            docToPrint.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(header, new Font("Arial", 25), new SolidBrush(Color.Black), new RectangleF(0, 0, docToPrint.DefaultPageSettings.PrintableArea.Width, docToPrint.DefaultPageSettings.PrintableArea.Height));
                e1.Graphics.DrawString(stringToPrint, new Font("Arial", 15), new SolidBrush(Color.Black), new RectangleF(0, 50, docToPrint.DefaultPageSettings.PrintableArea.Width, docToPrint.DefaultPageSettings.PrintableArea.Height));
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.AllowSomePages = true;
            printDialog.ShowHelp = true;
            printDialog.Document = docToPrint;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }
    }
}
