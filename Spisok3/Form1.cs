using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BL;
using BL.Spisok;

namespace Spisok3
{
    public partial class Form1 : Form
    {
        public OpenFileDialog inputOpenFileDialog = new OpenFileDialog();
        WorkWSpis spis = new WorkWSpis();
        List<string> Prof { get; set; }
        List<string> prof = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            spis.Find(Prof);
            OuText.Lines = spis.Printer();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    ReadFromFile n = new ReadFromFile(inputOpenFileDialog.FileName);
                    spis = n.FileToCharacter(inputOpenFileDialog.FileName);
                    OuText.Lines = spis.Printer();
                    inputOpenFileDialog.Dispose();
                }
                finally { }
        }

        private void OuText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProfButton_Click(object sender, EventArgs e)
        {

            prof.Add(textBox1.Text);
            Prof = prof;

            ProfTB.Text += textBox1.Text + Environment.NewLine ;
            
        }
    }
}
