using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Sort2Kyes;

namespace Sort2Keys
{
    public partial class Sort2Keys : Form
    {
        public OpenFileDialog inputOpenFileDialog = new OpenFileDialog();
        WorkWSort work = new WorkWSort();

        public Sort2Keys()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InBut_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    LoadPeople n = new LoadPeople(inputOpenFileDialog.FileName);
                    work = n.FileToPeople(inputOpenFileDialog.FileName);
                    OutputTB1.Text = work.Printer();
                    inputOpenFileDialog.Dispose();
                }
                finally { }
        }

        private void OutBut_Click(object sender, EventArgs e)
        {
            work.SortName();
            OutputTB2.Text = work.Printer();
        }
    }
}
