namespace Charlie
{
    partial class VisitorRegistrationWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.visitorsOnSiteGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signInButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.visitorDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.meetingDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.meetingWithLabel = new System.Windows.Forms.Label();
            this.meetingAimLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.visitorDetailsGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.meetingDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.visitorsOnSiteGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(882, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(476, 594);
            this.panel1.TabIndex = 0;
            // 
            // visitorsOnSiteGroupBox
            // 
            this.visitorsOnSiteGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitorsOnSiteGroupBox.Location = new System.Drawing.Point(10, 10);
            this.visitorsOnSiteGroupBox.Name = "visitorsOnSiteGroupBox";
            this.visitorsOnSiteGroupBox.Size = new System.Drawing.Size(456, 574);
            this.visitorsOnSiteGroupBox.TabIndex = 0;
            this.visitorsOnSiteGroupBox.TabStop = false;
            this.visitorsOnSiteGroupBox.Text = "Visitors On-Site";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.signInButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 481);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(882, 113);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // signInButton
            // 
            this.signInButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signInButton.Location = new System.Drawing.Point(10, 10);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(862, 93);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.visitorDetailsGroupBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(440, 481);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // visitorDetailsGroupBox
            // 
            this.visitorDetailsGroupBox.Controls.Add(this.emailLabel);
            this.visitorDetailsGroupBox.Controls.Add(this.emailTextBox);
            this.visitorDetailsGroupBox.Controls.Add(this.mobileLabel);
            this.visitorDetailsGroupBox.Controls.Add(this.mobileTextBox);
            this.visitorDetailsGroupBox.Controls.Add(this.surnameLabel);
            this.visitorDetailsGroupBox.Controls.Add(this.surnameTextBox);
            this.visitorDetailsGroupBox.Controls.Add(this.nameLabel);
            this.visitorDetailsGroupBox.Controls.Add(this.nameTextBox);
            this.visitorDetailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitorDetailsGroupBox.Location = new System.Drawing.Point(10, 10);
            this.visitorDetailsGroupBox.Name = "visitorDetailsGroupBox";
            this.visitorDetailsGroupBox.Size = new System.Drawing.Size(420, 461);
            this.visitorDetailsGroupBox.TabIndex = 0;
            this.visitorDetailsGroupBox.TabStop = false;
            this.visitorDetailsGroupBox.Text = "Visitor Details";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 350);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(65, 25);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(6, 378);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(400, 31);
            this.emailTextBox.TabIndex = 6;
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Location = new System.Drawing.Point(6, 250);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(76, 25);
            this.mobileLabel.TabIndex = 5;
            this.mobileLabel.Text = "Mobile";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(6, 278);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(400, 31);
            this.mobileTextBox.TabIndex = 4;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(6, 150);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(98, 25);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Surname";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(6, 178);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(400, 31);
            this.surnameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 78);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(400, 31);
            this.nameTextBox.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.meetingDetailsGroupBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(440, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(442, 481);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // meetingDetailsGroupBox
            // 
            this.meetingDetailsGroupBox.Controls.Add(this.dateTimePicker1);
            this.meetingDetailsGroupBox.Controls.Add(this.meetingAimLabel);
            this.meetingDetailsGroupBox.Controls.Add(this.meetingWithLabel);
            this.meetingDetailsGroupBox.Controls.Add(this.timeLabel);
            this.meetingDetailsGroupBox.Controls.Add(this.dateLabel);
            this.meetingDetailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meetingDetailsGroupBox.Location = new System.Drawing.Point(10, 10);
            this.meetingDetailsGroupBox.Name = "meetingDetailsGroupBox";
            this.meetingDetailsGroupBox.Size = new System.Drawing.Size(422, 461);
            this.meetingDetailsGroupBox.TabIndex = 0;
            this.meetingDetailsGroupBox.TabStop = false;
            this.meetingDetailsGroupBox.Text = "Meeting Details";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(6, 50);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(57, 25);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(3, 150);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 25);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time";
            // 
            // meetingWithLabel
            // 
            this.meetingWithLabel.AutoSize = true;
            this.meetingWithLabel.Location = new System.Drawing.Point(6, 250);
            this.meetingWithLabel.Name = "meetingWithLabel";
            this.meetingWithLabel.Size = new System.Drawing.Size(138, 25);
            this.meetingWithLabel.TabIndex = 4;
            this.meetingWithLabel.Text = "Meeting With";
            // 
            // meetingAimLabel
            // 
            this.meetingAimLabel.AutoSize = true;
            this.meetingAimLabel.Location = new System.Drawing.Point(6, 350);
            this.meetingAimLabel.Name = "meetingAimLabel";
            this.meetingAimLabel.Size = new System.Drawing.Size(131, 25);
            this.meetingAimLabel.TabIndex = 5;
            this.meetingAimLabel.Text = "Meeting Aim";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 31);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // VisitorRegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 594);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VisitorRegistrationWindow";
            this.Text = "Visitor Registration";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.visitorDetailsGroupBox.ResumeLayout(false);
            this.visitorDetailsGroupBox.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.meetingDetailsGroupBox.ResumeLayout(false);
            this.meetingDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.GroupBox visitorsOnSiteGroupBox;
        private System.Windows.Forms.GroupBox visitorDetailsGroupBox;
        private System.Windows.Forms.GroupBox meetingDetailsGroupBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label meetingWithLabel;
        private System.Windows.Forms.Label meetingAimLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

