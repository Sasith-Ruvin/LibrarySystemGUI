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
    public partial class LibrarianMenu : Form
    {
        public LibrarianMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            LibrarianLogin librarianLogin = new LibrarianLogin();
            this.Close();
            librarianLogin.Show();
        }

        private void AdminLogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Log Out?","Confirm Logout",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MainMenu mainMenu = new MainMenu();
                this.Close();
                mainMenu.Show();
            }
           
        }

        private void DisplayMemberBtn_Click(object sender, EventArgs e)
        {
            DisplayMembersForm displayMembersForm = new DisplayMembersForm();
            this.Hide();
            displayMembersForm.Show();
        }

        private void DisplayBooksBtn_Click(object sender, EventArgs e)
        {
            DisplayBooks displayBooks = new DisplayBooks();
            this.Hide();
            displayBooks.Show();
        }
    }
}
