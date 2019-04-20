namespace Client
{
    partial class StartupForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.multiplayerButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Singleplayer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // multiplayerButton
            // 
            this.multiplayerButton.Location = new System.Drawing.Point(33, 101);
            this.multiplayerButton.Name = "multiplayerButton";
            this.multiplayerButton.Size = new System.Drawing.Size(197, 47);
            this.multiplayerButton.TabIndex = 1;
            this.multiplayerButton.Text = "Multiplayer";
            this.multiplayerButton.UseVisualStyleBackColor = true;
            this.multiplayerButton.Click += new System.EventHandler(this.MultiplayerButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(33, 247);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(197, 47);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 390);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.multiplayerButton);
            this.Controls.Add(this.button1);
            this.Name = "StartupForm";
            this.Text = "Startup";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button multiplayerButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitButton;
    }
}