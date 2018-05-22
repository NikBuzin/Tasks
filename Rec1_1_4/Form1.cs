using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Rec1_1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutPutTextBox.Text = Convert.ToString(Rec.Fibonachi(Convert.ToInt32(InputTextBox.Text)));
        }

        private void OutPutTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
