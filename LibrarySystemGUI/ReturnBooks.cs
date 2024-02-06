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
    public partial class ReturnBooks : Form
    {
        Library library;
        private string loggedInAdmin;
        public ReturnBooks(string username)
        {

            InitializeComponent();
            library = new Library();
            this.loggedInAdmin = username;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string memberID = returnMemID_Input.Text;

            if(string.IsNullOrEmpty(memberID))
            {
                MessageBox.Show("Please Enter a Member ID","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!library.CheckMemberExist(memberID))
            {
                MessageBox.Show("Member with entered ID does not exist", "Invalid MemberID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dataGridViewMemLoans.DataSource = null;

                DataTable memberLoansTable = library.LoadMemberLoansIntoTable(memberID);

                if (memberLoansTable.Rows.Count == 0)
                {
                    MessageBox.Show("Member Do not Have Any Book on Loan", "No Current Loans", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridViewMemLoans.DataSource = memberLoansTable;
                }
            }
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
            LibrarianMenu librarianMenu = new LibrarianMenu(loggedInAdmin);
            this.Close();
            librarianMenu.Show();
        }

        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            string bookID = returnBookID_Input.Text;
            if(string.IsNullOrEmpty(bookID) )
            {
                MessageBox.Show("Please Enter a BookID","Empty BookID",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string memberID = returnMemID_Input.Text;

                Loan loan = library.GetMemberLoans(memberID).Find(b=> b.BookID == bookID);

                if(loan == null)
                {
                    MessageBox.Show("Book with Entered ID is not found in Member's Loans", "No Book Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    double overdueCharges = CalculateOverdue(loan.DueDate);

                    library.RemoveLoansFromDatabase(bookID);

                    Book book = library.AvailableBooks.Find(b=>b.BookID == bookID);

                    if(book != null)
                    {
                        book.Availability = "Available";
                        library.UpdateBookStatus(book);
                    }

                    library.UpdateMemberOverdue(memberID, overdueCharges);
                    dataGridViewMemLoans.DataSource = null;
                    dataGridViewMemLoans.DataSource = library.LoadMemberLoansIntoTable(memberID);

                    MessageBox.Show("Book Returned Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                
            }
        }

        private float CalculateOverdue(DateTime dueDate)
        {
            double overdueChargeRate = 10.0;
            TimeSpan overdueDuration = DateTime.Now - dueDate;

            if (overdueDuration.TotalDays > 0)
            {
                return (float)(overdueDuration.TotalDays * overdueChargeRate);
            }

            return 0.0f;
        }

        private void ReturnBookBtn_MouseEnter(object sender, EventArgs e)
        {
            ReturnBookBtn.BackColor = Color.MidnightBlue;
        }

        private void ReturnBookBtn_MouseLeave(object sender, EventArgs e)
        {
            ReturnBookBtn.BackColor = Color.FromArgb(42, 72, 88);
        }

        private void ClearBtn_MouseEnter(object sender, EventArgs e)
        {
            ClearBtn.BackColor = Color.MidnightBlue;
        }

        private void ClearBtn_MouseLeave(object sender, EventArgs e)
        {
            ClearBtn.BackColor = Color.FromArgb(42, 72, 88);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
            dataGridViewMemLoans.DataSource = null;
        }
        private void ClearInputs()
        {
            returnMemID_Input.Clear();
            returnBookID_Input.Clear();
        }

        private void RenewBtn_Click(object sender, EventArgs e)
        {
            string memberID = returnMemID_Input.Text;
            string bookId = returnBookID_Input.Text;
            if(string.IsNullOrEmpty(memberID) || string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Please enter a MemberID and a BookID","Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Loan loan = library.GetMemberLoans(memberID).Find(b=>b.BookID == bookId);
                if (loan == null)
                {
                    MessageBox.Show("Book with Entered ID is not found in Member's Loans", "No Book Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(loan.DueDate < DateTime.Now)
                {
                    MessageBox.Show("Cannot renew an Overdued Book","Renewal Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DateTime newDueDate = loan.DueDate.AddDays(7);
                    library.RenewLoan(loan.LoanID, newDueDate);

                    MessageBox.Show("Book Renewed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridViewMemLoans.DataSource = null;
                    dataGridViewMemLoans.DataSource = library.LoadMemberLoansIntoTable(memberID);

                }
            }
        }
    }
}
