namespace WarGame_v2
{
	partial class Form1
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
            this.generateMapButton = new System.Windows.Forms.Button();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waterLevelGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.waterBar = new System.Windows.Forms.TrackBar();
            this.maxHeightGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxHBar = new System.Windows.Forms.TrackBar();
            this.heightVariationGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.variationBar = new System.Windows.Forms.TrackBar();
            this.minHeightGroup = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.smoothnessBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.alternateStyleCheckBox = new System.Windows.Forms.CheckBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.randomSeedButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generateRandomMapButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.startServerButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.nrConnectedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.waterLevelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waterBar)).BeginInit();
            this.maxHeightGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHBar)).BeginInit();
            this.heightVariationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variationBar)).BeginInit();
            this.minHeightGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothnessBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateMapButton
            // 
            this.generateMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateMapButton.Location = new System.Drawing.Point(558, 15);
            this.generateMapButton.Name = "generateMapButton";
            this.generateMapButton.Size = new System.Drawing.Size(99, 70);
            this.generateMapButton.TabIndex = 0;
            this.generateMapButton.Text = "Generate map";
            this.generateMapButton.UseVisualStyleBackColor = true;
            this.generateMapButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Location = new System.Drawing.Point(12, 2);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(513, 513);
            this.backgroundPictureBox.TabIndex = 1;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackgroundPictureBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "100";
            // 
            // waterLevelGroup
            // 
            this.waterLevelGroup.Controls.Add(this.label2);
            this.waterLevelGroup.Controls.Add(this.label3);
            this.waterLevelGroup.Controls.Add(this.label1);
            this.waterLevelGroup.Controls.Add(this.waterBar);
            this.waterLevelGroup.Location = new System.Drawing.Point(674, 209);
            this.waterLevelGroup.Name = "waterLevelGroup";
            this.waterLevelGroup.Size = new System.Drawing.Size(120, 111);
            this.waterLevelGroup.TabIndex = 6;
            this.waterLevelGroup.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Water Level";
            // 
            // waterBar
            // 
            this.waterBar.Location = new System.Drawing.Point(9, 41);
            this.waterBar.Name = "waterBar";
            this.waterBar.Size = new System.Drawing.Size(105, 45);
            this.waterBar.TabIndex = 2;
            // 
            // maxHeightGroup
            // 
            this.maxHeightGroup.Controls.Add(this.label4);
            this.maxHeightGroup.Controls.Add(this.label5);
            this.maxHeightGroup.Controls.Add(this.label6);
            this.maxHeightGroup.Controls.Add(this.maxHBar);
            this.maxHeightGroup.Location = new System.Drawing.Point(674, 92);
            this.maxHeightGroup.Name = "maxHeightGroup";
            this.maxHeightGroup.Size = new System.Drawing.Size(120, 111);
            this.maxHeightGroup.TabIndex = 7;
            this.maxHeightGroup.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "50";
            // 
            // maxHBar
            // 
            this.maxHBar.Location = new System.Drawing.Point(9, 41);
            this.maxHBar.Maximum = 12;
            this.maxHBar.Name = "maxHBar";
            this.maxHBar.Size = new System.Drawing.Size(105, 45);
            this.maxHBar.TabIndex = 2;
            this.maxHBar.Value = 12;
            this.maxHBar.Scroll += new System.EventHandler(this.MaxHBar_Scroll);
            // 
            // heightVariationGroup
            // 
            this.heightVariationGroup.Controls.Add(this.label7);
            this.heightVariationGroup.Controls.Add(this.label8);
            this.heightVariationGroup.Controls.Add(this.label9);
            this.heightVariationGroup.Controls.Add(this.variationBar);
            this.heightVariationGroup.Location = new System.Drawing.Point(548, 209);
            this.heightVariationGroup.Name = "heightVariationGroup";
            this.heightVariationGroup.Size = new System.Drawing.Size(120, 111);
            this.heightVariationGroup.TabIndex = 7;
            this.heightVariationGroup.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Height Variation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "10";
            // 
            // variationBar
            // 
            this.variationBar.Location = new System.Drawing.Point(9, 41);
            this.variationBar.Maximum = 9;
            this.variationBar.Name = "variationBar";
            this.variationBar.Size = new System.Drawing.Size(105, 45);
            this.variationBar.TabIndex = 2;
            this.variationBar.Scroll += new System.EventHandler(this.VariationBar_Scroll);
            // 
            // minHeightGroup
            // 
            this.minHeightGroup.Controls.Add(this.label10);
            this.minHeightGroup.Controls.Add(this.label11);
            this.minHeightGroup.Controls.Add(this.label12);
            this.minHeightGroup.Controls.Add(this.smoothnessBar);
            this.minHeightGroup.Location = new System.Drawing.Point(548, 92);
            this.minHeightGroup.Name = "minHeightGroup";
            this.minHeightGroup.Size = new System.Drawing.Size(120, 111);
            this.minHeightGroup.TabIndex = 8;
            this.minHeightGroup.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Smoothness";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "1";
            // 
            // smoothnessBar
            // 
            this.smoothnessBar.Location = new System.Drawing.Point(9, 41);
            this.smoothnessBar.Maximum = 12;
            this.smoothnessBar.Name = "smoothnessBar";
            this.smoothnessBar.Size = new System.Drawing.Size(105, 45);
            this.smoothnessBar.TabIndex = 2;
            this.smoothnessBar.Value = 12;
            this.smoothnessBar.Scroll += new System.EventHandler(this.SmoothnessBar_Scroll);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(548, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 70);
            this.button2.TabIndex = 9;
            this.button2.Text = "Accept Map";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // alternateStyleCheckBox
            // 
            this.alternateStyleCheckBox.AutoSize = true;
            this.alternateStyleCheckBox.Location = new System.Drawing.Point(14, 518);
            this.alternateStyleCheckBox.Name = "alternateStyleCheckBox";
            this.alternateStyleCheckBox.Size = new System.Drawing.Size(92, 17);
            this.alternateStyleCheckBox.TabIndex = 10;
            this.alternateStyleCheckBox.Text = "Alternate style";
            this.alternateStyleCheckBox.UseVisualStyleBackColor = true;
            this.alternateStyleCheckBox.CheckedChanged += new System.EventHandler(this.AlternateStyleCheckBox_CheckedChanged);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(589, 411);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(0, 13);
            this.debugLabel.TabIndex = 11;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.Location = new System.Drawing.Point(18, 475);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(152, 33);
            this.loadingLabel.TabIndex = 12;
            this.loadingLabel.Text = "Loading...";
            this.loadingLabel.Visible = false;
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(19, 39);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(87, 20);
            this.seedTextBox.TabIndex = 13;
            this.seedTextBox.Text = "111111111";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Map Seed:";
            // 
            // randomSeedButton
            // 
            this.randomSeedButton.Location = new System.Drawing.Point(19, 70);
            this.randomSeedButton.Name = "randomSeedButton";
            this.randomSeedButton.Size = new System.Drawing.Size(87, 33);
            this.randomSeedButton.TabIndex = 15;
            this.randomSeedButton.Text = "Random Seed";
            this.randomSeedButton.UseVisualStyleBackColor = true;
            this.randomSeedButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.randomSeedButton);
            this.groupBox1.Controls.Add(this.seedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(548, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // generateRandomMapButton
            // 
            this.generateRandomMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateRandomMapButton.Location = new System.Drawing.Point(685, 15);
            this.generateRandomMapButton.Name = "generateRandomMapButton";
            this.generateRandomMapButton.Size = new System.Drawing.Size(99, 70);
            this.generateRandomMapButton.TabIndex = 13;
            this.generateRandomMapButton.Text = "Generate random map";
            this.generateRandomMapButton.UseVisualStyleBackColor = true;
            this.generateRandomMapButton.Click += new System.EventHandler(this.GenerateRandomMapButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serverStatusLabel);
            this.groupBox2.Controls.Add(this.ipTextbox);
            this.groupBox2.Controls.Add(this.startServerButton);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.portTextBox);
            this.groupBox2.Location = new System.Drawing.Point(674, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 111);
            this.groupBox2.TabIndex = 16;
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
            this.ipTextbox.Location = new System.Drawing.Point(19, 32);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(87, 20);
            this.ipTextbox.TabIndex = 17;
            this.ipTextbox.Text = "192.168.0.108";
            // 
            // startServerButton
            // 
            this.startServerButton.Location = new System.Drawing.Point(19, 82);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(87, 22);
            this.startServerButton.TabIndex = 16;
            this.startServerButton.Text = "Start Server";
            this.startServerButton.UseVisualStyleBackColor = true;
            this.startServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
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
            this.portTextBox.Location = new System.Drawing.Point(19, 57);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(87, 20);
            this.portTextBox.TabIndex = 13;
            this.portTextBox.Text = "4201";
            // 
            // nrConnectedLabel
            // 
            this.nrConnectedLabel.AutoSize = true;
            this.nrConnectedLabel.Location = new System.Drawing.Point(337, 522);
            this.nrConnectedLabel.Name = "nrConnectedLabel";
            this.nrConnectedLabel.Size = new System.Drawing.Size(41, 13);
            this.nrConnectedLabel.TabIndex = 17;
            this.nrConnectedLabel.Text = "label15";
            this.nrConnectedLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 539);
            this.Controls.Add(this.nrConnectedLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.generateRandomMapButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.alternateStyleCheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.minHeightGroup);
            this.Controls.Add(this.heightVariationGroup);
            this.Controls.Add(this.maxHeightGroup);
            this.Controls.Add(this.backgroundPictureBox);
            this.Controls.Add(this.generateMapButton);
            this.Controls.Add(this.waterLevelGroup);
            this.Name = "Form1";
            this.Text = "***";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.waterLevelGroup.ResumeLayout(false);
            this.waterLevelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waterBar)).EndInit();
            this.maxHeightGroup.ResumeLayout(false);
            this.maxHeightGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHBar)).EndInit();
            this.heightVariationGroup.ResumeLayout(false);
            this.heightVariationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variationBar)).EndInit();
            this.minHeightGroup.ResumeLayout(false);
            this.minHeightGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothnessBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button generateMapButton;
		private System.Windows.Forms.PictureBox backgroundPictureBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox waterLevelGroup;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar waterBar;
		private System.Windows.Forms.GroupBox maxHeightGroup;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar maxHBar;
		private System.Windows.Forms.GroupBox heightVariationGroup;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TrackBar variationBar;
		private System.Windows.Forms.GroupBox minHeightGroup;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TrackBar smoothnessBar;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox alternateStyleCheckBox;
		private System.Windows.Forms.Label debugLabel;
		private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.TextBox seedTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button randomSeedButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generateRandomMapButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button startServerButton;
        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.Label serverStatusLabel;
        private System.Windows.Forms.Label nrConnectedLabel;
    }
}

