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
    public partial class VisitorRegistrationForm : Form
    {
        public string Aim
        {
            set
            {
                meetingAimButton.Text = value;
            }
        }

        public VisitorRegistrationForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void meetingAimButton_Click(object sender, EventArgs e)
        {
            // Open the meeting aim window
            MeetingAimForm form = new MeetingAimForm();
            form.ParentForm = this;
            form.Show();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            // Check that the user has entered valid data.
            if (nameTextBox.Text == "" || surnameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a name and surname.");
                return;
            }
            if (mobileTextBox.Text == "")
            {
                MessageBox.Show("Please enter a mobile number.");
                return;
            }
            if (emailTextBox.Text == "")
            {
                MessageBox.Show("Please enter a email address.");
                return;
            }
            if (meetingWithComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select who you will meet with.");
                return;
            }
            if (meetingAimButton.Text == "Meeting Aim")
            {
                MessageBox.Show("Please select the meeting aim.");
                return;
            }
            // Check phone number is valid
            UInt64 dummy;
            if (!UInt64.TryParse(mobileTextBox.Text, out dummy))
            {
                MessageBox.Show("Please enter a valid mobile number.");
                return;
            }
            // Add visitor to on site list box.
            visitorsOnSiteListBox.Items.Add("Meeting of: " + nameTextBox.Text + " " + surnameTextBox.Text);
            visitorsOnSiteListBox.Items.Add("Meeting at: " + timeHourNumericUpDown.Value + ":" + timeMinuteNumericUpDown.Value);
            visitorsOnSiteListBox.Items.Add("Meeting with: " + meetingWithComboBox.SelectedItem);
            visitorsOnSiteListBox.Items.Add("Meeting aim: " + meetingAimButton.Text);
            visitorsOnSiteListBox.Items.Add("-------------------------------------------");
        }
    }
}
