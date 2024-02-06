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
    public partial class MemberMenu : Form
    {
        private string loggedInUser;
        Library library;
        public MemberMenu(string username)
        {
            InitializeComponent();
            this.loggedInUser = username;
            this.library = new Library();

        }
        private void MemberMenu_Load(object sender, EventArgs e)
        {

        }
        private void Close_button_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MemberLogin memberLogin = new MemberLogin();
            this.Close();
            memberLogin.Show();
        }

        private void MemberLogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to Log out?","Confirm Logout",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MainMenu mainMenu = new MainMenu();
                this.Close();
                mainMenu.Show();
            }    
        }
        private void MemDisplayBooksBtn_Click(object sender, EventArgs e)
        {
            DisplayBooks displayBooks = new DisplayBooks(loggedInUser,MenuType.MemberMenu);
            this.Hide();
            displayBooks.Show();
        }

        private void MemberDetailsBtn_Click(object sender, EventArgs e)
        {
            MemberDetails memberDetails = new MemberDetails(loggedInUser);
            memberDetails.Show();
            this.Hide();
        }

        private void BorrowBookBtn_Click(object sender, EventArgs e)
        {
            BorrowBookMenu borrowBookMenu = new BorrowBookMenu(loggedInUser);
            borrowBookMenu.Show();
            this.Hide();
        }
        private void MemDisplayLoanBtn_Click(object sender, EventArgs e)
        {
            PersonalLoans personalLoans = new PersonalLoans(loggedInUser);
            this.Hide();
            personalLoans.Show();
        }
        private void CheckOverdueBtn_Click(object sender, EventArgs e)
        {
            double overdueAmount = library.GetMemberOverdue(loggedInUser);
            if (overdueAmount > 0)
            {
                MessageBox.Show($"Your Current Overdue amount: {overdueAmount}", "Overdue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You do not have Overdue", "No Overdue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
