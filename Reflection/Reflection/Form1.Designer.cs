namespace Reflection
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.cboSides = new System.Windows.Forms.ComboBox();
            this.lblSides = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(175, 12);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(97, 49);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll the dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(24, 76);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(238, 173);
            this.lstResults.TabIndex = 2;
            // 
            // cboSides
            // 
            this.cboSides.FormattingEnabled = true;
            this.cboSides.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "12",
            "20"});
            this.cboSides.Location = new System.Drawing.Point(103, 26);
            this.cboSides.Name = "cboSides";
            this.cboSides.Size = new System.Drawing.Size(41, 21);
            this.cboSides.TabIndex = 3;
            this.cboSides.Text = "6";
            // 
            // lblSides
            // 
            this.lblSides.AutoSize = true;
            this.lblSides.Location = new System.Drawing.Point(12, 29);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(85, 13);
            this.lblSides.TabIndex = 4;
            this.lblSides.Text = "Number of Sides";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.lblSides);
            this.Controls.Add(this.cboSides);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ListBox lstResults;
        public System.Windows.Forms.ComboBox cboSides;
        private System.Windows.Forms.Label lblSides;
    }
}

