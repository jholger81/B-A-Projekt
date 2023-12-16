using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_A_Software.Models
{
    public class Rechnung
    {
        public int RechnungID { get; set; }
        public string Trinkgeld { get; set; }
        public string Betrag { get; set; }
        public DateTime Datum { get; set; }
        public int MitarbeiterID { get; set; }
    }
}
