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
    public partial class Form4 : Form
    {
        int sayac = 0;
        public Form4()
        {
            InitializeComponent();
            int sayac = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            timer1.Interval = 1000;
        }

        private void sıfırşaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayac = 0;
        }

        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
        
        }

        private void Saniy(object sender, EventArgs e)
        {

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
                
                timer1.Start();
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
                timer1.Stop();
                MessageBox.Show(sayac.ToString(),"Dosyayı açmak ile kaydetmek arasında geçen zaman");
                sw.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
