using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                output.Text = Cesar(input.Text, 12);
            else
                if (radioButton2.Checked)
                    output.Text = Date(input.Text, dateTimePicker1.Value);
                else
                    output.Text = Square(input.Text);
        }

        protected string Square(String input)
        {
            string s = "";
            int length = Convert.ToInt32(Math.Floor(Math.Sqrt(input.Length+1)));
            MessageBox.Show(length.ToString());
            return s;
        }

        protected string Date(String input, DateTime date)
        {
            int offset = date.Year + date.Month + date.Day;
            return Cesar(input, offset);
        }

        protected string Cesar(string input, int offset)
        {
            String s = "";
            foreach (char c in input)
            {
                s += (char)(c + offset);
            }
            return s;
        }
    }
}
