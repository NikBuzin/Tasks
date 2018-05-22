using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Student;
using System.IO;

namespace TextFile1_3_3
{
    public partial class StudForm : Form
    {
        public OpenFileDialog inputOpenFileDialog = new OpenFileDialog();

        public StudForm()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    ReadWrite i = new ReadWrite(inputOpenFileDialog.FileName);
                    textBox2.Text = i.Reader(inputOpenFileDialog.FileName);
                    inputOpenFileDialog.Dispose();
                }
                finally { }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {

        }

       /* private void AddButton_Click(object sender, EventArgs e)
        {
            /* if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                 try
                 {
                     WorkWS i = new WorkWS(inputOpenFileDialog.FileName);
                     string s = textBox1.Text;
                     i.AddStudent(s);
                     inputOpenFileDialog.Dispose();
                 }
                 finally { }
            ReadWrite i = new ReadWrite(inputOpenFileDialog.FileName);
            string s = textBox1.Text;
            i.AddStudent(s);
        }*/
    }
}
