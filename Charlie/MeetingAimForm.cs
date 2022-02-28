using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charlie
{
    public partial class MeetingAimForm : Form
    {
        public MeetingAimForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string aim = "";
            if (meetingRadioButton.Checked) aim = "Meeting";
            else if (salesAppointmentRadioButton.Checked) aim = "Sales Appointment";
            else if (siteVisitRadioButton.Checked) aim = "Site Visit";
            else if (studentInterviewRadioButton.Checked) aim = "Student Interview";
            ParentForm.Aim = aim;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
