using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDiceTower.Models
{
    public class Die
    {
        public string Ident {  get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public Random rnd = new Random();
    }
}
