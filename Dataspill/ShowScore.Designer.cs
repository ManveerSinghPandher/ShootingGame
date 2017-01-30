namespace Dataspill
{
    partial class ShowScore
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.TimeSpent = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.TypeNameToSaveScore = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Validering = new System.Windows.Forms.Label();
            this.Notification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(440, 49);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(128, 13);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "You reached 20 points in:";
            // 
            // TimeSpent
            // 
            this.TimeSpent.AutoSize = true;
            this.TimeSpent.Location = new System.Drawing.Point(574, 49);
            this.TimeSpent.Name = "TimeSpent";
            this.TimeSpent.Size = new System.Drawing.Size(57, 13);
            this.TimeSpent.TabIndex = 1;
            this.TimeSpent.Text = "x Seconds";
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(645, 116);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(100, 20);
            this.PlayerName.TabIndex = 2;
            // 
            // TypeNameToSaveScore
            // 
            this.TypeNameToSaveScore.AutoSize = true;
            this.TypeNameToSaveScore.Location = new System.Drawing.Point(440, 119);
            this.TypeNameToSaveScore.Name = "TypeNameToSaveScore";
            this.TypeNameToSaveScore.Size = new System.Drawing.Size(199, 13);
            this.TypeNameToSaveScore.TabIndex = 3;
            this.TypeNameToSaveScore.Text = "Type your name to save Score and Time";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(645, 154);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 29);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save my score";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Save_MouseClick);
            // 
            // Validering
            // 
            this.Validering.AutoSize = true;
            this.Validering.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Validering.Location = new System.Drawing.Point(645, 135);
            this.Validering.Name = "Validering";
            this.Validering.Size = new System.Drawing.Size(0, 13);
            this.Validering.TabIndex = 5;
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.Location = new System.Drawing.Point(659, 200);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(0, 13);
            this.Notification.TabIndex = 6;
            this.Notification.Visible = false;
            // 
            // ShowScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 440);
            this.Controls.Add(this.Notification);
            this.Controls.Add(this.Validering);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TypeNameToSaveScore);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.TimeSpent);
            this.Controls.Add(this.MessageLabel);
            this.Name = "ShowScore";
            this.Text = "ShowScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label TimeSpent;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Label TypeNameToSaveScore;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label Validering;
        private System.Windows.Forms.Label Notification;
    }
}