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
    public partial class RemoveBook : Form
    {
        Library library;
        private string loggedInUser;
        public RemoveBook(string username)
        {
            this.loggedInUser = username;
            InitializeComponent();
            this.library = new Library();
        }


        private void LoadBooksTable()
        {
            library.LoadBooksFromDatabase();
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach(DataGridViewColumn column in dataGridViewBooks.Columns )
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void RemoveBook_Load(object sender, EventArgs e)
        {
            dataGridViewBooks.DataBindingComplete += dataGridViewBooks_DataBindingComplete;
            dataGridViewBooks.DataSource = library.AvailableBooks;
           
        }

        private void BookMinBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void BookBackBtn_Click(object sender, EventArgs e)
        {
            LibrarianMenu librarianMenu = new LibrarianMenu(loggedInUser);
            this.Close();
            librarianMenu.Show();
        }

        private void BookCloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);

        }

        private void RemoveBookBtn_Click(object sender, EventArgs e)
        {

            string bookIDToRemove = removeBookID_Input.Text;
            if (string.IsNullOrEmpty(bookIDToRemove))
            {
                MessageBox.Show("Please Enter a BookID to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                bool isBookOnLoan = library.IsBookOnLoan(bookIDToRemove);
                if (isBookOnLoan)
                {
                    MessageBox.Show("You cannot remove a book that is On Loan","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool isBookExist = library.BookExistance(bookIDToRemove);
                    if (!isBookExist)
                    {
                        MessageBox.Show("Book with entered ID does not exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        bool bookRemoved = library.RemoveBookfromDatabasae(bookIDToRemove);

                        if (bookRemoved)
                        {
                            MessageBox.Show("Book was removed from Database Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridViewBooks.DataSource = null;
                            dataGridViewBooks.DataSource = library.LoadBooksFromDatabaseToTable();
                            dataGridViewBooks.Refresh();
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("Book with Entered ID Does not Exist in Database", "Error Invalid BookID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearInputs();
                        }

                    }
                }
            }           
        }

        private void ClearInputs()
        {
            removeBookID_Input.Clear();
            emptyInput.Visible = false;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
            
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >0 && e.ColumnIndex > 0)
            {
                object removeBookID = dataGridViewBooks.Rows[e.RowIndex].Cells["BookID"].Value;

                removeBookID_Input.Text = removeBookID?.ToString();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string serachInput = titleInput.Text;
            if (string.IsNullOrEmpty(serachInput))
            {
                emptyInput.Visible = true;
            }
            else
            {
                var searchResults = library.AvailableBooks.Where(book => book.Title.IndexOf(serachInput, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                dataGridViewBooks.DataSource = null;
                if (searchResults.Count > 0)
                {
                    dataGridViewBooks.DataSource = searchResults;
                    dataGridViewBooks.Refresh();

                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }
        private void ReloadForm()
        {
            ClearInputs();
            LoadBooksTable();
            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.Update();
            dataGridViewBooks.DataSource = library.LoadBooksFromDatabaseToTable();
            dataGridViewBooks.Refresh();
        }
        private void AdjustColumnwidth()
        {
            dataGridViewBooks.Columns["BookID"].Width = 100;
            dataGridViewBooks.Columns["Title"].Width = 200;
            dataGridViewBooks.Columns["Author"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataGridViewBooks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AdjustColumnwidth();
        }

        private void RemoveBookBtn_MouseEnter(object sender, EventArgs e)
        {
            RemoveBookBtn.BackColor = Color.MidnightBlue;
        }

        private void RemoveBookBtn_MouseLeave(object sender, EventArgs e)
        {
            RemoveBookBtn.BackColor = Color.FromArgb(42, 72, 88);
        }

        private void ClearBtn_MouseEnter(object sender, EventArgs e)
        {
            ClearBtn.BackColor = Color.MidnightBlue;
        }

        private void ClearBtn_MouseLeave(object sender, EventArgs e)
        {
            ClearBtn.BackColor = Color.FromArgb(42, 72, 88);
        }
    }
}
