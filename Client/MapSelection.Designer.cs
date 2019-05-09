namespace Client
{
    partial class MapSelection
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
            this.generateRandomMapButton = new System.Windows.Forms.Button();
            this.minHeightGroup = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.smoothnessBar = new System.Windows.Forms.TrackBar();
            this.heightVariationGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.variationBar = new System.Windows.Forms.TrackBar();
            this.maxHeightGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxHBar = new System.Windows.Forms.TrackBar();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.generateMapButton = new System.Windows.Forms.Button();
            this.waterLevelGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.waterBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.randomSeedButton = new System.Windows.Forms.Button();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.acceptedLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.alternateStyleCheckBox = new System.Windows.Forms.CheckBox();
            this.mapSelectionGroup = new System.Windows.Forms.GroupBox();
            this.unitSelectGroup = new System.Windows.Forms.GroupBox();
            this.minHeightGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothnessBar)).BeginInit();
            this.heightVariationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variationBar)).BeginInit();
            this.maxHeightGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.waterLevelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waterBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mapSelectionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateRandomMapButton
            // 
            this.generateRandomMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateRandomMapButton.Location = new System.Drawing.Point(150, 8);
            this.generateRandomMapButton.Name = "generateRandomMapButton";
            this.generateRandomMapButton.Size = new System.Drawing.Size(99, 70);
            this.generateRandomMapButton.TabIndex = 20;
            this.generateRandomMapButton.Text = "Generate random map";
            this.generateRandomMapButton.UseVisualStyleBackColor = true;
            this.generateRandomMapButton.Click += new System.EventHandler(this.GenerateRandomMapButton_Click);
            // 
            // minHeightGroup
            // 
            this.minHeightGroup.Controls.Add(this.label10);
            this.minHeightGroup.Controls.Add(this.label11);
            this.minHeightGroup.Controls.Add(this.label12);
            this.minHeightGroup.Controls.Add(this.smoothnessBar);
            this.minHeightGroup.Location = new System.Drawing.Point(13, 85);
            this.minHeightGroup.Name = "minHeightGroup";
            this.minHeightGroup.Size = new System.Drawing.Size(120, 111);
            this.minHeightGroup.TabIndex = 19;
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
            // heightVariationGroup
            // 
            this.heightVariationGroup.Controls.Add(this.label7);
            this.heightVariationGroup.Controls.Add(this.label8);
            this.heightVariationGroup.Controls.Add(this.label9);
            this.heightVariationGroup.Controls.Add(this.variationBar);
            this.heightVariationGroup.Location = new System.Drawing.Point(13, 202);
            this.heightVariationGroup.Name = "heightVariationGroup";
            this.heightVariationGroup.Size = new System.Drawing.Size(120, 111);
            this.heightVariationGroup.TabIndex = 17;
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
            // maxHeightGroup
            // 
            this.maxHeightGroup.Controls.Add(this.label4);
            this.maxHeightGroup.Controls.Add(this.label5);
            this.maxHeightGroup.Controls.Add(this.label6);
            this.maxHeightGroup.Controls.Add(this.maxHBar);
            this.maxHeightGroup.Location = new System.Drawing.Point(139, 85);
            this.maxHeightGroup.Name = "maxHeightGroup";
            this.maxHeightGroup.Size = new System.Drawing.Size(120, 111);
            this.maxHeightGroup.TabIndex = 18;
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
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Location = new System.Drawing.Point(4, 2);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(513, 513);
            this.backgroundPictureBox.TabIndex = 15;
            this.backgroundPictureBox.TabStop = false;
            // 
            // generateMapButton
            // 
            this.generateMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateMapButton.Location = new System.Drawing.Point(23, 8);
            this.generateMapButton.Name = "generateMapButton";
            this.generateMapButton.Size = new System.Drawing.Size(99, 70);
            this.generateMapButton.TabIndex = 14;
            this.generateMapButton.Text = "Generate map";
            this.generateMapButton.UseVisualStyleBackColor = true;
            this.generateMapButton.Click += new System.EventHandler(this.GenerateMapButton_Click);
            // 
            // waterLevelGroup
            // 
            this.waterLevelGroup.Controls.Add(this.label2);
            this.waterLevelGroup.Controls.Add(this.label3);
            this.waterLevelGroup.Controls.Add(this.label1);
            this.waterLevelGroup.Controls.Add(this.waterBar);
            this.waterLevelGroup.Location = new System.Drawing.Point(139, 202);
            this.waterLevelGroup.Name = "waterLevelGroup";
            this.waterLevelGroup.Size = new System.Drawing.Size(120, 111);
            this.waterLevelGroup.TabIndex = 16;
            this.waterLevelGroup.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // waterBar
            // 
            this.waterBar.Location = new System.Drawing.Point(9, 41);
            this.waterBar.Name = "waterBar";
            this.waterBar.Size = new System.Drawing.Size(105, 45);
            this.waterBar.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.randomSeedButton);
            this.groupBox1.Controls.Add(this.seedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 111);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
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
            this.randomSeedButton.Click += new System.EventHandler(this.RandomSeedButton_Click);
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(19, 39);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(87, 20);
            this.seedTextBox.TabIndex = 13;
            this.seedTextBox.Text = "111111111";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 70);
            this.button2.TabIndex = 22;
            this.button2.Text = "Accept Map";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.acceptedLabel);
            this.groupBox2.Controls.Add(this.modeLabel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(139, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 111);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // acceptedLabel
            // 
            this.acceptedLabel.AutoSize = true;
            this.acceptedLabel.Location = new System.Drawing.Point(23, 80);
            this.acceptedLabel.Name = "acceptedLabel";
            this.acceptedLabel.Size = new System.Drawing.Size(0, 13);
            this.acceptedLabel.TabIndex = 16;
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.Location = new System.Drawing.Point(8, 48);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(0, 20);
            this.modeLabel.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Mode";
            // 
            // alternateStyleCheckBox
            // 
            this.alternateStyleCheckBox.AutoSize = true;
            this.alternateStyleCheckBox.Location = new System.Drawing.Point(12, 521);
            this.alternateStyleCheckBox.Name = "alternateStyleCheckBox";
            this.alternateStyleCheckBox.Size = new System.Drawing.Size(92, 17);
            this.alternateStyleCheckBox.TabIndex = 23;
            this.alternateStyleCheckBox.Text = "Alternate style";
            this.alternateStyleCheckBox.UseVisualStyleBackColor = true;
            this.alternateStyleCheckBox.CheckedChanged += new System.EventHandler(this.AlternateStyleCheckBox_CheckedChanged);
            // 
            // mapSelectionGroup
            // 
            this.mapSelectionGroup.Controls.Add(this.unitSelectGroup);
            this.mapSelectionGroup.Controls.Add(this.button2);
            this.mapSelectionGroup.Controls.Add(this.waterLevelGroup);
            this.mapSelectionGroup.Controls.Add(this.groupBox2);
            this.mapSelectionGroup.Controls.Add(this.generateMapButton);
            this.mapSelectionGroup.Controls.Add(this.maxHeightGroup);
            this.mapSelectionGroup.Controls.Add(this.groupBox1);
            this.mapSelectionGroup.Controls.Add(this.heightVariationGroup);
            this.mapSelectionGroup.Controls.Add(this.generateRandomMapButton);
            this.mapSelectionGroup.Controls.Add(this.minHeightGroup);
            this.mapSelectionGroup.Location = new System.Drawing.Point(524, 3);
            this.mapSelectionGroup.Name = "mapSelectionGroup";
            this.mapSelectionGroup.Size = new System.Drawing.Size(274, 512);
            this.mapSelectionGroup.TabIndex = 24;
            this.mapSelectionGroup.TabStop = false;
            this.mapSelectionGroup.Visible = false;
            // 
            // unitSelectGroup
            // 
            this.unitSelectGroup.Location = new System.Drawing.Point(0, 0);
            this.unitSelectGroup.Name = "unitSelectGroup";
            this.unitSelectGroup.Size = new System.Drawing.Size(274, 512);
            this.unitSelectGroup.TabIndex = 25;
            this.unitSelectGroup.TabStop = false;
            this.unitSelectGroup.Visible = false;
            // 
            // MapSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 547);
            this.Controls.Add(this.mapSelectionGroup);
            this.Controls.Add(this.alternateStyleCheckBox);
            this.Controls.Add(this.backgroundPictureBox);
            this.Name = "MapSelection";
            this.Text = "MapSelection";
            this.Load += new System.EventHandler(this.MapSelection_Load);
            this.minHeightGroup.ResumeLayout(false);
            this.minHeightGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothnessBar)).EndInit();
            this.heightVariationGroup.ResumeLayout(false);
            this.heightVariationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variationBar)).EndInit();
            this.maxHeightGroup.ResumeLayout(false);
            this.maxHeightGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.waterLevelGroup.ResumeLayout(false);
            this.waterLevelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waterBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mapSelectionGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateRandomMapButton;
        private System.Windows.Forms.GroupBox minHeightGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar smoothnessBar;
        private System.Windows.Forms.GroupBox heightVariationGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar variationBar;
        private System.Windows.Forms.GroupBox maxHeightGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar maxHBar;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.Button generateMapButton;
        private System.Windows.Forms.GroupBox waterLevelGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar waterBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button randomSeedButton;
        private System.Windows.Forms.TextBox seedTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox alternateStyleCheckBox;
        private System.Windows.Forms.Label acceptedLabel;
        private System.Windows.Forms.GroupBox mapSelectionGroup;
        private System.Windows.Forms.GroupBox unitSelectGroup;
    }
}