namespace Project3
{
    partial class Aim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.meetingAimStudentInterview = new System.Windows.Forms.RadioButton();
            this.meetingAimSiteVisit = new System.Windows.Forms.RadioButton();
            this.meetingAimSalesApp = new System.Windows.Forms.RadioButton();
            this.meetingAimMeeting = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.meetingAimStudentInterview);
            this.groupBox1.Controls.Add(this.meetingAimSiteVisit);
            this.groupBox1.Controls.Add(this.meetingAimSalesApp);
            this.groupBox1.Controls.Add(this.meetingAimMeeting);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please specify the nature of the meeting";
            // 
            // meetingAimStudentInterview
            // 
            this.meetingAimStudentInterview.AutoSize = true;
            this.meetingAimStudentInterview.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingAimStudentInterview.Location = new System.Drawing.Point(187, 104);
            this.meetingAimStudentInterview.Name = "meetingAimStudentInterview";
            this.meetingAimStudentInterview.Size = new System.Drawing.Size(143, 22);
            this.meetingAimStudentInterview.TabIndex = 3;
            this.meetingAimStudentInterview.Text = "Student Interview";
            this.meetingAimStudentInterview.UseVisualStyleBackColor = true;
            // 
            // meetingAimSiteVisit
            // 
            this.meetingAimSiteVisit.AutoSize = true;
            this.meetingAimSiteVisit.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingAimSiteVisit.Location = new System.Drawing.Point(22, 104);
            this.meetingAimSiteVisit.Name = "meetingAimSiteVisit";
            this.meetingAimSiteVisit.Size = new System.Drawing.Size(83, 22);
            this.meetingAimSiteVisit.TabIndex = 2;
            this.meetingAimSiteVisit.Text = "Site Visit";
            this.meetingAimSiteVisit.UseVisualStyleBackColor = true;
            // 
            // meetingAimSalesApp
            // 
            this.meetingAimSalesApp.AutoSize = true;
            this.meetingAimSalesApp.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingAimSalesApp.Location = new System.Drawing.Point(187, 51);
            this.meetingAimSalesApp.Name = "meetingAimSalesApp";
            this.meetingAimSalesApp.Size = new System.Drawing.Size(148, 22);
            this.meetingAimSalesApp.TabIndex = 1;
            this.meetingAimSalesApp.Text = "Sales Appointment";
            this.meetingAimSalesApp.UseVisualStyleBackColor = true;
            // 
            // meetingAimMeeting
            // 
            this.meetingAimMeeting.AutoSize = true;
            this.meetingAimMeeting.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingAimMeeting.Location = new System.Drawing.Point(22, 51);
            this.meetingAimMeeting.Name = "meetingAimMeeting";
            this.meetingAimMeeting.Size = new System.Drawing.Size(80, 22);
            this.meetingAimMeeting.TabIndex = 0;
            this.meetingAimMeeting.Text = "Meeting";
            this.meetingAimMeeting.UseVisualStyleBackColor = true;
            this.meetingAimMeeting.CheckedChanged += new System.EventHandler(this.meetingAimMeeting_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOK.Location = new System.Drawing.Point(206, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 26);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(314, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 26);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Aim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(427, 234);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "Aim";
            this.Text = "Aim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.RadioButton meetingAimStudentInterview;
        public System.Windows.Forms.RadioButton meetingAimSiteVisit;
        public System.Windows.Forms.RadioButton meetingAimSalesApp;
        public System.Windows.Forms.RadioButton meetingAimMeeting;
    }
}