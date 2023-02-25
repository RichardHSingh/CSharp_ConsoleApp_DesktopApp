using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project3
{
    public partial class Form1 : Form
    {

        public static Form1 Aim;
        
        
        public Form1()
        {
            InitializeComponent();
            Aim = this;

        }

        
        private void visitorsFirstNameTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void visitorsLastNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void visitorsMobileTB_TextChanged(object sender, EventArgs e)
        {
            string visitorsMobileNumber = visitorsMobileTB.Text;

            // Validation for mobile number
            if (string.IsNullOrEmpty(visitorsMobileNumber))
            {
                MessageBox.Show("Please enter your mobile number.");
            }
            else if (!Regex.IsMatch(visitorsMobileTB.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Mobile number can only contain digits.");
            }
            else if (visitorsMobileNumber.Length < 10 || visitorsMobileNumber.Length > 12)
            {
                MessageBox.Show("Mobile number should be 10 to 12 digits long.");
            }
            else
            {
                int visitorsMobile = Convert.ToInt32(visitorsMobileNumber);
            }

        }

        private void visitorsEmailAddressTB_TextChanged(object sender, EventArgs e)
        {
            string visitorsEmailAddress = visitorsEmailAddressTB.Text;

            // Validation for email address
            if (string.IsNullOrEmpty(visitorsEmailAddress))
            {
                MessageBox.Show("Please enter your email address.");
            }
            else if (!Regex.IsMatch(visitorsEmailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Please enter a valid email address.");
            }
            else
            {
                
            }
        }

        private void meetingWithCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMeetingAim_Click(object sender, EventArgs e)
        {
            //clicking on button to show 2nd form created
            //new Aim().Show(); = backup coding incase bottom one doesnt work

        //show acts as a hyperlink - cant take you else where when needed 
        //showdialog means it keeps you within the same program and allows all info gathered that is required

            Aim form2 = new Aim();
            form2.ShowDialog();


            //make sure to have radiochecks on form 2 on public under Designer tab - modifiers
            if(form2.meetingAimMeeting.Checked == true)
            {
                btnMeetingAim.Text = form2.meetingAimMeeting.Text;
            }
            else if(form2.meetingAimSalesApp.Checked == true)
            {
                btnMeetingAim.Text = form2.meetingAimSalesApp.Text;
            }
            else if(form2.meetingAimSiteVisit.Checked == true)
            {
                btnMeetingAim.Text = form2.meetingAimSiteVisit.Text;
            }
            else if(form2.meetingAimStudentInterview.Checked == true)
            {
                btnMeetingAim.Text = form2.meetingAimStudentInterview.Text;
            }
            else
            {
                btnMeetingAim.Text = "Meeting Aim";
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //checks through all feild have been entered before signing in
            if (visitorsFirstNameTB.Text == "")
            {
                visitorsFirstNameTB.Focus();
                MessageBox.Show("Required Field! Please enter your first name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (visitorsLastNameTB.Text == "")
            {
                visitorsLastNameTB.Focus();
                MessageBox.Show("Required Field! Please enter your last name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (visitorsMobileTB.Text == "")
            {
                visitorsMobileTB.Focus();
                MessageBox.Show("Required Field! Please enter your mobile number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (visitorsEmailAddressTB.Text == "")
            {
                visitorsEmailAddressTB.Focus();
                MessageBox.Show("Required Field! Please enter your email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePicker1 == null)
            {
                dateTimePicker1.Focus();
                MessageBox.Show("Required Field! Please choose date of appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (visitorTimeHour == null)
            {
                visitorTimeHour.Focus();
                MessageBox.Show("Required Field! Please choose time of appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (visitorTimeMinutes == null)
            {
                visitorTimeMinutes.Focus();
                MessageBox.Show("Required Field! Please choose time of appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (meetingWithCB == null)
            {
                meetingWithCB.Focus();
                MessageBox.Show("Required Field! Please select who you are meeting with!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (btnMeetingAim == null)
            {
                btnMeetingAim.Focus();
                MessageBox.Show("Required Field! Please choose the purpose of your meeting!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //visitorsOnSiteLB.Items.Add("Meeting ID " + meetingIDstring.Text);
                visitorsOnSiteLB.Items.Add("Visitors Name: " + visitorsFirstNameTB.Text + " " + visitorsLastNameTB.Text);
                visitorsOnSiteLB.Items.Add("Visitor Meeting at: " + visitorTimeHour.Text +  "." + visitorTimeMinutes.Text);
                visitorsOnSiteLB.Items.Add("Visitor Meeting with: " + meetingWithCB.Text);
                visitorsOnSiteLB.Items.Add("Visitors Agenda: " + btnMeetingAim.Text);
                visitorsOnSiteLB.Items.Add("========================");
            }

            clearFields();

            
        }

        private void clearFields()
        {
            //clearing the field
            visitorsFirstNameTB.Text = "";
            visitorsLastNameTB.Text = "";
            visitorsMobileTB.Text = "";
            visitorsEmailAddressTB.Text = "";
            visitorTimeHour.Text = "";
            visitorTimeMinutes.Text = "";
            meetingWithCB.SelectedIndex = -1;
            btnMeetingAim.Text = "Meeting Aim";
        }

        private void visitorsOnSiteLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void deleteLB(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (visitorsOnSiteLB.SelectedItem != null)
                {
                    visitorsOnSiteLB.Items.Remove(visitorsOnSiteLB.SelectedItem);
                }
            }
        }

        private void visitorTimeHour_SelectedItemChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                visitorTimeHour.Items.Add(i.ToString("00"));
            }
            visitorTimeHour.Wrap = true;

            
        }

        private void visitorTimeMinutes_SelectedItemChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 59; i++)
            {
                visitorTimeMinutes.Items.Add(i.ToString("00"));
            }
            visitorTimeMinutes.Wrap = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
