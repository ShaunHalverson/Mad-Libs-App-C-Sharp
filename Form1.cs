using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibs
{
    public partial class MadLibs : Form
    {
        public MadLibs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.one = textBox1.Text;
            Globals.two = textBox2.Text;
            Globals.three = textBox3.Text;
            Globals.four = textBox4.Text;
            Globals.five = textBox5.Text;

            if (Globals.one.Length == 0 
                || Globals.two.Length == 0 
                || Globals.three.Length == 0 
                || Globals.four.Length == 0 
                || Globals.five.Length == 0) 
            {
                label1.Text = "Please fill in all fields.";
            }
            else
            {
                Form form2 = new Form2();
                form2.Show();
            }
        }
    }

    public static class Globals
    {
        public static string one, two, three, four, five;
    }
}
