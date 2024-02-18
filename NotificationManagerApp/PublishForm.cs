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
    public partial class PublishForm : Form
    {
        public PublishForm()
        {
            InitializeComponent();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            string message = tbNotifContent.Text;

            lblResult3.Text = $"Notification sent: {message}\n\nSubscribers:\n";

            foreach (var subscriber in Subscriber.GetAllSubscribers().Where(sub => !string.IsNullOrEmpty(sub.Email) || !string.IsNullOrEmpty(sub.PhoneNumber)))
            {
                if (!string.IsNullOrEmpty(subscriber.Email))
                {
                    lblResult3.Text += $"Email: {subscriber.Email}\n";
                }

                if (!string.IsNullOrEmpty(subscriber.PhoneNumber))
                {
                    lblResult3.Text += $"Phone: {subscriber.PhoneNumber}\n";
                }
            }

            tbNotifContent.Text = string.Empty;
            btnPublish.Enabled = Subscriber.GetAllSubscribers().Count > 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
