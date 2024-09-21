using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_T2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string regexPattern = @"^[0-9]+[eE][+-]?[0-9]+$";

            if (Regex.IsMatch(input, regexPattern))
            {
                label1.Text = "Valid input!";
                dataGridView1.Rows.Add(input);
            }
            else
            {
                label1.Text = "Invalid input!";
            }
        }
    }
}
