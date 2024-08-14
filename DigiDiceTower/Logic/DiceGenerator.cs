using DigiDiceTower.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDiceTower.Logic
{
    public class DiceGenerator
    {
        public static Die GenDie(string name, int max, int min)
        {
            Die die = new Die { Ident = name, Max = max, Min = min };
            return die;
        }
    }
}
