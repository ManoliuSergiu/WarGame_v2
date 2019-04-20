﻿namespace Client
{
    partial class ConnectionForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.startServerButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.alternateStyleCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serverStatusLabel);
            this.groupBox2.Controls.Add(this.ipTextbox);
            this.groupBox2.Controls.Add(this.startServerButton);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.portTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 111);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.AutoSize = true;
            this.serverStatusLabel.Location = new System.Drawing.Point(89, 12);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(10, 13);
            this.serverStatusLabel.TabIndex = 18;
            this.serverStatusLabel.Text = " ";
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(12, 31);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(102, 20);
            this.ipTextbox.TabIndex = 17;
            this.ipTextbox.Text = "192.168.0.108";
            // 
            // startServerButton
            // 
            this.startServerButton.Location = new System.Drawing.Point(12, 83);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(102, 22);
            this.startServerButton.TabIndex = 16;
            this.startServerButton.Text = "Connect to Server";
            this.startServerButton.UseVisualStyleBackColor = true;
            this.startServerButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Server";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(12, 57);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(102, 20);
            this.portTextBox.TabIndex = 13;
            this.portTextBox.Text = "4201";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Location = new System.Drawing.Point(211, 0);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(513, 513);
            this.backgroundPictureBox.TabIndex = 19;
            this.backgroundPictureBox.TabStop = false;
            // 
            // alternateStyleCheckBox
            // 
            this.alternateStyleCheckBox.AutoSize = true;
            this.alternateStyleCheckBox.Location = new System.Drawing.Point(19, 160);
            this.alternateStyleCheckBox.Name = "alternateStyleCheckBox";
            this.alternateStyleCheckBox.Size = new System.Drawing.Size(92, 17);
            this.alternateStyleCheckBox.TabIndex = 20;
            this.alternateStyleCheckBox.Text = "Alternate style";
            this.alternateStyleCheckBox.UseVisualStyleBackColor = true;
            this.alternateStyleCheckBox.CheckedChanged += new System.EventHandler(this.AlternateStyleCheckBox_CheckedChanged);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 525);
            this.Controls.Add(this.alternateStyleCheckBox);
            this.Controls.Add(this.backgroundPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ConnectionForm";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label serverStatusLabel;
        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.Button startServerButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.CheckBox alternateStyleCheckBox;
    }
}

