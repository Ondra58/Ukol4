using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {        
            char[] pole = new char [textBox2.TextLength];
            int i = 0;
            foreach(char znak in textBox2.Text)
            {
                
                if((int)znak < 65 || (int)znak > 90)
                {
                    pole[i] = znak;
                }
                i++;
            }
            textBox2.Clear();
            foreach (char znak in pole)
            {
                textBox2.Text += znak;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            text = text.Replace("*", "");
            textBox2.Text = text;
        }
    }
}
