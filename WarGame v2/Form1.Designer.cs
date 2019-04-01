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
			this.button1 = new System.Windows.Forms.Button();
			this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.waterLevelGroup = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.maxHeightGroup = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.heightVariationGroup = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			this.minHeightGroup = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.trackBar4 = new System.Windows.Forms.TrackBar();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
			this.waterLevelGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.maxHeightGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			this.heightVariationGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			this.minHeightGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(558, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 70);
			this.button1.TabIndex = 0;
			this.button1.Text = "Generate new map";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// backgroundPictureBox
			// 
			this.backgroundPictureBox.Location = new System.Drawing.Point(12, 2);
			this.backgroundPictureBox.Name = "backgroundPictureBox";
			this.backgroundPictureBox.Size = new System.Drawing.Size(513, 513);
			this.backgroundPictureBox.TabIndex = 1;
			this.backgroundPictureBox.TabStop = false;
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
			this.label2.Text = "120";
			// 
			// waterLevelGroup
			// 
			this.waterLevelGroup.Controls.Add(this.label2);
			this.waterLevelGroup.Controls.Add(this.label3);
			this.waterLevelGroup.Controls.Add(this.label1);
			this.waterLevelGroup.Controls.Add(this.trackBar1);
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
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(9, 41);
			this.trackBar1.Maximum = 12;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(105, 45);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// maxHeightGroup
			// 
			this.maxHeightGroup.Controls.Add(this.label4);
			this.maxHeightGroup.Controls.Add(this.label5);
			this.maxHeightGroup.Controls.Add(this.label6);
			this.maxHeightGroup.Controls.Add(this.trackBar2);
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
			this.label6.Size = new System.Drawing.Size(25, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "140";
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(9, 41);
			this.trackBar2.Maximum = 12;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(105, 45);
			this.trackBar2.TabIndex = 2;
			this.trackBar2.Value = 12;
			this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// heightVariationGroup
			// 
			this.heightVariationGroup.Controls.Add(this.label7);
			this.heightVariationGroup.Controls.Add(this.label8);
			this.heightVariationGroup.Controls.Add(this.label9);
			this.heightVariationGroup.Controls.Add(this.trackBar3);
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
			// trackBar3
			// 
			this.trackBar3.Location = new System.Drawing.Point(9, 41);
			this.trackBar3.Maximum = 12;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new System.Drawing.Size(105, 45);
			this.trackBar3.TabIndex = 2;
			this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
			// 
			// minHeightGroup
			// 
			this.minHeightGroup.Controls.Add(this.label10);
			this.minHeightGroup.Controls.Add(this.label11);
			this.minHeightGroup.Controls.Add(this.label12);
			this.minHeightGroup.Controls.Add(this.trackBar4);
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
			this.label10.Size = new System.Drawing.Size(19, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "59";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(18, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 20);
			this.label11.TabIndex = 0;
			this.label11.Text = "Min Height";
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
			// trackBar4
			// 
			this.trackBar4.Location = new System.Drawing.Point(9, 41);
			this.trackBar4.Maximum = 12;
			this.trackBar4.Name = "trackBar4";
			this.trackBar4.Size = new System.Drawing.Size(105, 45);
			this.trackBar4.TabIndex = 2;
			this.trackBar4.Value = 12;
			this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(685, 15);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(99, 70);
			this.button2.TabIndex = 9;
			this.button2.Text = "Accept Map";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 539);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.minHeightGroup);
			this.Controls.Add(this.heightVariationGroup);
			this.Controls.Add(this.maxHeightGroup);
			this.Controls.Add(this.backgroundPictureBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.waterLevelGroup);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
			this.waterLevelGroup.ResumeLayout(false);
			this.waterLevelGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.maxHeightGroup.ResumeLayout(false);
			this.maxHeightGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			this.heightVariationGroup.ResumeLayout(false);
			this.heightVariationGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			this.minHeightGroup.ResumeLayout(false);
			this.minHeightGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox backgroundPictureBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox waterLevelGroup;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.GroupBox maxHeightGroup;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.GroupBox heightVariationGroup;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TrackBar trackBar3;
		private System.Windows.Forms.GroupBox minHeightGroup;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TrackBar trackBar4;
		private System.Windows.Forms.Button button2;
	}
}

