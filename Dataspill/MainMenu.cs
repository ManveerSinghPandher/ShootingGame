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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Form1 Newgame= new Form1();
            Newgame.Show();
        }

        private void ShowResults_Click(object sender, EventArgs e)
        {
            ShowAllResults Results = new ShowAllResults();
            Results.Show();
        }
    }
}
