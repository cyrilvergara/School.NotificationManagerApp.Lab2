﻿namespace NotificationManagerApp
{
    partial class PublishForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbNotifContent = new System.Windows.Forms.TextBox();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Content";
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(32, 191);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(105, 39);
            this.btnPublish.TabIndex = 1;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(32, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbNotifContent
            // 
            this.tbNotifContent.Location = new System.Drawing.Point(165, 34);
            this.tbNotifContent.Name = "tbNotifContent";
            this.tbNotifContent.Size = new System.Drawing.Size(259, 22);
            this.tbNotifContent.TabIndex = 3;
            // 
            // lblResult3
            // 
            this.lblResult3.AutoSize = true;
            this.lblResult3.Location = new System.Drawing.Point(166, 73);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(0, 16);
            this.lblResult3.TabIndex = 4;
            // 
            // PublishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 293);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.tbNotifContent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.label1);
            this.Name = "PublishForm";
            this.Text = "PublishForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbNotifContent;
        private System.Windows.Forms.Label lblResult3;
    }
}