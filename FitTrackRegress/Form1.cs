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
