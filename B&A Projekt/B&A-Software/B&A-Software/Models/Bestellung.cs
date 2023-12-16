using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_A_Software.Models
{
    public class Bestellung
    {
        public int BestellungID { get; set; }
        public string ExtraBrdtellung { get; set; }
        public bool Bedient { get; set; }
        public DateTime Datum { get; set; }
        public int TischID { get; set; }
        public int MenüItemId { get; set; }
        public int RechnungID { get; set; }


    }
}
