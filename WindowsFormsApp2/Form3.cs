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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            char[] pole = new char[textBox2.TextLength];
            int cislo = (int)numericUpDown1.Value;
            string mala = "abcdefghijklmnoprstquvwxyz";
            string velka = "ABCDEFGHIJKLMOPRSTUVWXYZ";    
            int i = 0;
            foreach(char znak in textBox2.Text)
            {
                if (mala.Contains(znak) || velka.Contains(znak))
                {
                    if (((int)znak + cislo >= 65 && (int)znak + cislo <= 90) || ((int)znak + cislo >= 97 && (int)znak + cislo <= 122))
                    {
                        pole[i] = (char)((int)znak + cislo);
                    }
                    else
                    {
                        pole[i] = (char)((int)znak + (cislo - 26));
                    }
                }
                else
                {
                    pole[i] = znak;
                }
                i++;
            }
            label3.Text = "Zašifrovaný text: " + new string(pole);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            char[] pole = new char[textBox2.TextLength];
            int cislo = (int)numericUpDown1.Value;
            string mala = "abcdefghijklmnoprstquvwxyz";
            string velka = "ABCDEFGHIJKLMOPRSTUVWXYZ";
            int i = 0;
            foreach (char znak in textBox2.Text)
            {
                if (mala.Contains(znak) || velka.Contains(znak))
                {
                    if (((int)znak - cislo >= 65 && (int)znak - cislo <= 90) || ((int)znak - cislo >= 97 && (int)znak - cislo <= 122))
                    {
                        pole[i] = (char)((int)znak - cislo);
                    }
                    else
                    {
                        pole[i] = (char)((int)znak - (cislo - 26));
                    }
                }
                else
                {
                    pole[i] = znak;
                }
                i++;
            }
            label3.Text = "odšifrovaný text: " + new string(pole);
        }
    }
}
