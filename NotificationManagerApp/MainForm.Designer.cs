namespace NotificationManagerApp
{
    partial class MainForm
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
            this.btnManSub = new System.Windows.Forms.Button();
            this.btnPubNotif = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManSub
            // 
            this.btnManSub.Location = new System.Drawing.Point(21, 48);
            this.btnManSub.Name = "btnManSub";
            this.btnManSub.Size = new System.Drawing.Size(145, 43);
            this.btnManSub.TabIndex = 0;
            this.btnManSub.Text = "Manage Subscription";
            this.btnManSub.UseVisualStyleBackColor = true;
            this.btnManSub.Click += new System.EventHandler(this.btnManSub_Click);
            // 
            // btnPubNotif
            // 
            this.btnPubNotif.Location = new System.Drawing.Point(183, 48);
            this.btnPubNotif.Name = "btnPubNotif";
            this.btnPubNotif.Size = new System.Drawing.Size(145, 43);
            this.btnPubNotif.TabIndex = 1;
            this.btnPubNotif.Text = "Publish Notification";
            this.btnPubNotif.UseVisualStyleBackColor = true;
            this.btnPubNotif.Click += new System.EventHandler(this.btnPubNotif_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(369, 48);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 140);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPubNotif);
            this.Controls.Add(this.btnManSub);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManSub;
        private System.Windows.Forms.Button btnPubNotif;
        private System.Windows.Forms.Button btnExit;
    }
}

