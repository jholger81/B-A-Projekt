using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_A_Software.Models
{
    public class Tisch
    {
        public int TischID { get; set; }
        public bool Besetzt { get; set; }   
        public int Plätze { get; set; }
        public int MitarbeiterID { get; set; }
    }
}
