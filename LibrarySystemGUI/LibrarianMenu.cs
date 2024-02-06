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
        private string loggedInAdmin;
        public LibrarianMenu(string username)
        {
            InitializeComponent();
            this.loggedInAdmin = username;
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
            DisplayMembersForm displayMembersForm = new DisplayMembersForm(loggedInAdmin);
            this.Hide();
            displayMembersForm.Show();
        }

        private void DisplayBooksBtn_Click(object sender, EventArgs e)
        {
            DisplayBooks displayBooks = new DisplayBooks(loggedInAdmin, MenuType.LibrarianMenu);
            this.Hide();
            displayBooks.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(loggedInAdmin);
            addBookForm.Show();
            this.Hide();
        }

        private void removeBookMenubtn_Click(object sender, EventArgs e)
        {
            RemoveBook removeBook = new RemoveBook(loggedInAdmin);
            this.Hide();
            removeBook.Show();
        }

        private void LoanedBooksButton_Click(object sender, EventArgs e)
        {
            DisplayLoans displayLoans = new DisplayLoans(loggedInAdmin);
            this.Hide();
            displayLoans.Show();
        }
        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooks = new ReturnBooks(loggedInAdmin);
            returnBooks.Show();
            this.Hide();
        }
        private void overduePay_Click(object sender, EventArgs e)
        {
            OverduePayment overduePayment = new OverduePayment(loggedInAdmin);
            this.Hide();
            overduePayment.Show();
        }
        private void adminDetails_Click(object sender, EventArgs e)
        {
            AdminDetails adminDetails = new AdminDetails(loggedInAdmin);
            this.Hide();
            adminDetails.Show();
        }
    }
}
