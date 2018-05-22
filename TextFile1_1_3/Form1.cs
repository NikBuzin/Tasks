using System;
using System.Windows.Forms;
using System.IO;
using BL;
using System.Linq;

namespace TextFile1_1_3
{
    public partial class Form1 : Form
    {
        public OpenFileDialog inputOpenFileDialog = new OpenFileDialog();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void DeletelastButton_Click(object sender, EventArgs e)
        {
            WorkWSpisok deletel = new WorkWSpisok(inputOpenFileDialog.FileName);
            OutputTextBox.Lines = deletel.DeleteString(deletel.Lines.Count-1);
            MessageBox.Show("Файля сохранен");
        }

        private void Delete1strButton_Click(object sender, EventArgs e)
        {
            WorkWSpisok deletel = new WorkWSpisok(inputOpenFileDialog.FileName);
            OutputTextBox.Lines = deletel.DeleteString(0);
            MessageBox.Show("Файля сохранен");
        }

        private void DeleteNumber_Click(object sender, EventArgs e)
        {
            WorkWSpisok deletel = new WorkWSpisok(inputOpenFileDialog.FileName);
            OutputTextBox.Lines = deletel.DeleteString(Convert.ToInt16(DeleteTextBox.Text));
            MessageBox.Show("Файля сохранен");
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            inputOpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    WorkWSpisok f = new WorkWSpisok(inputOpenFileDialog.FileName);
                    textBox1.Lines = f.Lines.ToArray();
                    inputOpenFileDialog.Dispose();
                }
                finally { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
