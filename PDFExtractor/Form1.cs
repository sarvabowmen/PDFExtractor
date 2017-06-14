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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using TextExtractor.ExtracterEngine;


namespace TextExtractor
{
    public partial class Form1 : Form
    {
        public string FolderPath { get; set; }

        public IList<string> Files { get; set; }

        public enum ExtractionType { PDF =0, Image = 1 };

        public ExtractionType ExtractionMethod { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbPDF.Checked = true; 
        }

        private void btnFolderSearch_Click(object sender, EventArgs e)
        {
            ExtractionMethod = GetExtrationMethod();

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
                
            
            //rtbExtractedText.Text += sb.ToString();

        }

        private ExtractionType GetExtrationMethod() {

            if (rbPDF.Checked)
                return ExtractionType.PDF;
            else if (rbImage.Checked)
                return ExtractionType.Image;
            else
                return ExtractionType.PDF;
        }
    }
}
