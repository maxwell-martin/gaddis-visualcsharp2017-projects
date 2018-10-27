using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Most_Frequent_Character
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char GetMostFrequentCharcter(string str)
        {
            List<char> charName = new List<char>();
            List<int> count = new List<int>();

            for (int index = 0; index < str.Length; index++)
            {
                if (str[index] != ' ')
                {
                    if (!charName.Contains(str[index]))
                    {
                        charName.Add(str[index]);
                        count.Add(1);
                    }
                    else
                    {
                        count[charName.IndexOf(str[index])] += 1;
                    }
                }
            }

            int highest = count[0];
            char mostFrequentCharacter = charName[0];

            for (int i = 1; i < count.Count; i++)
            {
                if (highest < count[i])
                {
                    highest = count[i];
                    mostFrequentCharacter = charName[i];
                }
            }

            return mostFrequentCharacter;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            string str = inputTextBox.Text;

            if (str != "" && str != null && str[0] != ' ')
            {
                mfcLabel.Text = "*" + GetMostFrequentCharcter(str).ToString() + "*";
            }
            else
            {
                inputTextBox.Clear();
                mfcLabel.Text = "";
            }
        }
    }
}
