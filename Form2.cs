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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            label1.Text = "The Post Office is really " + Globals.one;
            label2.Text = "with your " + Globals.two + " friends.";
            label3.Text = "Go to some place near a " + Globals.three;
            label4.Text = "Or if that doesn't work, go to a " + Globals.four;
            label5.Text = "See if you can ride " + Globals.five;

        }


    }
}
