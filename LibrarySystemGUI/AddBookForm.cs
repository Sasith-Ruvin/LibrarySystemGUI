using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemGUI
{
    public partial class AddBookForm : Form
    {
        private string loggedInUser;
        Library library;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public AddBookForm(string username)
        {
            this.loggedInUser = username;
            InitializeComponent();
            library = new Library();
        }

        private void AddBook_Btn_Click(object sender, EventArgs e)
        {
            if(AddBookID_Input.Text =="" || AddBookTitle_Input.Text ==""|| AddBookAuthor_Input.Text == "" || AddBookISBN_Input.Text == "")
            {
                MessageBox.Show("Please Fill in the all Fields","Error Empty Fields",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string bookID = AddBookID_Input.Text;
                string title = AddBookTitle_Input.Text;
                string author = AddBookAuthor_Input.Text;
                long isbn;
                if (!long.TryParse(AddBookISBN_Input.Text, out isbn))
                {
                    MessageBox.Show("Invalid ISBN Please Enter Numerical Values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (library.BookExistance(bookID))
                {
                    MessageBox.Show($"Book with ID: {bookID} already exist in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertQuery = "INSERT INTO Book (BookID, Title, Author, ISBN) VALUES (@BookID, @Title, @Author, @ISBN)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@BookID", bookID);
                            command.Parameters.AddWithValue("@Title", title);
                            command.Parameters.AddWithValue("@Author", author);
                            command.Parameters.AddWithValue("@ISBN", isbn);


                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearInputs();
                            }
                            else
                            {
                                MessageBox.Show("Failed to add the book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
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
            LibrarianMenu librarianMenu = new LibrarianMenu(loggedInUser);
            librarianMenu.Show();
            this.Close();
        }

        private void BookAddClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            AddBookID_Input.Clear();
            AddBookTitle_Input.Clear();
            AddBookAuthor_Input.Clear();
            AddBookISBN_Input.Clear();
        }

        private void AddBook_Btn_MouseEnter(object sender, EventArgs e)
        {
            AddBook_Btn.BackColor = Color.MidnightBlue;
        }

        private void AddBook_Btn_MouseLeave(object sender, EventArgs e)
        {
            AddBook_Btn.BackColor = Color.FromArgb(42, 72, 88);
        }

        private void BookAddClear_MouseEnter(object sender, EventArgs e)
        {
            BookAddClear.BackColor = Color.MidnightBlue;
        }

        private void BookAddClear_MouseLeave(object sender, EventArgs e)
        {
            BookAddClear.BackColor = Color.FromArgb(42, 72, 88);
        }
    }
}
