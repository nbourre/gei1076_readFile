namespace ex_lecture_fichier
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
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiledialog = new System.Windows.Forms.Button();
            this.ofdRechercheFichier = new System.Windows.Forms.OpenFileDialog();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Location = new System.Drawing.Point(56, 9);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(185, 20);
            this.txtFilename.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fichier";
            // 
            // btnFiledialog
            // 
            this.btnFiledialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiledialog.Location = new System.Drawing.Point(247, 8);
            this.btnFiledialog.Name = "btnFiledialog";
            this.btnFiledialog.Size = new System.Drawing.Size(29, 23);
            this.btnFiledialog.TabIndex = 2;
            this.btnFiledialog.Text = "...";
            this.btnFiledialog.UseVisualStyleBackColor = true;
            this.btnFiledialog.Click += new System.EventHandler(this.btnFiledialog_Click);
            // 
            // ofdRechercheFichier
            // 
            this.ofdRechercheFichier.FileName = "openFileDialog1";
            // 
            // txtFileContent
            // 
            this.txtFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileContent.Location = new System.Drawing.Point(12, 50);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.Size = new System.Drawing.Size(264, 231);
            this.txtFileContent.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 293);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.btnFiledialog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilename);
            this.Name = "Form1";
            this.Text = "Lecteur de fichier texte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiledialog;
        private System.Windows.Forms.OpenFileDialog ofdRechercheFichier;
        private System.Windows.Forms.TextBox txtFileContent;
    }
}

