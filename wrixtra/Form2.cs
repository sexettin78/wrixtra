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
using Microsoft.Win32;

namespace wrixtra
{
    public partial class wrixtra : Form
    
    
    {
        public wrixtra()
            
        {
            InitializeComponent();
            UTF8Encoding utf8 = new UTF8Encoding();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();

            ac.Title = "Dosya aç";
            ac.Filter = "Tüm Dosyalar|*";
            
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(ac.FileName, RichTextBoxStreamType.PlainText);
                label2.Text = ac.FileName;
            };
            
            
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Title = "Dosya kaydet";
            kaydet.Filter = "Tüm Dosyalar|*";
            if (kaydet.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            {
                richTextBox1.SaveFile(kaydet.FileName, RichTextBoxStreamType.PlainText);
                
            }
        }

        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Green;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Red;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Orange;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Yellow;
        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Purple;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Pink;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
        }

        private void açıkMaviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Aqua;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void maviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void yeşilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void kırmızıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void turuncuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Orange;
        }

        private void sarıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void morToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Purple;
        }

        private void beyazToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
        }

        private void açıkMaviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Aqua;
        }

        private void siyahToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void pembeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Pink;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            
            
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "";
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yeniDosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tüm Dosyalar|*";
            ofd.Title = "Dosya Aç";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                label2.Text = ofd.FileName;
                sr.Close();
            }
        }

        private void birÖncekiİşlemeDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void birSonrakiİşlemeDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        
        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wrixtra_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void açToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = richTextBox1.BackColor;
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sürümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mevcut Sürüm = 1.0","Sürüm");
        }

        private void yapımcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapımcı -> Sexettin","Yapımcı");
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kodlara ulaşmak için github adresi -> https://github.com/sexettin78/wrixtra","Github Adresi");
        }

        private void karakterSayısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.TextLength.ToString(), "Karakter Sayısı");
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            
        }

        private void yazıBüyüklüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 5);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 10);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 15);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 20);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 25);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 30);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 35);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 40);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 45);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 50);
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
        }

        private void öNEMLİBİLGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ctrl tuşuna basılı tutarken mousenin scrolunu ileri kaydırırsanız font büyür.Geriye doğru kaydırırsanız font küçülür","Önemli bilgi");
        }

        private void yazıBiçimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Bold);
        }

        private void italikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Italic);
        }

        private void altıÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Underline);
        }

        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Strikeout);
            
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void temizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void yeniDosyaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void htmlhtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<html> </html>";
        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<div> </div>";
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Text = richTextBox1.Text +=  "<!DOCTYPE html> \n <html> \n <head> \n <meta charset=\"utf-8\"> \n <title></title> \n </head> \n <body> \n  </body> \n </html>";

        }

        private void titletitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<title> </title>";
        }

        private void tabletableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<table> </table>";
        }

        private void trtrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<tr> </tr>";
        }

        private void tdtdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<td> </td>";
        }

        private void h1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<h1> </h1>";
        }

        private void ppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<p> </p>";
        }

        private void brToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<br>";
        }

        private void h2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<h2> </h2>";
        }

        private void h3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<h3> </h3>";
        }

        private void h4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<h4> </h4>";
        }

        private void h5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<h5> </h5>";
        }

        private void h6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<h6> </h6>";
        }

        private void bodybodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<body> </body>";
        }

        private void headheadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<head> </head>";
        }

        private void şablonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<?php \n ?>";
        }

        private void echoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "echo ";
        }

        private void scriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "<script> </script>";
        }

        private void alertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string tirnak = ";";
            richTextBox1.Text = richTextBox1.Text += "alert()"+tirnak;
        }

        private void ifToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void ifToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "if () {\n}";
        }

        private void elseifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "elseif () {\n}";
        }

        private void elseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text += "else {\n}";
        }

    }
}
