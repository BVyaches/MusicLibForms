namespace MusicLibForms
{
	partial class RegisterWindow
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
			this.backButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.repeatPassBox = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.isLegalBox = new System.Windows.Forms.CheckBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.emailBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(240, 395);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(170, 43);
			this.backButton.TabIndex = 13;
			this.backButton.Text = "Назад";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(451, 395);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(168, 43);
			this.loginButton.TabIndex = 12;
			this.loginButton.Text = "Регистрация";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(451, 227);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(213, 28);
			this.passwordBox.TabIndex = 11;
			this.passwordBox.UseSystemPasswordChar = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(224, 227);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(186, 28);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "Пароль";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(224, 79);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(186, 28);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "Логин";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(451, 79);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(213, 28);
			this.loginBox.TabIndex = 8;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(224, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(440, 35);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "Регистрация";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// repeatPassBox
			// 
			this.repeatPassBox.Location = new System.Drawing.Point(451, 261);
			this.repeatPassBox.Name = "repeatPassBox";
			this.repeatPassBox.Size = new System.Drawing.Size(213, 28);
			this.repeatPassBox.TabIndex = 15;
			this.repeatPassBox.UseSystemPasswordChar = true;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(224, 261);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(186, 28);
			this.textBox5.TabIndex = 14;
			this.textBox5.Text = "Повторите пароль";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(224, 113);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(186, 28);
			this.textBox6.TabIndex = 16;
			this.textBox6.Text = "ФИО";
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(451, 113);
			this.nameBox.Multiline = true;
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(213, 107);
			this.nameBox.TabIndex = 17;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(224, 295);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(186, 50);
			this.textBox4.TabIndex = 18;
			this.textBox4.Text = "Вы представитель Юр Лица?";
			// 
			// isLegalBox
			// 
			this.isLegalBox.AutoSize = true;
			this.isLegalBox.Location = new System.Drawing.Point(451, 307);
			this.isLegalBox.Name = "isLegalBox";
			this.isLegalBox.Size = new System.Drawing.Size(60, 26);
			this.isLegalBox.TabIndex = 19;
			this.isLegalBox.Text = "Да";
			this.isLegalBox.UseVisualStyleBackColor = true;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(225, 351);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(186, 28);
			this.textBox7.TabIndex = 20;
			this.textBox7.Text = "Электронная почта";
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(451, 351);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(213, 28);
			this.emailBox.TabIndex = 21;
			// 
			// RegisterWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 448);
			this.Controls.Add(this.emailBox);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.isLegalBox);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.repeatPassBox);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "RegisterWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Регистрация";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterWindow_FormClosing);
			this.Load += new System.EventHandler(this.RegisterWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox repeatPassBox;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.CheckBox isLegalBox;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox emailBox;
	}
}