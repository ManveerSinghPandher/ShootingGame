using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dataspill // TODO: Gjøre at den ikke overwriter, men appender istedenfor.
{
    public partial class ShowScore : Form
    {
        
        int m_Count; // Lokal member variabel tilgjenlig for alle metoder
        int m_Time; // Lokal member variabel tilgjenlig for alle metoder
        public ShowScore(int Count, int Time)
        {
            m_Count = Count;
            m_Time = Time;
            InitializeComponent();
            TimeSpent.Text = Time.ToString() + " seconds";
            MessageLabel.Text = "You reached " + Count + " points in :";
            
            string total = Name + " reached " + Count + " points in " + Time + " seconds";
        }

        private void Save_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PlayerName.Text))
            {
                Validering.Text = "Denne kan ikke være tom.";
                Validering.Visible = true;
                Validering.ForeColor = Color.Red;
            }
            else
            {
                try
                {
                    string TextToPutInFile = "Playername: " + PlayerName.Text + " reached " + m_Count.ToString() + " points in " + m_Time.ToString() + " seconds";
                    string path = @"Scores.txt";
                    
                    using (StreamWriter sw = new StreamWriter(path, true))
                    {
                        sw.WriteLine(TextToPutInFile); 
                    }
                    Save.Enabled = false;
                    Notification.Visible = true;
                    Notification.Text = "You've now saved your highscore!";

                    Validering.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 

            }
        }
    }
  }



       

        
    
