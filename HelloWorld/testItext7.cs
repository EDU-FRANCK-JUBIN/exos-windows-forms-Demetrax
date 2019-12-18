using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace HelloWorld
{
    public partial class testItext7 : Form
    {
        public testItext7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string monTexte = richTextBox1.Text;
            string dest = @"D:\testCsharp\testpdf.pdf";
            var writer = new PdfWriter(dest);
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);
            document.Add(new Paragraph(monTexte));
            document.Close();
        }
    }
}
