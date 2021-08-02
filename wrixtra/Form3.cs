using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wrixtra
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tüm Dosyalar|*";
            ofd.Title = "Dosya Aç";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                
                sr.Close();
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Tüm Dosyalar|*";
            svf.Title = "Dosya Kaydet";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
