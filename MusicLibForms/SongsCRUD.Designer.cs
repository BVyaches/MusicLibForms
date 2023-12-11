namespace MusicLibForms
{
	partial class SongsCRUD
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.GenresBox = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.priceText = new System.Windows.Forms.TextBox();
			this.nameText = new System.Windows.Forms.TextBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.composerBox = new System.Windows.Forms.ComboBox();
			this.labelBox = new System.Windows.Forms.ComboBox();
			this.timePicker = new System.Windows.Forms.DateTimePicker();
			this.UpdateGroup = new System.Windows.Forms.GroupBox();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.updateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.updateLabelBox = new System.Windows.Forms.ComboBox();
			this.updateComposerBox = new System.Windows.Forms.ComboBox();
			this.updatePriceText = new System.Windows.Forms.TextBox();
			this.updateNameText = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.updateGenresBox = new System.Windows.Forms.ListBox();
			this.HideUpdateButton = new System.Windows.Forms.Button();
			this.isrcText = new System.Windows.Forms.MaskedTextBox();
			this.updateIsrcText = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.UpdateGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 3);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.Size = new System.Drawing.Size(1276, 476);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1131, 823);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 60);
			this.button1.TabIndex = 1;
			this.button1.Text = "В меню";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// GenresBox
			// 
			this.GenresBox.FormattingEnabled = true;
			this.GenresBox.ItemHeight = 20;
			this.GenresBox.Location = new System.Drawing.Point(216, 775);
			this.GenresBox.Name = "GenresBox";
			this.GenresBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.GenresBox.Size = new System.Drawing.Size(132, 84);
			this.GenresBox.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(53, 495);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(132, 26);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "Название";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(53, 541);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(132, 26);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "Композитор";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(53, 585);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(132, 26);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "Лейбл";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(53, 636);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(132, 26);
			this.textBox4.TabIndex = 6;
			this.textBox4.Text = "Длительность";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(53, 682);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(132, 26);
			this.textBox5.TabIndex = 7;
			this.textBox5.Text = "ISRC";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(53, 726);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(132, 26);
			this.textBox6.TabIndex = 8;
			this.textBox6.Text = "Цена";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(53, 775);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(132, 26);
			this.textBox7.TabIndex = 9;
			this.textBox7.Text = "Жанры";
			// 
			// priceText
			// 
			this.priceText.Location = new System.Drawing.Point(216, 726);
			this.priceText.Name = "priceText";
			this.priceText.Size = new System.Drawing.Size(132, 26);
			this.priceText.TabIndex = 15;
			// 
			// nameText
			// 
			this.nameText.Location = new System.Drawing.Point(216, 495);
			this.nameText.Name = "nameText";
			this.nameText.Size = new System.Drawing.Size(132, 26);
			this.nameText.TabIndex = 10;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(400, 495);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(177, 68);
			this.AddButton.TabIndex = 16;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// composerBox
			// 
			this.composerBox.FormattingEnabled = true;
			this.composerBox.Location = new System.Drawing.Point(216, 539);
			this.composerBox.Name = "composerBox";
			this.composerBox.Size = new System.Drawing.Size(132, 28);
			this.composerBox.TabIndex = 17;
			// 
			// labelBox
			// 
			this.labelBox.FormattingEnabled = true;
			this.labelBox.Location = new System.Drawing.Point(216, 583);
			this.labelBox.Name = "labelBox";
			this.labelBox.Size = new System.Drawing.Size(132, 28);
			this.labelBox.TabIndex = 18;
			// 
			// timePicker
			// 
			this.timePicker.CustomFormat = "HH:MM:SS";
			this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.timePicker.Location = new System.Drawing.Point(216, 636);
			this.timePicker.Name = "timePicker";
			this.timePicker.ShowUpDown = true;
			this.timePicker.Size = new System.Drawing.Size(132, 26);
			this.timePicker.TabIndex = 19;
			this.timePicker.Value = new System.DateTime(2023, 12, 10, 0, 0, 0, 0);
			// 
			// UpdateGroup
			// 
			this.UpdateGroup.BackColor = System.Drawing.SystemColors.ControlLight;
			this.UpdateGroup.Controls.Add(this.updateIsrcText);
			this.UpdateGroup.Controls.Add(this.HideUpdateButton);
			this.UpdateGroup.Controls.Add(this.UpdateButton);
			this.UpdateGroup.Controls.Add(this.updateTimePicker);
			this.UpdateGroup.Controls.Add(this.updateLabelBox);
			this.UpdateGroup.Controls.Add(this.updateComposerBox);
			this.UpdateGroup.Controls.Add(this.updatePriceText);
			this.UpdateGroup.Controls.Add(this.updateNameText);
			this.UpdateGroup.Controls.Add(this.textBox11);
			this.UpdateGroup.Controls.Add(this.textBox12);
			this.UpdateGroup.Controls.Add(this.textBox13);
			this.UpdateGroup.Controls.Add(this.textBox14);
			this.UpdateGroup.Controls.Add(this.textBox15);
			this.UpdateGroup.Controls.Add(this.textBox16);
			this.UpdateGroup.Controls.Add(this.textBox17);
			this.UpdateGroup.Controls.Add(this.updateGenresBox);
			this.UpdateGroup.Location = new System.Drawing.Point(594, 485);
			this.UpdateGroup.Name = "UpdateGroup";
			this.UpdateGroup.Size = new System.Drawing.Size(531, 398);
			this.UpdateGroup.TabIndex = 20;
			this.UpdateGroup.TabStop = false;
			// 
			// UpdateButton
			// 
			this.UpdateButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.UpdateButton.Location = new System.Drawing.Point(337, 10);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(188, 213);
			this.UpdateButton.TabIndex = 34;
			this.UpdateButton.Text = "Изменить";
			this.UpdateButton.UseVisualStyleBackColor = false;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// updateTimePicker
			// 
			this.updateTimePicker.CustomFormat = "HH:MM:SS";
			this.updateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.updateTimePicker.Location = new System.Drawing.Point(183, 151);
			this.updateTimePicker.Name = "updateTimePicker";
			this.updateTimePicker.ShowUpDown = true;
			this.updateTimePicker.Size = new System.Drawing.Size(132, 26);
			this.updateTimePicker.TabIndex = 33;
			this.updateTimePicker.Value = new System.DateTime(2023, 12, 10, 0, 0, 0, 0);
			// 
			// updateLabelBox
			// 
			this.updateLabelBox.FormattingEnabled = true;
			this.updateLabelBox.Location = new System.Drawing.Point(183, 98);
			this.updateLabelBox.Name = "updateLabelBox";
			this.updateLabelBox.Size = new System.Drawing.Size(132, 28);
			this.updateLabelBox.TabIndex = 32;
			// 
			// updateComposerBox
			// 
			this.updateComposerBox.FormattingEnabled = true;
			this.updateComposerBox.Location = new System.Drawing.Point(183, 54);
			this.updateComposerBox.Name = "updateComposerBox";
			this.updateComposerBox.Size = new System.Drawing.Size(132, 28);
			this.updateComposerBox.TabIndex = 31;
			// 
			// updatePriceText
			// 
			this.updatePriceText.Location = new System.Drawing.Point(183, 241);
			this.updatePriceText.Name = "updatePriceText";
			this.updatePriceText.Size = new System.Drawing.Size(132, 26);
			this.updatePriceText.TabIndex = 30;
			// 
			// updateNameText
			// 
			this.updateNameText.Location = new System.Drawing.Point(183, 10);
			this.updateNameText.Name = "updateNameText";
			this.updateNameText.Size = new System.Drawing.Size(132, 26);
			this.updateNameText.TabIndex = 28;
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(16, 290);
			this.textBox11.Name = "textBox11";
			this.textBox11.ReadOnly = true;
			this.textBox11.Size = new System.Drawing.Size(132, 26);
			this.textBox11.TabIndex = 27;
			this.textBox11.Text = "Жанры";
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(16, 241);
			this.textBox12.Name = "textBox12";
			this.textBox12.ReadOnly = true;
			this.textBox12.Size = new System.Drawing.Size(132, 26);
			this.textBox12.TabIndex = 26;
			this.textBox12.Text = "Цена";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(16, 197);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(132, 26);
			this.textBox13.TabIndex = 25;
			this.textBox13.Text = "ISRC";
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(16, 151);
			this.textBox14.Name = "textBox14";
			this.textBox14.ReadOnly = true;
			this.textBox14.Size = new System.Drawing.Size(132, 26);
			this.textBox14.TabIndex = 24;
			this.textBox14.Text = "Длительность";
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(16, 100);
			this.textBox15.Name = "textBox15";
			this.textBox15.ReadOnly = true;
			this.textBox15.Size = new System.Drawing.Size(132, 26);
			this.textBox15.TabIndex = 23;
			this.textBox15.Text = "Лейбл";
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(16, 56);
			this.textBox16.Name = "textBox16";
			this.textBox16.ReadOnly = true;
			this.textBox16.Size = new System.Drawing.Size(132, 26);
			this.textBox16.TabIndex = 22;
			this.textBox16.Text = "Композитор";
			// 
			// textBox17
			// 
			this.textBox17.Location = new System.Drawing.Point(16, 10);
			this.textBox17.Name = "textBox17";
			this.textBox17.ReadOnly = true;
			this.textBox17.Size = new System.Drawing.Size(132, 26);
			this.textBox17.TabIndex = 21;
			this.textBox17.Text = "Название";
			// 
			// updateGenresBox
			// 
			this.updateGenresBox.FormattingEnabled = true;
			this.updateGenresBox.ItemHeight = 20;
			this.updateGenresBox.Location = new System.Drawing.Point(183, 290);
			this.updateGenresBox.Name = "updateGenresBox";
			this.updateGenresBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.updateGenresBox.Size = new System.Drawing.Size(132, 84);
			this.updateGenresBox.TabIndex = 20;
			// 
			// HideUpdateButton
			// 
			this.HideUpdateButton.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.HideUpdateButton.Location = new System.Drawing.Point(337, 229);
			this.HideUpdateButton.Name = "HideUpdateButton";
			this.HideUpdateButton.Size = new System.Drawing.Size(188, 145);
			this.HideUpdateButton.TabIndex = 35;
			this.HideUpdateButton.Text = "Отменить";
			this.HideUpdateButton.UseVisualStyleBackColor = false;
			this.HideUpdateButton.Click += new System.EventHandler(this.HideUpdateButton_Click);
			// 
			// isrcText
			// 
			this.isrcText.Location = new System.Drawing.Point(216, 682);
			this.isrcText.Mask = "LL-LLL-00-00000";
			this.isrcText.Name = "isrcText";
			this.isrcText.Size = new System.Drawing.Size(132, 26);
			this.isrcText.TabIndex = 21;
			// 
			// updateIsrcText
			// 
			this.updateIsrcText.Location = new System.Drawing.Point(183, 197);
			this.updateIsrcText.Mask = "LL-LLL-00-00000";
			this.updateIsrcText.Name = "updateIsrcText";
			this.updateIsrcText.Size = new System.Drawing.Size(132, 26);
			this.updateIsrcText.TabIndex = 36;
			// 
			// SongsCRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1300, 905);
			this.Controls.Add(this.isrcText);
			this.Controls.Add(this.UpdateGroup);
			this.Controls.Add(this.timePicker);
			this.Controls.Add(this.labelBox);
			this.Controls.Add(this.composerBox);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.priceText);
			this.Controls.Add(this.nameText);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.GenresBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView);
			this.Name = "SongsCRUD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SongsCRUD_FormClosing);
			this.Load += new System.EventHandler(this.SongsCRUD_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.UpdateGroup.ResumeLayout(false);
			this.UpdateGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox GenresBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox priceText;
		private System.Windows.Forms.TextBox nameText;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.ComboBox composerBox;
		private System.Windows.Forms.ComboBox labelBox;
		private System.Windows.Forms.DateTimePicker timePicker;
		private System.Windows.Forms.GroupBox UpdateGroup;
		private System.Windows.Forms.DateTimePicker updateTimePicker;
		private System.Windows.Forms.ComboBox updateLabelBox;
		private System.Windows.Forms.ComboBox updateComposerBox;
		private System.Windows.Forms.TextBox updatePriceText;
		private System.Windows.Forms.TextBox updateNameText;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.ListBox updateGenresBox;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Button HideUpdateButton;
		private System.Windows.Forms.MaskedTextBox isrcText;
		private System.Windows.Forms.MaskedTextBox updateIsrcText;
	}
}