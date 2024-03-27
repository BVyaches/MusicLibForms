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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.continueButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(241, 67);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(466, 28);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Окно оплаты";
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
			// PaymentWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 495);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.continueButton);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "PaymentWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PaymentWindow";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentWindow_FormClosing);
			this.Load += new System.EventHandler(this.PaymentWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button continueButton;
		private System.Windows.Forms.Button backButton;
	}
}