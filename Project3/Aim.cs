using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Project3
{
    public partial class Aim : Form
    {
            
        

    
        public Aim()
        {
            InitializeComponent();
        }

        private void meetingAimMeeting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (meetingAimMeeting.Checked)
            {
                Form1.Aim.btnMeetingAim.Text = meetingAimMeeting.Text;
            }  
            else if (meetingAimSalesApp.Checked)
            {
                Form1.Aim.btnMeetingAim.Text = meetingAimSalesApp.Text;
            }
            else if (meetingAimSiteVisit.Checked)
            {
                Form1.Aim.btnMeetingAim.Text = meetingAimSiteVisit.Text;
            }
            else if (meetingAimStudentInterview.Checked)
            {
                Form1.Aim.btnMeetingAim.Text = meetingAimStudentInterview.Text;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Aim_Load(object sender, EventArgs e)
        {

        }
    }
}
