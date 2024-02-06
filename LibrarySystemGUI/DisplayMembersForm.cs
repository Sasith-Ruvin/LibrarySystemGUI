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
    public partial class DisplayMembersForm : Form
    {
        private string loggedInAdmin;
        Library library;
        public DisplayMembersForm(string username)
        {
            InitializeComponent();
            library = new Library();
            this.loggedInAdmin = username;
        }

        private void DisplayMembersForm_Load(object sender, EventArgs e)
        {
            LoadMembersTable();
            dataGridViewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach(DataGridViewColumn column in dataGridViewMembers.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            

        }
        private void LoadMembersTable()
        {
            dataGridViewMembers.DataSource = library.LoadMemberDetailsFromDatabaseToTable();
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
            librarianMenu.Show();
            this.Close();
        }

        private void dataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object memberID = dataGridViewMembers.Rows[e.RowIndex].Cells["MemberID"].Value;

                removeMemID_Input.Text = memberID?.ToString();
            }
        }

        private void removeMemBtn_Click(object sender, EventArgs e)
        {
            string memberID = removeMemID_Input.Text;

            if (string.IsNullOrEmpty(memberID))
            {
                emptyMemID.Visible = true;
            }
            else if (library.CheckForLoans(memberID))
            {
                MessageBox.Show("Cannot remove member. The member has active loans.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
               
                bool memberRemoved = library.RemoveMembersFromDB(memberID);

                if(memberRemoved)
                {
                    MessageBox.Show($"Member with ID:{memberID} was removed.","Successs",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewMembers.DataSource = null;
                    dataGridViewMembers.DataSource = library.LoadMemberDetailsFromDatabaseToTable();
                    dataGridViewMembers.Refresh();
                    ClearInputs();
                    emptyMemID.Visible = false;
                }
                else
                {
                    MessageBox.Show($"Member with ID:{memberID} was not found. Please Try Again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            
            }
        }

       
        private void ClearInputs()
        {
            emptyMemID.Visible=false;
            removeMemID_Input.Clear();
        }

        private void removeMemBtn_MouseEnter(object sender, EventArgs e)
        {
            removeMemBtn.BackColor = Color.MidnightBlue;
        }

        private void removeMemBtn_MouseLeave(object sender, EventArgs e)
        {
            removeMemBtn.BackColor = Color.FromArgb(42, 72, 88);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearBtn_MouseEnter(object sender, EventArgs e)
        {
            removeMemBtn.BackColor = Color.MidnightBlue;
        }

        private void ClearBtn_MouseLeave(object sender, EventArgs e)
        {
            removeMemBtn.BackColor = Color.FromArgb(42, 72, 88);
        }
    }
}
