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
    public partial class TogetherBillView : Form
    {
        List<MenüItem> Warenkorb = new List<MenüItem>();
        int tischnummer_;
        public TogetherBillView(List<MenüItem> Waren, int tischnummer)
        {
            this.Warenkorb = Waren;
            InitializeComponent();
            tischnummer_ = tischnummer;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderLab_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BillView billview = new BillView(Warenkorb, tischnummer_);

            this.Hide();

            if (billview.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            double gesamtpreis = 0;
            PrintDocument docToPrint = new PrintDocument();
            string stringToPrint = "";
            string header = "Rechnung\r\n\r\n\n";
            stringToPrint += $"Datum: {DateTime.Now.ToString()}\r\n";
            stringToPrint += $"Tisch: dummy\r\n";

            foreach (var ware in Warenkorb)
            {
                stringToPrint += $"{ware.Speisenname}: {ware.Preis}\r\n";
                //gesamtpreis += Convert.ToDouble((ware.Preis.Length - 1).Substring());
                gesamtpreis += Convert.ToDouble(ware.Preis.Substring(0, ware.Preis.Length - 1));
                // TODO
            }

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
