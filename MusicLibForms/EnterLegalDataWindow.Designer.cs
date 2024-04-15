namespace MusicLibForms
{
	partial class EnterLegalDataWindow
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
			this.addressBox = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.BankBox = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.enterButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.compNameBox = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.innBox = new System.Windows.Forms.MaskedTextBox();
			this.bikBox = new System.Windows.Forms.MaskedTextBox();
			this.bankAccBox = new System.Windows.Forms.MaskedTextBox();
			this.kppBox = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(50, 83);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(345, 24);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Юридический адрес";
			// 
			// addressBox
			// 
			this.addressBox.Location = new System.Drawing.Point(439, 83);
			this.addressBox.Name = "addressBox";
			this.addressBox.Size = new System.Drawing.Size(405, 24);
			this.addressBox.TabIndex = 1;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(50, 117);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(345, 24);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "ИНН";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(50, 151);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(345, 24);
			this.textBox7.TabIndex = 6;
			this.textBox7.Text = "КПП";
			// 
			// BankBox
			// 
			this.BankBox.Location = new System.Drawing.Point(439, 185);
			this.BankBox.Name = "BankBox";
			this.BankBox.Size = new System.Drawing.Size(405, 24);
			this.BankBox.TabIndex = 9;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(50, 185);
			this.textBox9.Name = "textBox9";
			this.textBox9.ReadOnly = true;
			this.textBox9.Size = new System.Drawing.Size(345, 24);
			this.textBox9.TabIndex = 8;
			this.textBox9.Text = "Банк";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(50, 219);
			this.textBox11.Name = "textBox11";
			this.textBox11.ReadOnly = true;
			this.textBox11.Size = new System.Drawing.Size(345, 24);
			this.textBox11.TabIndex = 10;
			this.textBox11.Text = "Расчетный счет";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(49, 253);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(345, 24);
			this.textBox13.TabIndex = 12;
			this.textBox13.Text = "БИК";
			this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
			// 
			// enterButton
			// 
			this.enterButton.Location = new System.Drawing.Point(440, 304);
			this.enterButton.Name = "enterButton";
			this.enterButton.Size = new System.Drawing.Size(405, 57);
			this.enterButton.TabIndex = 14;
			this.enterButton.Text = "Данные верны, перейти к оплате";
			this.enterButton.UseVisualStyleBackColor = true;
			this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(50, 304);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(346, 57);
			this.cancelButton.TabIndex = 15;
			this.cancelButton.Text = "Назад";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// compNameBox
			// 
			this.compNameBox.Location = new System.Drawing.Point(440, 48);
			this.compNameBox.Name = "compNameBox";
			this.compNameBox.Size = new System.Drawing.Size(405, 24);
			this.compNameBox.TabIndex = 17;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(49, 49);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(345, 24);
			this.textBox3.TabIndex = 16;
			this.textBox3.Text = "Название организации";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(49, 12);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(796, 26);
			this.textBox2.TabIndex = 40;
			this.textBox2.Text = "Пожалуйста, введите данные для автоматического заполнения договора";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// innBox
			// 
			this.innBox.Location = new System.Drawing.Point(440, 117);
			this.innBox.Mask = "0000000000";
			this.innBox.Name = "innBox";
			this.innBox.Size = new System.Drawing.Size(87, 24);
			this.innBox.TabIndex = 41;
			this.innBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.innBox_MaskInputRejected);
			// 
			// bikBox
			// 
			this.bikBox.Location = new System.Drawing.Point(439, 253);
			this.bikBox.Mask = "000000000";
			this.bikBox.Name = "bikBox";
			this.bikBox.Size = new System.Drawing.Size(80, 24);
			this.bikBox.TabIndex = 42;
			// 
			// bankAccBox
			// 
			this.bankAccBox.Location = new System.Drawing.Point(440, 219);
			this.bankAccBox.Mask = "00000000000000000000";
			this.bankAccBox.Name = "bankAccBox";
			this.bankAccBox.Size = new System.Drawing.Size(169, 24);
			this.bankAccBox.TabIndex = 43;
			// 
			// kppBox
			// 
			this.kppBox.Location = new System.Drawing.Point(440, 155);
			this.kppBox.Mask = "000000000";
			this.kppBox.Name = "kppBox";
			this.kppBox.Size = new System.Drawing.Size(79, 24);
			this.kppBox.TabIndex = 44;
			// 
			// EnterLegalDataWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 379);
			this.Controls.Add(this.kppBox);
			this.Controls.Add(this.bankAccBox);
			this.Controls.Add(this.bikBox);
			this.Controls.Add(this.innBox);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.compNameBox);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.enterButton);
			this.Controls.Add(this.textBox13);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.BankBox);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.addressBox);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "EnterLegalDataWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Данные для договора";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnterLegalDataWindow_FormClosing);
			this.Load += new System.EventHandler(this.EnterLegalDataWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox addressBox;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox BankBox;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Button enterButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.TextBox compNameBox;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.MaskedTextBox innBox;
		private System.Windows.Forms.MaskedTextBox bikBox;
		private System.Windows.Forms.MaskedTextBox bankAccBox;
		private System.Windows.Forms.MaskedTextBox kppBox;
	}
}