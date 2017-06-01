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
using iTextSharp;
using iTextSharp.text.pdf;

namespace PDFExtractor
{
    public partial class Form1 : Form
    {
        public string FolderPath { get; set; }

        public IList<string> Files { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnFolderSearch_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult dr = fbd.ShowDialog();

                if (dr == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    FolderPath = txtFolderPath.Text = fbd.SelectedPath;
                    Files = System.IO.Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + Files.Count.ToString(), "Message");

                }

            }
        }

        private void btnExtractData_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFolderPath.Text) && Files != null && Files.Count > 0) {

                foreach (var file in Files)
                {
                    if (File.Exists(file)) {
                        ExtractData(file);
                    }
                }
            }
        }

        private void ExtractData(string fileName)
        {
            StringBuilder sb = new StringBuilder();

            PdfReader pdfReader = new PdfReader(fileName);
            for (int page = 1; page <= pdfReader.NumberOfPages; page++) { }


        }
    }
}
