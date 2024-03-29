namespace MusicLibForms
{
	partial class PaymentWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentWindow));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.continueButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(221, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(466, 35);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Окно оплаты";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// continueButton
			// 
			this.continueButton.Location = new System.Drawing.Point(617, 410);
			this.continueButton.Name = "continueButton";
			this.continueButton.Size = new System.Drawing.Size(259, 72);
			this.continueButton.TabIndex = 1;
			this.continueButton.Text = "Продолжить";
			this.continueButton.UseVisualStyleBackColor = true;
			this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(13, 410);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(259, 72);
			this.backButton.TabIndex = 2;
			this.backButton.Text = "Отмена";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(221, 64);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(466, 340);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// PaymentWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 495);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.continueButton);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "PaymentWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Оплата";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentWindow_FormClosing);
			this.Load += new System.EventHandler(this.PaymentWindow_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button continueButton;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}