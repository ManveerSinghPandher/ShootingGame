namespace Dataspill
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
            this.components = new System.ComponentModel.Container();
            this.PlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.MissileTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeSpentToWin = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.EnemyBlackSheep = new System.Windows.Forms.PictureBox();
            this.TimeSpent = new System.Windows.Forms.Label();
            this.RandomNumberOutput = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.Missile = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.EnemyBlackSheepTimer = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBlackSheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Missile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerTimer
            // 
            this.PlayerTimer.Enabled = true;
            this.PlayerTimer.Interval = 5;
            this.PlayerTimer.Tick += new System.EventHandler(this.PlayerTimer_Tick);
            // 
            // EnemyTimer
            // 
            this.EnemyTimer.Enabled = true;
            this.EnemyTimer.Interval = 5;
            this.EnemyTimer.Tick += new System.EventHandler(this.EnemyTimer_Tick);
            // 
            // MissileTimer
            // 
            this.MissileTimer.Enabled = true;
            this.MissileTimer.Interval = 5;
            this.MissileTimer.Tick += new System.EventHandler(this.MissileTimer_Tick);
            // 
            // TimeSpentToWin
            // 
            this.TimeSpentToWin.Enabled = true;
            this.TimeSpentToWin.Interval = 1000;
            this.TimeSpentToWin.Tick += new System.EventHandler(this.TimeSpentToWin_Tick);
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::Dataspill.Properties.Resources.Ocean;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.EnemyBlackSheep);
            this.panel.Controls.Add(this.TimeSpent);
            this.panel.Controls.Add(this.RandomNumberOutput);
            this.panel.Controls.Add(this.Output);
            this.panel.Controls.Add(this.Missile);
            this.panel.Controls.Add(this.Enemy);
            this.panel.Controls.Add(this.Player);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(910, 532);
            this.panel.TabIndex = 1;
            // 
            // EnemyBlackSheep
            // 
            this.EnemyBlackSheep.BackgroundImage = global::Dataspill.Properties.Resources.BlackSheep;
            this.EnemyBlackSheep.Location = new System.Drawing.Point(737, 12);
            this.EnemyBlackSheep.Name = "EnemyBlackSheep";
            this.EnemyBlackSheep.Size = new System.Drawing.Size(146, 35);
            this.EnemyBlackSheep.TabIndex = 7;
            this.EnemyBlackSheep.TabStop = false;
            // 
            // TimeSpent
            // 
            this.TimeSpent.AutoSize = true;
            this.TimeSpent.Location = new System.Drawing.Point(201, 0);
            this.TimeSpent.Name = "TimeSpent";
            this.TimeSpent.Size = new System.Drawing.Size(124, 13);
            this.TimeSpent.TabIndex = 6;
            this.TimeSpent.Text = "You\'ve spent: 0 seconds";
            // 
            // RandomNumberOutput
            // 
            this.RandomNumberOutput.AutoSize = true;
            this.RandomNumberOutput.Location = new System.Drawing.Point(367, 0);
            this.RandomNumberOutput.Name = "RandomNumberOutput";
            this.RandomNumberOutput.Size = new System.Drawing.Size(81, 13);
            this.RandomNumberOutput.TabIndex = 5;
            this.RandomNumberOutput.Text = " Current Speed:";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(82, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(80, 13);
            this.Output.TabIndex = 4;
            this.Output.Text = "Your score is: 0";
            // 
            // Missile
            // 
            this.Missile.BackColor = System.Drawing.Color.Yellow;
            this.Missile.Image = global::Dataspill.Properties.Resources.Missile;
            this.Missile.Location = new System.Drawing.Point(151, 187);
            this.Missile.Name = "Missile";
            this.Missile.Size = new System.Drawing.Size(32, 61);
            this.Missile.TabIndex = 3;
            this.Missile.TabStop = false;
            this.Missile.Visible = false;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Green;
            this.Enemy.Image = global::Dataspill.Properties.Resources.Sheep;
            this.Enemy.Location = new System.Drawing.Point(774, 91);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(109, 69);
            this.Enemy.TabIndex = 2;
            this.Enemy.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Red;
            this.Player.Image = global::Dataspill.Properties.Resources.Submarine;
            this.Player.Location = new System.Drawing.Point(630, 410);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(189, 119);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // EnemyBlackSheepTimer
            // 
            this.EnemyBlackSheepTimer.Interval = 5;
            this.EnemyBlackSheepTimer.Tick += new System.EventHandler(this.EnemyBlackSheepTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 532);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SheepHunter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBlackSheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Missile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer PlayerTimer;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Timer EnemyTimer;
        private System.Windows.Forms.PictureBox Missile;
        private System.Windows.Forms.Timer MissileTimer;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label RandomNumberOutput;
        private System.Windows.Forms.Timer TimeSpentToWin;
        private System.Windows.Forms.Label TimeSpent;
        private System.Windows.Forms.PictureBox EnemyBlackSheep;
        private System.Windows.Forms.Timer EnemyBlackSheepTimer;
    }
}

