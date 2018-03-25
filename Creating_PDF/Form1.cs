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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Creating_PDF
{
    public partial class Form1 : Form
    {
      
        string path = "C:\\Users\\Claveria\\Documents\\Visual Studio 2012\\Projects\\Creating_PDF\\Creating_PDF\\bin\\Debug\\Test.pdf";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void rtxb1_KeyUp(object sender, KeyEventArgs e)
        {
            string write = rtxb1.Text;
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 50, 50, 25, 35);
            PdfWriter wrl = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();
            Paragraph pr = new Paragraph("                                               " + write);
            doc.Add(pr);
            doc.Close();
        }

        private void rtxb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
