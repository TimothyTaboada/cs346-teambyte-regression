using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitTrackRegress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calulate_Click(object sender, EventArgs e)
        {
            double caliBurn = 43.34 + (-0.06 * Convert.ToDouble(runinput.Text)) + (-1.0 * Convert.ToDouble(runinput.Text)) + (0.28 * Convert.ToDouble(runinput.Text));
            outputdisplay.Text = caliBurn.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            stepsinput.Text = "";
            distanceinput.Text = "";
            runinput.Text = "";
            outputdisplay.Text = "";
        }
    }
}
