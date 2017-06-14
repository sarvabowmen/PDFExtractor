namespace TextExtractor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFolderSearch = new System.Windows.Forms.Button();
            this.btnExtractData = new System.Windows.Forms.Button();
            this.rtbExtractedText = new System.Windows.Forms.RichTextBox();
            this.rbPDF = new System.Windows.Forms.RadioButton();
            this.rbImage = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(244, 58);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(245, 20);
            this.txtFolderPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Folder Path :";
            // 
            // btnFolderSearch
            // 
            this.btnFolderSearch.Location = new System.Drawing.Point(495, 56);
            this.btnFolderSearch.Name = "btnFolderSearch";
            this.btnFolderSearch.Size = new System.Drawing.Size(25, 23);
            this.btnFolderSearch.TabIndex = 2;
            this.btnFolderSearch.Text = "...";
            this.btnFolderSearch.UseVisualStyleBackColor = true;
            this.btnFolderSearch.Click += new System.EventHandler(this.btnFolderSearch_Click);
            // 
            // btnExtractData
            // 
            this.btnExtractData.Location = new System.Drawing.Point(244, 103);
            this.btnExtractData.Name = "btnExtractData";
            this.btnExtractData.Size = new System.Drawing.Size(123, 47);
            this.btnExtractData.TabIndex = 3;
            this.btnExtractData.Text = "Scan and Extract";
            this.btnExtractData.UseVisualStyleBackColor = true;
            this.btnExtractData.Click += new System.EventHandler(this.btnExtractData_Click);
            // 
            // rtbExtractedText
            // 
            this.rtbExtractedText.Location = new System.Drawing.Point(91, 175);
            this.rtbExtractedText.Name = "rtbExtractedText";
            this.rtbExtractedText.Size = new System.Drawing.Size(334, 96);
            this.rtbExtractedText.TabIndex = 4;
            this.rtbExtractedText.Text = "";
            // 
            // rbPDF
            // 
            this.rbPDF.AutoSize = true;
            this.rbPDF.Location = new System.Drawing.Point(244, 27);
            this.rbPDF.Name = "rbPDF";
            this.rbPDF.Size = new System.Drawing.Size(46, 17);
            this.rbPDF.TabIndex = 5;
            this.rbPDF.TabStop = true;
            this.rbPDF.Text = "PDF";
            this.rbPDF.UseVisualStyleBackColor = true;
            // 
            // rbImage
            // 
            this.rbImage.AutoSize = true;
            this.rbImage.Location = new System.Drawing.Point(313, 27);
            this.rbImage.Name = "rbImage";
            this.rbImage.Size = new System.Drawing.Size(54, 17);
            this.rbImage.TabIndex = 6;
            this.rbImage.TabStop = true;
            this.rbImage.Text = "Image";
            this.rbImage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Extraction Type :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbImage);
            this.Controls.Add(this.rbPDF);
            this.Controls.Add(this.rtbExtractedText);
            this.Controls.Add(this.btnExtractData);
            this.Controls.Add(this.btnFolderSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolderPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFolderSearch;
        private System.Windows.Forms.Button btnExtractData;
        private System.Windows.Forms.RichTextBox rtbExtractedText;
        private System.Windows.Forms.RadioButton rbPDF;
        private System.Windows.Forms.RadioButton rbImage;
        private System.Windows.Forms.Label label2;
    }
}

