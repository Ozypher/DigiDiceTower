using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDiceTower.Models
{
    public class Unit
    {
        public int Movement { get; set; }
        public int Toughness { get; set; }
        public int LeaderScore { get; set; }
        public int ObjectControl {  get; set; }
        public int Wounds { get; set; }
        public string UnitName { get; set; }
        public string ArmyName { get; set; }

    }
}
