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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            btnPubNotif.Enabled = false;

            if (Subscriber.GetAllSubscribers().Count > 0)
            {
                btnPubNotif.Enabled = true;
            }
        }

        private void btnManSub_Click(object sender, EventArgs e)
        {
            SubscriptionForm subscriptionForm = new SubscriptionForm();
            subscriptionForm.FormClosed += SubscriptionFormClosed;
            subscriptionForm.Show();
        }

        private void btnPubNotif_Click(object sender, EventArgs e)
        {
            PublishForm publishForm = new PublishForm();
            publishForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SubscriptionFormClosed(object sender, FormClosedEventArgs e)
        {
            btnPubNotif.Enabled = Subscriber.GetAllSubscribers().Count > 0;
        }
    }
}
