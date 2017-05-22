namespace RawByteWriter
{
    partial class RawByteWriter
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.rdbStartHex = new System.Windows.Forms.RadioButton();
            this.rdbStartDec = new System.Windows.Forms.RadioButton();
            this.rdbLengthDec = new System.Windows.Forms.RadioButton();
            this.rdbLengthHex = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Location = new System.Drawing.Point(93, 17);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(29, 13);
            this.lblSelectedFile.TabIndex = 2;
            this.lblSelectedFile.Text = "File: ";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(96, 2);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(81, 20);
            this.txtStart.TabIndex = 3;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(96, 2);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(81, 20);
            this.txtLength.TabIndex = 4;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 5);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(65, 13);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Startposition";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 5);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(76, 13);
            this.lblLength.TabIndex = 6;
            this.lblLength.Text = "Length of data";
            // 
            // rdbStartHex
            // 
            this.rdbStartHex.AutoSize = true;
            this.rdbStartHex.Checked = true;
            this.rdbStartHex.Location = new System.Drawing.Point(183, 3);
            this.rdbStartHex.Name = "rdbStartHex";
            this.rdbStartHex.Size = new System.Drawing.Size(44, 17);
            this.rdbStartHex.TabIndex = 7;
            this.rdbStartHex.TabStop = true;
            this.rdbStartHex.Text = "Hex";
            this.rdbStartHex.UseVisualStyleBackColor = true;
            this.rdbStartHex.CheckedChanged += new System.EventHandler(this.rdbStartHex_CheckedChanged);
            // 
            // rdbStartDec
            // 
            this.rdbStartDec.AutoSize = true;
            this.rdbStartDec.Location = new System.Drawing.Point(233, 3);
            this.rdbStartDec.Name = "rdbStartDec";
            this.rdbStartDec.Size = new System.Drawing.Size(45, 17);
            this.rdbStartDec.TabIndex = 8;
            this.rdbStartDec.Text = "Dec";
            this.rdbStartDec.UseVisualStyleBackColor = true;
            // 
            // rdbLengthDec
            // 
            this.rdbLengthDec.AutoSize = true;
            this.rdbLengthDec.Location = new System.Drawing.Point(233, 3);
            this.rdbLengthDec.Name = "rdbLengthDec";
            this.rdbLengthDec.Size = new System.Drawing.Size(45, 17);
            this.rdbLengthDec.TabIndex = 10;
            this.rdbLengthDec.Text = "Dec";
            this.rdbLengthDec.UseVisualStyleBackColor = true;
            // 
            // rdbLengthHex
            // 
            this.rdbLengthHex.AutoSize = true;
            this.rdbLengthHex.Checked = true;
            this.rdbLengthHex.Location = new System.Drawing.Point(183, 3);
            this.rdbLengthHex.Name = "rdbLengthHex";
            this.rdbLengthHex.Size = new System.Drawing.Size(44, 17);
            this.rdbLengthHex.TabIndex = 9;
            this.rdbLengthHex.TabStop = true;
            this.rdbLengthHex.Text = "Hex";
            this.rdbLengthHex.UseVisualStyleBackColor = true;
            this.rdbLengthHex.CheckedChanged += new System.EventHandler(this.rdbLengthHex_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbStartHex);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Controls.Add(this.rdbStartDec);
            this.panel1.Controls.Add(this.txtStart);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 24);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLength);
            this.panel2.Controls.Add(this.rdbLengthHex);
            this.panel2.Controls.Add(this.rdbLengthDec);
            this.panel2.Controls.Add(this.txtLength);
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 24);
            this.panel2.TabIndex = 12;
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Enabled = false;
            this.btnSelectOutput.Location = new System.Drawing.Point(96, 91);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(81, 23);
            this.btnSelectOutput.TabIndex = 13;
            this.btnSelectOutput.Text = "Save as...";
            this.btnSelectOutput.UseVisualStyleBackColor = true;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // RawByteWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 120);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "RawByteWriter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extract bytes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.RadioButton rdbStartHex;
        private System.Windows.Forms.RadioButton rdbStartDec;
        private System.Windows.Forms.RadioButton rdbLengthDec;
        private System.Windows.Forms.RadioButton rdbLengthHex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelectOutput;
    }
}

