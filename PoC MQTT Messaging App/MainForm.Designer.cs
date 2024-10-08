﻿namespace PoC_MQTT_Messaging_App
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
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtPublishTopic = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPublishMessage = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.lblSubscribeTopic = new System.Windows.Forms.Label();
            this.txtSubscribeTopic = new System.Windows.Forms.TextBox();
            this.lblReceivedMessages = new System.Windows.Forms.Label();
            this.lstSubscribeMessages = new System.Windows.Forms.ListBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.AutoSize = true;
            this.lblServerAddress.Location = new System.Drawing.Point(12, 9);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(72, 13);
            this.lblServerAddress.TabIndex = 0;
            this.lblServerAddress.Text = "MQTT Server";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(90, 6);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(160, 20);
            this.txtServerAddress.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(256, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(498, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(160, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "disconnected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(48, 78);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(34, 13);
            this.lblTopic.TabIndex = 4;
            this.lblTopic.Text = "Topic";
            // 
            // txtPublishTopic
            // 
            this.txtPublishTopic.Location = new System.Drawing.Point(89, 78);
            this.txtPublishTopic.Name = "txtPublishTopic";
            this.txtPublishTopic.Size = new System.Drawing.Size(160, 20);
            this.txtPublishTopic.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(32, 107);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Message";
            // 
            // txtPublishMessage
            // 
            this.txtPublishMessage.Location = new System.Drawing.Point(90, 104);
            this.txtPublishMessage.Multiline = true;
            this.txtPublishMessage.Name = "txtPublishMessage";
            this.txtPublishMessage.Size = new System.Drawing.Size(160, 60);
            this.txtPublishMessage.TabIndex = 7;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(256, 141);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 8;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // lblSubscribeTopic
            // 
            this.lblSubscribeTopic.AutoSize = true;
            this.lblSubscribeTopic.Location = new System.Drawing.Point(377, 78);
            this.lblSubscribeTopic.Name = "lblSubscribeTopic";
            this.lblSubscribeTopic.Size = new System.Drawing.Size(34, 13);
            this.lblSubscribeTopic.TabIndex = 9;
            this.lblSubscribeTopic.Text = "Topic";
            // 
            // txtSubscribeTopic
            // 
            this.txtSubscribeTopic.Location = new System.Drawing.Point(417, 78);
            this.txtSubscribeTopic.Name = "txtSubscribeTopic";
            this.txtSubscribeTopic.Size = new System.Drawing.Size(160, 20);
            this.txtSubscribeTopic.TabIndex = 10;
            // 
            // lblReceivedMessages
            // 
            this.lblReceivedMessages.AutoSize = true;
            this.lblReceivedMessages.Location = new System.Drawing.Point(361, 104);
            this.lblReceivedMessages.Name = "lblReceivedMessages";
            this.lblReceivedMessages.Size = new System.Drawing.Size(55, 13);
            this.lblReceivedMessages.TabIndex = 11;
            this.lblReceivedMessages.Text = "Messages";
            // 
            // lstSubscribeMessages
            // 
            this.lstSubscribeMessages.FormattingEnabled = true;
            this.lstSubscribeMessages.Location = new System.Drawing.Point(417, 104);
            this.lstSubscribeMessages.Name = "lstSubscribeMessages";
            this.lstSubscribeMessages.Size = new System.Drawing.Size(160, 95);
            this.lstSubscribeMessages.TabIndex = 12;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(583, 78);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 13;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 338);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.lstSubscribeMessages);
            this.Controls.Add(this.lblReceivedMessages);
            this.Controls.Add(this.txtSubscribeTopic);
            this.Controls.Add(this.lblSubscribeTopic);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtPublishMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtPublishTopic);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtServerAddress);
            this.Controls.Add(this.lblServerAddress);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerAddress;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtPublishTopic;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtPublishMessage;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Label lblSubscribeTopic;
        private System.Windows.Forms.TextBox txtSubscribeTopic;
        private System.Windows.Forms.Label lblReceivedMessages;
        private System.Windows.Forms.ListBox lstSubscribeMessages;
        private System.Windows.Forms.Button btnSubscribe;
    }
}

