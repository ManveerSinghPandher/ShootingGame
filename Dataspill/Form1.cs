using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dataspill
{
   
    public partial class Form1 : Form
    {
       
        bool PlayerMovingRight, PlayerMovingLeft, FireBullet;
        int PixelsFromRightPanelSide = 195;
        int BulletSpeed = 10;
        int Speed = 10; // Dette er startvariablen til speeden, første gang. Deklarert utenfor, så den ikke ticker.
        int Count, Time;
        int AmountOfPointsToWin = 20;
      
        public Form1()
        {
            InitializeComponent();
            MoveEnemyOutOfScreen();
            MoveEnemyBlackSheepOutOfScreen();
            RemoveColorFromLabels();
            RandomNumberOutput.Text = " Current Speed:" + Speed.ToString(); // For å vise farten på den første

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) // Høyre tastetrykk holdes inne
            {
                PlayerMovingRight = true;  // Det er sant at vi skal bevege oss til høyre
                Player.Left -= 5;
            }
            if (e.KeyCode == Keys.Left) // Venstre tastetrykk holdes inne 
            {
                PlayerMovingLeft = true; // Det er sant at vi skal bevege oss til venstre
                Player.Left -= 5;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (!FireBullet) // Kulen er utenfor 
                {
                    FireBullet = true;
                    MissileToStartPosition();
                }
            }
          
        }


        private void MissileToStartPosition() // Denne metoden vil hente missilen, og sette den på startposisjonen
        {
            Missile.Top = Player.Top;
            Missile.Left = Player.Left;    
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) // Høyre tastetrykk slippes 
            {
                PlayerMovingRight = false; // Hvis man slipper knappen, vil det være false at man beveger seg til høyre 
            }
            if (e.KeyCode == Keys.Left) // Venstre tastetrykk slippes
            {
                PlayerMovingLeft = false; // Hvis man slipper knappen, vil det være false at man beveger seg til venstre 
            }
        }

        private void PlayerTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Location.X >= panel.Width - PixelsFromRightPanelSide) // Hardkodet x-akse begrensning. Forbedre koden. 
            {
                PlayerMovingRight = false; //Slutter å bevege seg til høyre, "deaktiverer" bevegelse til høyre. 
            }

            if (Player.Location.X <= 5) // Hardkodet x-akse begrensning. Forbedre koden. 
            {
                PlayerMovingLeft = false; //Slutter å bevege seg til venstre, "deaktiverer" bevegelse til venstre. 
            }

            if (PlayerMovingRight == true)
            {
                Player.Left += 5; // Flytter x-aksen 5px til høyre
            }

            if (PlayerMovingLeft == true)
            {
                Player.Left -= 5; // Flytter x-aksen 5px til venstre 
            }
        }

        private void MoveEnemyOutOfScreen()
        { // Denne metoden sparer Visual Studio for RAM, hvor vi slipper å lage New Enemy hele tiden.
            Enemy.Location = new Point(Enemy.Location.X + 950, Enemy.Location.Y);
        }

        private void MoveEnemyBlackSheepOutOfScreen()
        { // Denne metoden sparer Visual Studio for RAM, hvor vi slipper å lage New Enemy hele tiden.
            EnemyBlackSheep.Location = new Point(Enemy.Location.X + 950, Enemy.Location.Y);
        }

        

        private void EnemyBlackSheepTimer_Tick(object sender, EventArgs e)
        {
            EnemyBlackSheep.Location = new Point(EnemyBlackSheep.Location.X - 20, EnemyBlackSheep.Location.Y);
            if (Missile.Bounds.IntersectsWith(EnemyBlackSheep.Bounds))
            {
                MoveEnemyBlackSheepOutOfScreen();
                EnemyBlackSheepTimer.Stop();
                Count = Count + 2;
                Output.Text = "You score is " + Count.ToString();
            }
        }


        private void TimeSpentToWin_Tick(object sender, EventArgs e) // Kode fra Lasse Bertnzen, stoppeklokke
        {
            Console.WriteLine("Tick!!");
            Time++;
            TimeSpent.Text = "You've spent: "+ Time.ToString() + " seconds";
            if (Time % 10 == 0)
            {
                MoveEnemyBlackSheepOutOfScreen();
                EnemyBlackSheepTimer.Start(); // #BUG // F
            }
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        { 
            Enemy.Location = new Point(Enemy.Location.X - Speed, Enemy.Location.Y); //Beveger den til venstre med 3px
            if (Enemy.Right <= 0) //Hvis Venstresiden av fienden er helt til venstre på skjermen
            {
                MoveEnemyOutOfScreen(); //Flytter x posisjonen til 950, starter om igjen
                NewRandomSpeed(); 
            }

            if (Missile.Bounds.IntersectsWith(Enemy.Bounds))
            {
                Count++; // Teller antall gangen kulen har truffet fienden
                Output.Text = "You score is " + Count.ToString();
                MoveEnemyOutOfScreen();
                MissileToStartPosition();
                NewRandomSpeed();
                FireBullet = false;
                Missile.Visible = true;

                if (Count >= AmountOfPointsToWin) // Hvis du har nok poeng for å vinne
                {
                    StopEnemyMoving();
                    PlayerTimer.Stop();
                    TimeSpentToWin.Stop(); // Stopper timeren som forteller hvor lang tid du har brukt
                    ShowScore showMyResult = new ShowScore(Count, Time); // Videresender poeng og tid til nytt skjema
                    showMyResult.Show(); // Gjør skjemaet synlig
                    EnemyBlackSheepTimer.Stop(); // Stopper alle svarte sauer
                }

            }
        }


        private void MissileTimer_Tick(object sender, EventArgs e)
        {
            if (FireBullet) // Hvis en kule blir skutt (Er true) 
            {
                Missile.Visible = true; // Gjør kulen synlig 
                Missile.Location = new Point(Missile.Location.X, Missile.Location.Y - BulletSpeed);  //farten er piksler
            }
            
            if (Missile.Bottom <= 0)
            {
                FireBullet = false;
                Missile.Visible = true;
                MissileToStartPosition();
            }
           
        }

        private void NewRandomSpeed()
        {
            Random randomNumber = new Random();
            Speed = randomNumber.Next(5, 20);
            RandomNumberOutput.Text = " Current Speed:" + Speed.ToString();
        }

        private void StopEnemyMoving()
        {
            EnemyTimer.Stop();
        }
        private void RemoveColorFromLabels()
        {
            TimeSpent.BackColor = System.Drawing.Color.Transparent;
            RandomNumberOutput.BackColor = System.Drawing.Color.Transparent;
            Output.BackColor = System.Drawing.Color.Transparent;

        }
       
    }
}
