using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiravilGuessingWord
{
    public partial class Form1 : Form
    {
        StringBuilder word2 = new StringBuilder("");
        StringBuilder word = new StringBuilder("Computer");
        public Form1()
        {

            InitializeComponent();
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0)
                    {
                        word2.Append(word[i]);
                    }
                    else if (i < 7)
                    {
                        word2.Append('?');
                    }
                    else
                    {
                        word2.Append(word[i]);
                    }
                }
                label1.Text += word2.ToString();
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string CorrectAnswer = textBox1.Text;

            if (CorrectAnswer == word.ToString())
            {
                label1.Text = word.ToString();
                MessageBox.Show("Correct Guess!");
            }
            else
            {
                listBox1.Items.Add(CorrectAnswer);
                MessageBox.Show("Wrong Guess!, Try Again");

            }

            textBox1.Clear();
        }
    }
}