namespace Charlie
{
    partial class MeetingAimForm
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
            this.meetingSpecifyLabel = new System.Windows.Forms.Label();
            this.meetingRadioButton = new System.Windows.Forms.RadioButton();
            this.salesAppointmentRadioButton = new System.Windows.Forms.RadioButton();
            this.siteVisitRadioButton = new System.Windows.Forms.RadioButton();
            this.studentInterviewRadioButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meetingSpecifyLabel
            // 
            this.meetingSpecifyLabel.AutoSize = true;
            this.meetingSpecifyLabel.Location = new System.Drawing.Point(12, 9);
            this.meetingSpecifyLabel.Name = "meetingSpecifyLabel";
            this.meetingSpecifyLabel.Size = new System.Drawing.Size(403, 25);
            this.meetingSpecifyLabel.TabIndex = 0;
            this.meetingSpecifyLabel.Text = "Please specify the nature of the meeting:";
            // 
            // meetingRadioButton
            // 
            this.meetingRadioButton.AutoSize = true;
            this.meetingRadioButton.Location = new System.Drawing.Point(60, 60);
            this.meetingRadioButton.Name = "meetingRadioButton";
            this.meetingRadioButton.Size = new System.Drawing.Size(120, 29);
            this.meetingRadioButton.TabIndex = 1;
            this.meetingRadioButton.TabStop = true;
            this.meetingRadioButton.Text = "Meeting";
            this.meetingRadioButton.UseVisualStyleBackColor = true;
            // 
            // salesAppointmentRadioButton
            // 
            this.salesAppointmentRadioButton.AutoSize = true;
            this.salesAppointmentRadioButton.Location = new System.Drawing.Point(300, 60);
            this.salesAppointmentRadioButton.Name = "salesAppointmentRadioButton";
            this.salesAppointmentRadioButton.Size = new System.Drawing.Size(223, 29);
            this.salesAppointmentRadioButton.TabIndex = 2;
            this.salesAppointmentRadioButton.TabStop = true;
            this.salesAppointmentRadioButton.Text = "Sales Appointment";
            this.salesAppointmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // siteVisitRadioButton
            // 
            this.siteVisitRadioButton.AutoSize = true;
            this.siteVisitRadioButton.Location = new System.Drawing.Point(60, 200);
            this.siteVisitRadioButton.Name = "siteVisitRadioButton";
            this.siteVisitRadioButton.Size = new System.Drawing.Size(127, 29);
            this.siteVisitRadioButton.TabIndex = 3;
            this.siteVisitRadioButton.TabStop = true;
            this.siteVisitRadioButton.Text = "Site Visit";
            this.siteVisitRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentInterviewRadioButton
            // 
            this.studentInterviewRadioButton.AutoSize = true;
            this.studentInterviewRadioButton.Location = new System.Drawing.Point(300, 200);
            this.studentInterviewRadioButton.Name = "studentInterviewRadioButton";
            this.studentInterviewRadioButton.Size = new System.Drawing.Size(208, 29);
            this.studentInterviewRadioButton.TabIndex = 4;
            this.studentInterviewRadioButton.TabStop = true;
            this.studentInterviewRadioButton.Text = "Student Interview";
            this.studentInterviewRadioButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(17, 277);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(200, 40);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(300, 277);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 40);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MeetingAimForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(574, 329);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.studentInterviewRadioButton);
            this.Controls.Add(this.siteVisitRadioButton);
            this.Controls.Add(this.salesAppointmentRadioButton);
            this.Controls.Add(this.meetingRadioButton);
            this.Controls.Add(this.meetingSpecifyLabel);
            this.Name = "MeetingAimForm";
            this.Text = "Aim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label meetingSpecifyLabel;
        private System.Windows.Forms.RadioButton meetingRadioButton;
        private System.Windows.Forms.RadioButton salesAppointmentRadioButton;
        private System.Windows.Forms.RadioButton siteVisitRadioButton;
        private System.Windows.Forms.RadioButton studentInterviewRadioButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}