namespace Dataspill
{
    partial class ShowAllResults
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
            this.Results = new System.Windows.Forms.RichTextBox();
            this.Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(-3, 48);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(504, 382);
            this.Results.TabIndex = 0;
            this.Results.Text = "";
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(-3, 1);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(504, 50);
            this.Show.TabIndex = 1;
            this.Show.Text = "CLICK ME TO SHOW SCORES";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // ShowAllResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 430);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Results);
            this.Name = "ShowAllResults";
            this.Text = "ShowAllResults";
            this.Load += new System.EventHandler(this.ShowAllResults_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.Button Show;
    }
}