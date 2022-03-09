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
        public String Aim = "";

        public MeetingAimForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (meetingRadioButton.Checked) Aim = "Meeting";
            else if (salesAppointmentRadioButton.Checked) Aim = "Sales Appointment";
            else if (siteVisitRadioButton.Checked) Aim = "Site Visit";
            else if (studentInterviewRadioButton.Checked) Aim = "Student Interview";
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
