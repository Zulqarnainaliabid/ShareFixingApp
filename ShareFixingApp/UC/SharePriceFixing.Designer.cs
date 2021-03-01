namespace ShareFixingApp.UC
{
    partial class SharePriceFixing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpReport = new System.Windows.Forms.DateTimePicker();
            this.btnFix = new System.Windows.Forms.Button();
            this.totalProfit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totalProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpReport
            // 
            this.dtpReport.Location = new System.Drawing.Point(120, 91);
            this.dtpReport.Name = "dtpReport";
            this.dtpReport.Size = new System.Drawing.Size(277, 22);
            this.dtpReport.TabIndex = 0;
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(451, 93);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 1;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // totalProfit
            // 
            this.totalProfit.Location = new System.Drawing.Point(120, 43);
            this.totalProfit.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.totalProfit.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.totalProfit.Name = "totalProfit";
            this.totalProfit.Size = new System.Drawing.Size(120, 22);
            this.totalProfit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total profit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(36, 155);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(556, 151);
            this.Summary.TabIndex = 5;
            this.Summary.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(410, 326);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Summary:";
            // 
            // SharePriceFixing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalProfit);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.dtpReport);
            this.Name = "SharePriceFixing";
            this.Size = new System.Drawing.Size(637, 442);
            ((System.ComponentModel.ISupportInitialize)(this.totalProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReport;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.NumericUpDown totalProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Summary;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
    }
}
