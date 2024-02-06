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
    public partial class OverduePayment : Form
    {
        Library library;
        private string loggedInAdmin;
        public OverduePayment(string username)
        {
            InitializeComponent();
            this.library = new Library();
            this.loggedInAdmin = username;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string memberID = memberID_Input.Text;
            if (string.IsNullOrEmpty(memberID))
            {
                emptyinput.Visible = true;
                return;
            }
            else if (!library.CheckMemberExist(memberID))
            {
                MessageBox.Show($"Member with ID: {memberID} does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                double overdue = library.GetMemberIDOverdue(memberID);
                if(overdue == 0)
                {
                    MessageBox.Show("Member does not have any Overdues","No Overdues",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MemberOverdue.Text = overdue.ToString();
                }
                
            }

        }

        private void paybutton_Click(object sender, EventArgs e)
        {
            string memberID = memberID_Input.Text;
            double payment;
            if (double.TryParse(Payment.Text, out payment))
            {
                if (payment >= 0)
                {
                    library.ReduceMemberOverdue(memberID, payment);
                    MessageBox.Show($"Payment of {payment} successful. Overdue amount updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    emptyinput.Visible =false;
                }
                else
                {
                    MessageBox.Show("Payment amount should be a positive number.", "Negative Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid payment amount. Please enter a valid number.", "Non Integer Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void MemLoginClearBtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            memberID_Input.Clear();
            MemberOverdue.Clear();
            Payment.Clear();
        }

        private void paybutton_MouseEnter(object sender, EventArgs e)
        {
            paybutton.BackColor = Color.MidnightBlue;
        }

        private void paybutton_MouseLeave(object sender, EventArgs e)
        {
            paybutton.BackColor = Color.FromArgb(42, 72, 88);
        }

       

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
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
