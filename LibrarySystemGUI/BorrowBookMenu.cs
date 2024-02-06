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
    public partial class BorrowBookMenu : Form
    {

        private string loggedInUser;
        Library library;
        public BorrowBookMenu(string username)
        {
            InitializeComponent();
            this.loggedInUser = username;
            library = new Library();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {

            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MemberMenu memberMenu = new MemberMenu(loggedInUser);
            this.Close();
            memberMenu.Show();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            borrowBookID_Input.Clear();
        }

        private void BorrowBookBtn_Click(object sender, EventArgs e)
        {
            string bookID = borrowBookID_Input.Text;
            if (string.IsNullOrEmpty(bookID))
            {
                MessageBox.Show("Please Enter a BookID to borrow a Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Book selectedBook = library.AvailableBooks.Find(b=> b.BookID == bookID);
                if(selectedBook == null)
                {
                    MessageBox.Show("Book with entered ID does not exits. Please try again","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if( selectedBook.Availability == "On Loan")
                {
                    MessageBox.Show("Book is Already On Loan, Please choose another Book","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Member loggedInMember = library.Members.Find(m => m.GetCredentials() == loggedInUser);

                    string loanID = library.GenerateLoanID();
                    DateTime issueDate = DateTime.Now;
                    DateTime dueDate = DateTime.Now.AddDays(14);




                    Loan newloan = new Loan(loanID, loggedInMember.MemberID, loggedInMember.FirstName, selectedBook.BookID, selectedBook.Title, issueDate, dueDate);
                    selectedBook.Availability = "On Loan";
                    library.AddLoanToDatabase(newloan);
                    library.UpdateBookStatus(selectedBook);
                    library.AvailableBooks = library.LoadBooksFromDatabase();


                    MessageBox.Show("Book borrowed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    library.Loans.Add(newloan);
                    dataGridViewBorrwoBook.DataSource = null;
                    dataGridViewBorrwoBook.DataSource = library.LoadBooksFromDatabaseToTable();
                    dataGridViewBorrwoBook.Refresh();

                }

            }

        }

        private void LoadBooksToTable()
        {
            dataGridViewBorrwoBook.DataSource = library.LoadBooksFromDatabaseToTable();
        }

        private void BorrowBookMenu_Load(object sender, EventArgs e)
        {
            LoadBooksToTable();
        }

        private void dataGridViewBorrwoBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object bookID = dataGridViewBorrwoBook.Rows[e.RowIndex].Cells["BookID"].Value;

                borrowBookID_Input.Text = bookID?.ToString();
            }
        }

        

        private void BorrowBookBtn_MouseEnter(object sender, EventArgs e)
        {
            BorrowBookBtn.BackColor = Color.MidnightBlue;
        }

        private void BorrowBookBtn_MouseLeave(object sender, EventArgs e)
        {
            BorrowBookBtn.BackColor = Color.FromArgb(42, 72, 88);
        }

        private void ClearBtn_MouseEnter(object sender, EventArgs e)
        {
            ClearBtn.BackColor = Color.MidnightBlue;
        }

        private void ClearBtn_MouseLeave(object sender, EventArgs e)
        {
            ClearBtn.BackColor = Color.FromArgb(42, 72, 88);
        }

        private void titleInput_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = titleInput.Text;
            var searchResults = library.AvailableBooks.Where(book=>
                                                         book.Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                         book.Author.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                         book.BookID.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            dataGridViewBorrwoBook.DataSource = null;
            if(searchResults.Count > 0 )
            {
                dataGridViewBorrwoBook.DataSource = searchResults;
                dataGridViewBorrwoBook.Refresh();
            }

        }
    }
}
