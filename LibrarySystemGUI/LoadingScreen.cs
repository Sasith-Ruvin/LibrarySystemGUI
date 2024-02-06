using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemGUI
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            LoadingBar.Increment(5);
            if(LoadingBar.Value == 100)
            {
                timer1.Enabled = false;
                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();
            }
        }
    }
}
