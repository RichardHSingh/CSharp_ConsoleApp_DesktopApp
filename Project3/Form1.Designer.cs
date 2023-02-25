namespace Project3
{
    partial class Form1
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
            this.visitorsFirstName = new System.Windows.Forms.Label();
            this.visitorsEmailAddressTB = new System.Windows.Forms.TextBox();
            this.visitorsMobileTB = new System.Windows.Forms.TextBox();
            this.visitorsLastNameTB = new System.Windows.Forms.TextBox();
            this.visitorsEmailAddress = new System.Windows.Forms.Label();
            this.visitorsMobile = new System.Windows.Forms.Label();
            this.visitorsLastName = new System.Windows.Forms.Label();
            this.visitorsFirstNameTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.meetingWithCB = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnMeetingAim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.visitorTimeMinutes = new System.Windows.Forms.DomainUpDown();
            this.visitorTimeHour = new System.Windows.Forms.DomainUpDown();
            this.visitorAppDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.visitorsOnSiteLB = new System.Windows.Forms.ListBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visitorsFirstName);
            this.groupBox1.Controls.Add(this.visitorsEmailAddressTB);
            this.groupBox1.Controls.Add(this.visitorsMobileTB);
            this.groupBox1.Controls.Add(this.visitorsLastNameTB);
            this.groupBox1.Controls.Add(this.visitorsEmailAddress);
            this.groupBox1.Controls.Add(this.visitorsMobile);
            this.groupBox1.Controls.Add(this.visitorsLastName);
            this.groupBox1.Controls.Add(this.visitorsFirstNameTB);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor Details";
            // 
            // visitorsFirstName
            // 
            this.visitorsFirstName.AutoSize = true;
            this.visitorsFirstName.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsFirstName.Location = new System.Drawing.Point(6, 36);
            this.visitorsFirstName.Name = "visitorsFirstName";
            this.visitorsFirstName.Size = new System.Drawing.Size(78, 15);
            this.visitorsFirstName.TabIndex = 7;
            this.visitorsFirstName.Text = "First Name:";
            // 
            // visitorsEmailAddressTB
            // 
            this.visitorsEmailAddressTB.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsEmailAddressTB.Location = new System.Drawing.Point(9, 299);
            this.visitorsEmailAddressTB.Name = "visitorsEmailAddressTB";
            this.visitorsEmailAddressTB.Size = new System.Drawing.Size(201, 23);
            this.visitorsEmailAddressTB.TabIndex = 6;
            this.visitorsEmailAddressTB.TextChanged += new System.EventHandler(this.visitorsEmailAddressTB_TextChanged);
            // 
            // visitorsMobileTB
            // 
            this.visitorsMobileTB.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsMobileTB.Location = new System.Drawing.Point(9, 217);
            this.visitorsMobileTB.Name = "visitorsMobileTB";
            this.visitorsMobileTB.Size = new System.Drawing.Size(201, 23);
            this.visitorsMobileTB.TabIndex = 5;
            this.visitorsMobileTB.TextChanged += new System.EventHandler(this.visitorsMobileTB_TextChanged);
            // 
            // visitorsLastNameTB
            // 
            this.visitorsLastNameTB.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsLastNameTB.Location = new System.Drawing.Point(9, 133);
            this.visitorsLastNameTB.Name = "visitorsLastNameTB";
            this.visitorsLastNameTB.Size = new System.Drawing.Size(201, 23);
            this.visitorsLastNameTB.TabIndex = 2;
            this.visitorsLastNameTB.TextChanged += new System.EventHandler(this.visitorsLastNameTB_TextChanged);
            // 
            // visitorsEmailAddress
            // 
            this.visitorsEmailAddress.AutoSize = true;
            this.visitorsEmailAddress.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsEmailAddress.Location = new System.Drawing.Point(6, 281);
            this.visitorsEmailAddress.Name = "visitorsEmailAddress";
            this.visitorsEmailAddress.Size = new System.Drawing.Size(99, 15);
            this.visitorsEmailAddress.TabIndex = 4;
            this.visitorsEmailAddress.Text = "Email Address:";
            // 
            // visitorsMobile
            // 
            this.visitorsMobile.AutoSize = true;
            this.visitorsMobile.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsMobile.Location = new System.Drawing.Point(6, 199);
            this.visitorsMobile.Name = "visitorsMobile";
            this.visitorsMobile.Size = new System.Drawing.Size(54, 15);
            this.visitorsMobile.TabIndex = 3;
            this.visitorsMobile.Text = "Mobile:";
            // 
            // visitorsLastName
            // 
            this.visitorsLastName.AutoSize = true;
            this.visitorsLastName.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsLastName.Location = new System.Drawing.Point(6, 116);
            this.visitorsLastName.Name = "visitorsLastName";
            this.visitorsLastName.Size = new System.Drawing.Size(76, 15);
            this.visitorsLastName.TabIndex = 2;
            this.visitorsLastName.Text = "Last Name:";
            // 
            // visitorsFirstNameTB
            // 
            this.visitorsFirstNameTB.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsFirstNameTB.Location = new System.Drawing.Point(9, 54);
            this.visitorsFirstNameTB.Name = "visitorsFirstNameTB";
            this.visitorsFirstNameTB.Size = new System.Drawing.Size(201, 23);
            this.visitorsFirstNameTB.TabIndex = 1;
            this.visitorsFirstNameTB.TextChanged += new System.EventHandler(this.visitorsFirstNameTB_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.meetingWithCB);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.btnMeetingAim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.visitorTimeMinutes);
            this.groupBox2.Controls.Add(this.visitorTimeHour);
            this.groupBox2.Controls.Add(this.visitorAppDate);
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(241, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 342);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meeting Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Time:";
            // 
            // meetingWithCB
            // 
            this.meetingWithCB.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingWithCB.FormattingEnabled = true;
            this.meetingWithCB.Items.AddRange(new object[] {
            " Michael Angelo",
            " Leo Nardo",
            " Dona Tello",
            " Raph Aiel"});
            this.meetingWithCB.Location = new System.Drawing.Point(9, 214);
            this.meetingWithCB.Name = "meetingWithCB";
            this.meetingWithCB.Size = new System.Drawing.Size(198, 26);
            this.meetingWithCB.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 27);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnMeetingAim
            // 
            this.btnMeetingAim.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMeetingAim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeetingAim.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeetingAim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMeetingAim.Location = new System.Drawing.Point(9, 299);
            this.btnMeetingAim.Name = "btnMeetingAim";
            this.btnMeetingAim.Size = new System.Drawing.Size(201, 23);
            this.btnMeetingAim.TabIndex = 15;
            this.btnMeetingAim.Text = "Meeting Aim";
            this.btnMeetingAim.UseVisualStyleBackColor = false;
            this.btnMeetingAim.Click += new System.EventHandler(this.btnMeetingAim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Meeting Aim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Meeting With:";
            // 
            // visitorTimeMinutes
            // 
            this.visitorTimeMinutes.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorTimeMinutes.Location = new System.Drawing.Point(115, 133);
            this.visitorTimeMinutes.Name = "visitorTimeMinutes";
            this.visitorTimeMinutes.Size = new System.Drawing.Size(97, 23);
            this.visitorTimeMinutes.TabIndex = 11;
            this.visitorTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.visitorTimeMinutes.SelectedItemChanged += new System.EventHandler(this.visitorTimeMinutes_SelectedItemChanged);
            // 
            // visitorTimeHour
            // 
            this.visitorTimeHour.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorTimeHour.Location = new System.Drawing.Point(9, 133);
            this.visitorTimeHour.Name = "visitorTimeHour";
            this.visitorTimeHour.Size = new System.Drawing.Size(97, 23);
            this.visitorTimeHour.TabIndex = 10;
            this.visitorTimeHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.visitorTimeHour.SelectedItemChanged += new System.EventHandler(this.visitorTimeHour_SelectedItemChanged);
            // 
            // visitorAppDate
            // 
            this.visitorAppDate.AutoSize = true;
            this.visitorAppDate.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorAppDate.Location = new System.Drawing.Point(8, 36);
            this.visitorAppDate.Name = "visitorAppDate";
            this.visitorAppDate.Size = new System.Drawing.Size(40, 15);
            this.visitorAppDate.TabIndex = 7;
            this.visitorAppDate.Text = "Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.visitorsOnSiteLB);
            this.groupBox3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(475, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 413);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visitors On-Site";
            // 
            // visitorsOnSiteLB
            // 
            this.visitorsOnSiteLB.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsOnSiteLB.FormattingEnabled = true;
            this.visitorsOnSiteLB.ItemHeight = 15;
            this.visitorsOnSiteLB.Location = new System.Drawing.Point(15, 29);
            this.visitorsOnSiteLB.Name = "visitorsOnSiteLB";
            this.visitorsOnSiteLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.visitorsOnSiteLB.Size = new System.Drawing.Size(257, 364);
            this.visitorsOnSiteLB.TabIndex = 0;
            this.visitorsOnSiteLB.SelectedIndexChanged += new System.EventHandler(this.visitorsOnSiteLB_SelectedIndexChanged);
            this.visitorsOnSiteLB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deleteLB);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignIn.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSignIn.Location = new System.Drawing.Point(12, 383);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(457, 42);
            this.btnSignIn.TabIndex = 16;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(768, 430);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Visitor Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox visitorsEmailAddressTB;
        private System.Windows.Forms.TextBox visitorsMobileTB;
        private System.Windows.Forms.TextBox visitorsLastNameTB;
        private System.Windows.Forms.Label visitorsEmailAddress;
        private System.Windows.Forms.Label visitorsMobile;
        private System.Windows.Forms.Label visitorsLastName;
        private System.Windows.Forms.TextBox visitorsFirstNameTB;
        private System.Windows.Forms.ListBox visitorsOnSiteLB;
        private System.Windows.Forms.Label visitorAppDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label visitorsFirstName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DomainUpDown visitorTimeMinutes;
        private System.Windows.Forms.DomainUpDown visitorTimeHour;
        private System.Windows.Forms.ComboBox meetingWithCB;
        public System.Windows.Forms.Button btnMeetingAim;
        private System.Windows.Forms.Label label1;
    }
}

