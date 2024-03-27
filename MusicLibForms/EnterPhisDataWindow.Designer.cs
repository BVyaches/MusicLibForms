namespace MusicLibForms
{
	partial class EnterPhisDataWindow
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
			this.cancelButton = new System.Windows.Forms.Button();
			this.enterButton = new System.Windows.Forms.Button();
			this.addressBox = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.birthDate = new System.Windows.Forms.DateTimePicker();
			this.passportDate = new System.Windows.Forms.DateTimePicker();
			this.passportText = new System.Windows.Forms.MaskedTextBox();
			this.innBox = new System.Windows.Forms.MaskedTextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(60, 251);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(346, 57);
			this.cancelButton.TabIndex = 31;
			this.cancelButton.Text = "Назад";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// enterButton
			// 
			this.enterButton.Location = new System.Drawing.Point(450, 251);
			this.enterButton.Name = "enterButton";
			this.enterButton.Size = new System.Drawing.Size(398, 57);
			this.enterButton.TabIndex = 30;
			this.enterButton.Text = "Данные верны, перейти к оплате";
			this.enterButton.UseVisualStyleBackColor = true;
			this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
			// 
			// addressBox
			// 
			this.addressBox.Location = new System.Drawing.Point(450, 188);
			this.addressBox.Name = "addressBox";
			this.addressBox.Size = new System.Drawing.Size(405, 28);
			this.addressBox.TabIndex = 29;
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(60, 188);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(345, 28);
			this.textBox13.TabIndex = 28;
			this.textBox13.Text = "Адрес проживания";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(60, 154);
			this.textBox11.Name = "textBox11";
			this.textBox11.ReadOnly = true;
			this.textBox11.Size = new System.Drawing.Size(345, 28);
			this.textBox11.TabIndex = 26;
			this.textBox11.Text = "Дата выдачи";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(60, 120);
			this.textBox9.Name = "textBox9";
			this.textBox9.ReadOnly = true;
			this.textBox9.Size = new System.Drawing.Size(345, 28);
			this.textBox9.TabIndex = 24;
			this.textBox9.Text = "Серия и номер паспорта";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(60, 86);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(345, 28);
			this.textBox7.TabIndex = 22;
			this.textBox7.Text = "Дата рождения";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(60, 52);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(345, 28);
			this.textBox5.TabIndex = 20;
			this.textBox5.Text = "ИНН";
			// 
			// birthDate
			// 
			this.birthDate.Location = new System.Drawing.Point(451, 86);
			this.birthDate.MaxDate = new System.DateTime(2006, 12, 30, 0, 0, 0, 0);
			this.birthDate.Name = "birthDate";
			this.birthDate.Size = new System.Drawing.Size(404, 28);
			this.birthDate.TabIndex = 32;
			this.birthDate.Value = new System.DateTime(2006, 12, 30, 0, 0, 0, 0);
			// 
			// passportDate
			// 
			this.passportDate.Location = new System.Drawing.Point(451, 154);
			this.passportDate.MaxDate = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
			this.passportDate.Name = "passportDate";
			this.passportDate.Size = new System.Drawing.Size(404, 28);
			this.passportDate.TabIndex = 33;
			this.passportDate.Value = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
			this.passportDate.ValueChanged += new System.EventHandler(this.passportDate_ValueChanged);
			// 
			// passportText
			// 
			this.passportText.Location = new System.Drawing.Point(451, 120);
			this.passportText.Mask = "00 00-000000";
			this.passportText.Name = "passportText";
			this.passportText.Size = new System.Drawing.Size(121, 28);
			this.passportText.TabIndex = 37;
			// 
			// innBox
			// 
			this.innBox.Location = new System.Drawing.Point(450, 52);
			this.innBox.Mask = "000000000000";
			this.innBox.Name = "innBox";
			this.innBox.Size = new System.Drawing.Size(121, 28);
			this.innBox.TabIndex = 38;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(60, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(795, 30);
			this.textBox1.TabIndex = 39;
			this.textBox1.Text = "Пожалуйста, введите данные для автоматического заполнения договора";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// EnterPhisDataWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 379);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.innBox);
			this.Controls.Add(this.passportText);
			this.Controls.Add(this.passportDate);
			this.Controls.Add(this.birthDate);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.enterButton);
			this.Controls.Add(this.addressBox);
			this.Controls.Add(this.textBox13);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox5);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "EnterPhisDataWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Данные для договора";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnterPhisDataWindow_FormClosing);
			this.Load += new System.EventHandler(this.EnterPhisDataWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button enterButton;
		private System.Windows.Forms.TextBox addressBox;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.DateTimePicker birthDate;
		private System.Windows.Forms.DateTimePicker passportDate;
		private System.Windows.Forms.MaskedTextBox passportText;
		private System.Windows.Forms.MaskedTextBox innBox;
		private System.Windows.Forms.TextBox textBox1;
	}
}