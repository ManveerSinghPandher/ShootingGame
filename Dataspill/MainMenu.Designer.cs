﻿namespace Dataspill
{
    partial class MainMenu
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
            this.NewGame = new System.Windows.Forms.Button();
            this.ShowResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(169, 175);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(201, 73);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // ShowResults
            // 
            this.ShowResults.Location = new System.Drawing.Point(169, 296);
            this.ShowResults.Name = "ShowResults";
            this.ShowResults.Size = new System.Drawing.Size(201, 73);
            this.ShowResults.TabIndex = 1;
            this.ShowResults.Text = "Show All Results";
            this.ShowResults.UseVisualStyleBackColor = true;
            this.ShowResults.Click += new System.EventHandler(this.ShowResults_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 440);
            this.Controls.Add(this.ShowResults);
            this.Controls.Add(this.NewGame);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button ShowResults;
    }
}