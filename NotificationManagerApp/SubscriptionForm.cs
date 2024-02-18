using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagerApp
{
    public partial class SubscriptionForm : Form
    {
        public delegate void NotificationHandler(string message);


        public event NotificationHandler EmailNotification;
        public event NotificationHandler SmsNotification;

        public SubscriptionForm()
        {
            InitializeComponent();
            btnUnsubscribe.Enabled = false;
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {

            lblResult1.Text = string.Empty;
            lblResult1.ForeColor = DefaultForeColor;

            lblResult2.Text = string.Empty;
            lblResult2.ForeColor = DefaultForeColor;

            if (!string.IsNullOrEmpty(tbEmail.Text) && IsValidEmail(tbEmail.Text))
            {
                if (Subscriber.GetAllSubscribers().All(sub => sub.Email != tbEmail.Text))
                {
                    new Subscriber(tbEmail.Text, null);
                    lblResult1.Text = "Email approved";
                }
                else
                {
                    lblResult1.Text = "Email already exists";
                    lblResult1.ForeColor = Color.Red;
                }
            }
            else if (string.IsNullOrEmpty(tbEmail.Text))
            {
                lblResult1.Text = string.Empty;
            }
            else
            {
                lblResult1.Text = "Invalid email format";
                lblResult1.ForeColor = Color.Red;
            }

            if (!string.IsNullOrEmpty(tbSms.Text) && IsValidPhoneNumber(tbSms.Text))
            {
                if (Subscriber.GetAllSubscribers().All(sub => sub.PhoneNumber != tbSms.Text))
                {
                    new Subscriber(null, tbSms.Text);
                    lblResult2.Text = "SMS approved";
                }
                else
                {
                    lblResult2.Text = "Phone number already exists";
                    lblResult2.ForeColor = Color.Red;
                }
            }
            else if (string.IsNullOrEmpty(tbSms.Text))
            {
                lblResult2.Text = string.Empty;
            }
            else
            {
                lblResult2.Text = "Invalid phone number format";
                lblResult2.ForeColor = Color.Red;
            }

            btnUnsubscribe.Enabled = Subscriber.GetAllSubscribers().Count > 0;
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            lblResult1.Text = string.Empty;
            lblResult1.ForeColor = DefaultForeColor;

            lblResult2.Text = string.Empty;
            lblResult2.ForeColor = DefaultForeColor;

            if (!string.IsNullOrEmpty(tbEmail.Text))
            {
                Subscriber.GetAllSubscribers().RemoveAll(sub => sub.Email == tbEmail.Text);
                lblResult1.Text = "Email unsubscribed";
            }
            else
            {
                lblResult1.Text = string.Empty;
            }

            if (!string.IsNullOrEmpty(tbSms.Text))
            {
                Subscriber.GetAllSubscribers().RemoveAll(sub => sub.PhoneNumber == tbSms.Text);
                lblResult2.Text = "SMS unsubscribed";
            }
            else
            {
                lblResult2.Text = string.Empty;
            }

            btnUnsubscribe.Enabled = Subscriber.GetAllSubscribers().Count > 0;
        }


        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
