using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemGUI
{
    public partial class DisplayBooks : Form
    {
        Library library;
        public DisplayBooks()
        {
            InitializeComponent();
            library = new Library();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayBooks_Load(object sender, EventArgs e)
        {
           dataGridViewBooks.DataSource = library.AvailableBooks;
            LoadBooksTable();

        }

        private void LoadBooksTable()
        {
            library.LoadBooksFromDatabase();
        }

        private void BookCloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void BookMinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           

        }

        private void dataGridViewBooks_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           
        }

        private void BookBackBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<MemberMenu>().Any())
            {
                MemberMenu memberMenu = new MemberMenu();
                memberMenu.Show();
                this.Hide();
            }
            else if (Application.OpenForms.OfType<LibrarianMenu>().Any())
            {
                LibrarianMenu librarianMenu = new LibrarianMenu();
                librarianMenu.Show();
                this.Close();
            }
            else
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            }
            
        }
    }
}
