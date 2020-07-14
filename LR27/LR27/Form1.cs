using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR27
{
    public partial class Form1 : Form
    {
        public double x;
        public void pound()
        {
            x = Math.Round((Convert.ToDouble(textBox2.Text) / 454), 3);
        }

        public void pood()
        {
            x = Math.Round((Convert.ToDouble(textBox2.Text) / 16381), 3);
        }
        public void ounce()
        {
            x = Math.Round((Convert.ToDouble(textBox2.Text) / 28.35), 3);
        }
        public void drachm()
        {
            x = Math.Round((Convert.ToDouble(textBox2.Text) / 1.772), 3);
        }
        public void gran()
        {
            x = Math.Round((Convert.ToDouble(textBox2.Text) * 15.432), 3);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (listBox1.SelectedItem == "Фунт")
                {
                    pound();
                    richTextBox1.AppendText(Convert.ToDouble(textBox2.Text) + " Грамм(ов)" + " = " + x + " Фунт(ов)\n");
                }
                if (listBox1.SelectedItem == "Пуд")
                {
                    pood();
                    richTextBox1.AppendText(Convert.ToDouble(textBox2.Text) + " Грамм(ов)" + " = " + x + " Пуд(ов)\n");
                }
                if (listBox1.SelectedItem == "Унция")
                {
                    ounce();
                    richTextBox1.AppendText(Convert.ToDouble(textBox2.Text) + " Грамм(ов)" + " = " + x + " Унция(й)\n");
                }
                if (listBox1.SelectedItem == "Драхм")
                {
                    drachm();
                    richTextBox1.AppendText(Convert.ToDouble(textBox2.Text) + " Грамм(ов)" + " = " + x + " Драхм\n");
                }
                if (listBox1.SelectedItem == "Гран")
                {
                    gran();
                    richTextBox1.AppendText(Convert.ToDouble(textBox2.Text) + " Грамм(ов)" + " = " + x + " Гран\n");
                }
            
                
                radioButton2.Checked = false;
                
            }
            if (radioButton2.Checked)
            {

                radioButton1.Checked = false;
            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                richTextBox1.Font = new Font("Times New Roman", 8, FontStyle.Italic);
            }
            else
            {
                richTextBox1.Font = new Font("Times New Roman", 8, FontStyle.Regular);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                richTextBox1.ForeColor = Color.Red;
            }
            else
            {
                richTextBox1.ForeColor = Color.Black;
            }
        }
    }
}
