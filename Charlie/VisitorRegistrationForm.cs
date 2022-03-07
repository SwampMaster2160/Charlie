using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        void ClearForm()
        {
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            mobileTextBox.Text = "";
            emailTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            timeHourNumericUpDown.Value = 0;
            timeMinuteNumericUpDown.Value = 0;
            meetingWithComboBox.SelectedItem = null;
            meetingAimButton.Text = "Meeting Aim";
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
            // Check email address is valid
            Regex email_regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!email_regex.Match(emailTextBox.Text).Success)
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            // Add visitor to on site list box.
            visitorsOnSiteListBox.Items.Add("Meeting of: " + nameTextBox.Text + " " + surnameTextBox.Text);
            visitorsOnSiteListBox.Items.Add("Meeting at: " + timeHourNumericUpDown.Value + ":" + timeMinuteNumericUpDown.Value + ". " + dateTimePicker.Text + ".");
            visitorsOnSiteListBox.Items.Add("Meeting with: " + meetingWithComboBox.SelectedItem);
            visitorsOnSiteListBox.Items.Add("Meeting aim: " + meetingAimButton.Text);
            visitorsOnSiteListBox.Items.Add("Mobile: " + mobileTextBox.Text + ". Email: " + emailTextBox.Text + ".");
            visitorsOnSiteListBox.Items.Add("-------------------------------------------");
            // Clear the form.
            ClearForm();
        }

        private void visitorsOnSiteListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue) == 46)
            {
                int selected = visitorsOnSiteListBox.SelectedIndex;
                for (int x = 0; x < 6; x++)
                {
                    if (visitorsOnSiteListBox.Items.Count > 0)
                    {
                        visitorsOnSiteListBox.Items.RemoveAt(selected / 6);
                    }
                }
            }
        }
    }
}
