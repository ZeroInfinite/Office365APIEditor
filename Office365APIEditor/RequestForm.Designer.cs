﻿namespace Office365APIEditor
{
    partial class RequestForm
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
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_Run = new System.Windows.Forms.Button();
            this.textBox_Request = new System.Windows.Forms.TextBox();
            this.textBox_BasicAuthSMTPAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_BasicAuthPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_Get = new System.Windows.Forms.RadioButton();
            this.radioButton_POST = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_RequestBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Response :";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Result.Location = new System.Drawing.Point(18, 205);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Result.Size = new System.Drawing.Size(785, 226);
            this.textBox_Result.TabIndex = 22;
            this.textBox_Result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Result_KeyDown);
            // 
            // button_Run
            // 
            this.button_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Run.Location = new System.Drawing.Point(701, 155);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(107, 23);
            this.button_Run.TabIndex = 21;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // textBox_Request
            // 
            this.textBox_Request.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Request.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Office365APIEditor.Properties.Settings.Default, "LastRequest", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Request.Location = new System.Drawing.Point(103, 32);
            this.textBox_Request.Multiline = true;
            this.textBox_Request.Name = "textBox_Request";
            this.textBox_Request.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Request.Size = new System.Drawing.Size(587, 70);
            this.textBox_Request.TabIndex = 20;
            this.textBox_Request.Text = global::Office365APIEditor.Properties.Settings.Default.LastRequest;
            this.textBox_Request.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Request_KeyDown);
            // 
            // textBox_BasicAuthSMTPAddress
            // 
            this.textBox_BasicAuthSMTPAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Office365APIEditor.Properties.Settings.Default, "BasicAuthSmtpAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_BasicAuthSMTPAddress.Location = new System.Drawing.Point(103, 6);
            this.textBox_BasicAuthSMTPAddress.Name = "textBox_BasicAuthSMTPAddress";
            this.textBox_BasicAuthSMTPAddress.Size = new System.Drawing.Size(295, 20);
            this.textBox_BasicAuthSMTPAddress.TabIndex = 25;
            this.textBox_BasicAuthSMTPAddress.Text = global::Office365APIEditor.Properties.Settings.Default.BasicAuthSmtpAddress;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "SMTP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password";
            // 
            // textBox_BasicAuthPassword
            // 
            this.textBox_BasicAuthPassword.Location = new System.Drawing.Point(513, 6);
            this.textBox_BasicAuthPassword.Name = "textBox_BasicAuthPassword";
            this.textBox_BasicAuthPassword.Size = new System.Drawing.Size(295, 20);
            this.textBox_BasicAuthPassword.TabIndex = 27;
            this.textBox_BasicAuthPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Request";
            // 
            // radioButton_Get
            // 
            this.radioButton_Get.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Get.AutoSize = true;
            this.radioButton_Get.Checked = true;
            this.radioButton_Get.Location = new System.Drawing.Point(701, 109);
            this.radioButton_Get.Name = "radioButton_Get";
            this.radioButton_Get.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Get.TabIndex = 29;
            this.radioButton_Get.TabStop = true;
            this.radioButton_Get.Text = "GET";
            this.radioButton_Get.UseVisualStyleBackColor = true;
            // 
            // radioButton_POST
            // 
            this.radioButton_POST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_POST.AutoSize = true;
            this.radioButton_POST.Location = new System.Drawing.Point(701, 132);
            this.radioButton_POST.Name = "radioButton_POST";
            this.radioButton_POST.Size = new System.Drawing.Size(54, 17);
            this.radioButton_POST.TabIndex = 30;
            this.radioButton_POST.Text = "POST";
            this.radioButton_POST.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Body";
            // 
            // textBox_RequestBody
            // 
            this.textBox_RequestBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RequestBody.Location = new System.Drawing.Point(103, 108);
            this.textBox_RequestBody.Multiline = true;
            this.textBox_RequestBody.Name = "textBox_RequestBody";
            this.textBox_RequestBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_RequestBody.Size = new System.Drawing.Size(587, 70);
            this.textBox_RequestBody.TabIndex = 32;
            this.textBox_RequestBody.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_RequestBody_KeyDown);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 447);
            this.Controls.Add(this.textBox_RequestBody);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton_POST);
            this.Controls.Add(this.radioButton_Get);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_BasicAuthPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_BasicAuthSMTPAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.textBox_Request);
            this.MinimumSize = new System.Drawing.Size(836, 486);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.TextBox textBox_Request;
        private System.Windows.Forms.TextBox textBox_BasicAuthSMTPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_BasicAuthPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_Get;
        private System.Windows.Forms.RadioButton radioButton_POST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_RequestBody;
    }
}