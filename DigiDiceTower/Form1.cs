using DigiDiceTower.Logic;
using DigiDiceTower.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDiceTower
{
    public partial class DigiDiceTower : Form
    {

        int d4Rolls = 0;
        int d6Rolls = 0;
        int d8Rolls = 0;
        int d10Rolls = 0;
        int d12Rolls = 0;
        int d20Rolls = 0;
        int d100Rolls = 0;

        int selectedTower = 0;

        public DigiDiceTower()
        {
            InitializeComponent();
            towerSelect.SelectedIndex = 0;
        }
        private void btnRollD4_Click(object sender, EventArgs e)
        {
            d4Rolls++;
            label1.Text = d4Rolls.ToString();
        }

        private void btnRollD6_Click(object sender, EventArgs e)
        {
            d6Rolls++;
            label2.Text = d6Rolls.ToString();
        }

        private void btnRollD8_Click(object sender, EventArgs e)
        {
            d8Rolls++;
            label3.Text = d8Rolls.ToString();
        }

        private void btnRollD10_Click(object sender, EventArgs e)
        {
            d10Rolls++;
            label4.Text = d10Rolls.ToString();
        }

        private void btnRollD12_Click(object sender, EventArgs e)
        {
            d12Rolls++;
            label5.Text = d12Rolls.ToString();
        }

        private void btnRollD20_Click(object sender, EventArgs e)
        {
            d20Rolls++;
            label6.Text = d20Rolls.ToString();
        }

        private void btnRollD100_Click(object sender, EventArgs e)
        {
            d100Rolls++;
            label7.Text = d100Rolls.ToString();
        }

        private void btnRollTray_Click(object sender, EventArgs e)
        {
            int d4result = 0;
            int d4crits = 0;
            int d4fails = 0;
            List<int> d4results = new List<int>();

            int d6result = 0;
            int d6crits = 0;
            int d6fails = 0;
            List<int> d6results = new List<int>();

            int d8result = 0;
            int d8crits = 0;
            int d8fails = 0;
            List<int> d8results = new List<int>();

            int d10result = 0;
            int d10crits = 0;
            int d10fails = 0;
            List<int> d10results = new List<int>();

            int d12result = 0;
            int d12crits = 0;
            int d12fails = 0;
            List<int> d12results = new List<int>();

            int d20result = 0;
            int d20crits = 0;
            int d20fails = 0;
            List<int> d20results = new List<int>();

            int d100result = 0;
            int d100crits = 0;
            int d100fails = 0;
            List<int> d100results = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < d4Rolls; i++)
            {
                var roll = rnd.Next(1, 5);
                d4result += roll;
                d4results.Add(roll);
                if(roll == 4)
                {
                    d4crits++;
                }
                else if(roll == 1)
                {
                    d4fails++;
                }
            }
            string resultd4List = string.Join(",",d4results.ToArray());
            label1.Text = d4result.ToString() +"\n ("+resultd4List+")";
            
            for (int i = 0; i < d6Rolls; i++)
            {
                var roll = rnd.Next(1, 7);
                d6result += roll;
                d6results.Add(roll);
                if (roll == 6)
                {
                    d6crits++;
                }
                else if (roll == 1)
                {
                    d6fails++;
                }
            }
            string resultd6List = string.Join(",", d6results.ToArray());
            label2.Text = d6result.ToString() + "\n (" + resultd6List + ")";
            
            for (int i = 0; i < d8Rolls; i++)
            {
                var roll = rnd.Next(1, 9);
                d8result += roll;
                d8results.Add(roll);
                if (roll == 8)
                {
                    d8crits++;
                }
                else if (roll == 1)
                {
                    d8fails++;
                }
            }
            string resultd8List = string.Join(",", d8results.ToArray());
            label3.Text = d8result.ToString() + "\n (" + resultd8List + ")";

            for (int i = 0; i < d10Rolls; i++)
            {
                var roll = rnd.Next(1, 11);
                d10result += roll;
                d10results.Add(roll);
                if (roll == 10)
                {
                    d10crits++;
                }
                else if (roll == 1)
                {
                    d10fails++;
                }
            }
            string resultd10List = string.Join(",", d10results.ToArray());
            label4.Text = d10result.ToString() + "\n (" + resultd10List + ")";

            for (int i = 0; i < d12Rolls; i++)
            {
                var roll = rnd.Next(1, 13);
                d12result += roll;
                d12results.Add(roll);
                if (roll == 12)
                {
                    d12crits++;
                }
                else if (roll == 1)
                {
                    d12fails++;
                }
            }
            string resultd12List = string.Join(",", d12results.ToArray());
            label5.Text = d12result.ToString() + "\n (" + resultd12List + ")";

            for (int i = 0; i < d20Rolls; i++)
            {
                var roll = rnd.Next(1, 21);
                d20result += roll;
                d20results.Add(roll);
                if (roll == 20)
                {
                    d20crits++;
                }
                else if (roll == 1)
                {
                    d20fails++;
                }
            }
            string resultd20List = string.Join(",", d20results.ToArray());
            label6.Text = d20result.ToString() + "\n (" + resultd20List + ")";

            for (int i = 0; i < d100Rolls; i++)
            {
                var roll = rnd.Next(1, 101);
                d100result += roll;
                d100results.Add(roll);
                if (roll == 100)
                {
                    d100crits++;
                }
                else if (roll == 1)
                {
                    d100fails++;
                }
            }
            string resultd100List = string.Join(",", d100results.ToArray());
            label7.Text = d100result.ToString() + "\n (" + resultd100List + ")";

            total.Text = (d4result + d6result + d8result + d10result + d12result + d20result + d100result).ToString();
            d4critfail.Text = $"{d4crits}/{d4fails}";
            d6critfail.Text = $"{d6crits}/{d6fails}";
            d8critfail.Text = $"{d8crits}/{d8fails}";
            d10critfail.Text = $"{d10crits}/{d10fails}";
            d12critfail.Text = $"{d12crits}/{d12fails}";
            d20critfail.Text = $"{d20crits}/{d20fails}";
            d100critfail.Text = $"{d100crits}/{d100fails}";
        }

        private void towerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(towerSelect.SelectedIndex == 0)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                panel1.Visible=false;
                panel2.Visible = true;
            }
        }
    }
}
