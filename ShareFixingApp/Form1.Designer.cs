namespace ShareFixingApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sharePriceFixing1 = new ShareFixingApp.UC.SharePriceFixing();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cleaningDataUC1 = new ShareFixingApp.UC.CleaningDataUC();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sharePriceFixing1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Share Value fixing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sharePriceFixing1
            // 
            this.sharePriceFixing1.Location = new System.Drawing.Point(91, 6);
            this.sharePriceFixing1.Name = "sharePriceFixing1";
            this.sharePriceFixing1.Size = new System.Drawing.Size(613, 437);
            this.sharePriceFixing1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cleaningDataUC1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "....";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cleaningDataUC1
            // 
            this.cleaningDataUC1.Location = new System.Drawing.Point(60, 34);
            this.cleaningDataUC1.Name = "cleaningDataUC1";
            this.cleaningDataUC1.Size = new System.Drawing.Size(669, 377);
            this.cleaningDataUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Currency Calculator Tools";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UC.SharePriceFixing sharePriceFixing1;
        private UC.CleaningDataUC cleaningDataUC1;
    }
}

