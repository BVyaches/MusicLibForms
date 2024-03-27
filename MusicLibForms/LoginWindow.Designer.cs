namespace MusicLibForms
{
	partial class LoginWindow
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
			this.loginBox = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(140, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(440, 35);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Вход в систему";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(316, 73);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(213, 28);
			this.loginBox.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(186, 73);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(111, 28);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "Логин";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(186, 107);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(111, 28);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "Пароль";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(316, 107);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(213, 28);
			this.passwordBox.TabIndex = 4;
			this.passwordBox.UseSystemPasswordChar = true;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(371, 154);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(168, 43);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "Войти";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(173, 154);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(170, 43);
			this.backButton.TabIndex = 6;
			this.backButton.Text = "Назад";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// LoginWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 239);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "LoginWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вход";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginWindow_FormClosing);
			this.Load += new System.EventHandler(this.LoginWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button backButton;
	}
}