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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberLogin memberLogin = new MemberLogin();
            memberLogin.Show();
            this.Hide();
        }
        private void Close_button_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender,e,this);
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            LibrarianLogin librarianLogin = new LibrarianLogin();
            this.Hide();
            librarianLogin.Show();
        }

        private void MemberLoginBtn_MouseEnter(object sender, EventArgs e)
        {
            MemberLoginBtn.BackColor = Color.MidnightBlue;
        }

        private void MemberLoginBtn_MouseLeave(object sender, EventArgs e)
        {
            MemberLoginBtn.BackColor = Color.FromArgb(42, 72, 88);
        }

        private void AdminLoginBtn_MouseEnter(object sender, EventArgs e)
        {
            AdminLoginBtn.BackColor = Color.MidnightBlue;
        }

        private void AdminLoginBtn_MouseLeave(object sender, EventArgs e)
        {
            AdminLoginBtn.BackColor = Color.FromArgb(42, 72, 88);
        }
    }
}
