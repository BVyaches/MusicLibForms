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
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.priceText = new System.Windows.Forms.TextBox();
			this.nameText = new System.Windows.Forms.TextBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.composerBox = new System.Windows.Forms.ComboBox();
			this.labelBox = new System.Windows.Forms.ComboBox();
			this.UpdateGroup = new System.Windows.Forms.GroupBox();
			this.updateIsrcText = new System.Windows.Forms.MaskedTextBox();
			this.HideUpdateButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.updateLabelBox = new System.Windows.Forms.ComboBox();
			this.updateComposerBox = new System.Windows.Forms.ComboBox();
			this.updatePriceText = new System.Windows.Forms.TextBox();
			this.updateNameText = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.updateGenresBox = new System.Windows.Forms.ListBox();
			this.isrcText = new System.Windows.Forms.MaskedTextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.loadedFileBox = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.playerPanel = new System.Windows.Forms.Panel();
			this.songNameBox = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.UpdateGroup.SuspendLayout();
			this.playerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(13, 3);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.Size = new System.Drawing.Size(1141, 394);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(25, 762);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(174, 66);
			this.button1.TabIndex = 1;
			this.button1.Text = "Выйти";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// GenresBox
			// 
			this.GenresBox.FormattingEnabled = true;
			this.GenresBox.ItemHeight = 22;
			this.GenresBox.Location = new System.Drawing.Point(206, 592);
			this.GenresBox.Name = "GenresBox";
			this.GenresBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.GenresBox.Size = new System.Drawing.Size(146, 70);
			this.GenresBox.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(25, 421);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(146, 28);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "Название";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(25, 455);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(146, 28);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "Исполнитель";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(25, 489);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(146, 28);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "Лейбл";
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(25, 524);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(146, 28);
			this.textBox5.TabIndex = 7;
			this.textBox5.Text = "ISRC";
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(25, 558);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(146, 28);
			this.textBox6.TabIndex = 8;
			this.textBox6.Text = "Цена";
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(25, 592);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(146, 28);
			this.textBox7.TabIndex = 9;
			this.textBox7.Text = "Жанры";
			this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
			// 
			// priceText
			// 
			this.priceText.Location = new System.Drawing.Point(206, 558);
			this.priceText.Name = "priceText";
			this.priceText.Size = new System.Drawing.Size(146, 28);
			this.priceText.TabIndex = 15;
			// 
			// nameText
			// 
			this.nameText.Location = new System.Drawing.Point(206, 421);
			this.nameText.Name = "nameText";
			this.nameText.Size = new System.Drawing.Size(146, 28);
			this.nameText.TabIndex = 10;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(377, 421);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(161, 62);
			this.AddButton.TabIndex = 16;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// composerBox
			// 
			this.composerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.composerBox.FormattingEnabled = true;
			this.composerBox.Location = new System.Drawing.Point(207, 453);
			this.composerBox.Name = "composerBox";
			this.composerBox.Size = new System.Drawing.Size(146, 30);
			this.composerBox.TabIndex = 17;
			// 
			// labelBox
			// 
			this.labelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.labelBox.FormattingEnabled = true;
			this.labelBox.Location = new System.Drawing.Point(206, 489);
			this.labelBox.Name = "labelBox";
			this.labelBox.Size = new System.Drawing.Size(146, 30);
			this.labelBox.TabIndex = 18;
			// 
			// UpdateGroup
			// 
			this.UpdateGroup.BackColor = System.Drawing.SystemColors.ControlLight;
			this.UpdateGroup.Controls.Add(this.updateIsrcText);
			this.UpdateGroup.Controls.Add(this.HideUpdateButton);
			this.UpdateGroup.Controls.Add(this.UpdateButton);
			this.UpdateGroup.Controls.Add(this.updateLabelBox);
			this.UpdateGroup.Controls.Add(this.updateComposerBox);
			this.UpdateGroup.Controls.Add(this.updatePriceText);
			this.UpdateGroup.Controls.Add(this.updateNameText);
			this.UpdateGroup.Controls.Add(this.textBox11);
			this.UpdateGroup.Controls.Add(this.textBox12);
			this.UpdateGroup.Controls.Add(this.textBox13);
			this.UpdateGroup.Controls.Add(this.textBox15);
			this.UpdateGroup.Controls.Add(this.textBox16);
			this.UpdateGroup.Controls.Add(this.textBox17);
			this.UpdateGroup.Controls.Add(this.updateGenresBox);
			this.UpdateGroup.Location = new System.Drawing.Point(563, 410);
			this.UpdateGroup.Name = "UpdateGroup";
			this.UpdateGroup.Size = new System.Drawing.Size(590, 262);
			this.UpdateGroup.TabIndex = 20;
			this.UpdateGroup.TabStop = false;
			// 
			// updateIsrcText
			// 
			this.updateIsrcText.Location = new System.Drawing.Point(203, 115);
			this.updateIsrcText.Mask = "LL-LLL-00-00000";
			this.updateIsrcText.Name = "updateIsrcText";
			this.updateIsrcText.Size = new System.Drawing.Size(146, 28);
			this.updateIsrcText.TabIndex = 36;
			// 
			// HideUpdateButton
			// 
			this.HideUpdateButton.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.HideUpdateButton.Location = new System.Drawing.Point(375, 148);
			this.HideUpdateButton.Name = "HideUpdateButton";
			this.HideUpdateButton.Size = new System.Drawing.Size(209, 104);
			this.HideUpdateButton.TabIndex = 35;
			this.HideUpdateButton.Text = "Отменить";
			this.HideUpdateButton.UseVisualStyleBackColor = false;
			this.HideUpdateButton.Click += new System.EventHandler(this.HideUpdateButton_Click);
			// 
			// UpdateButton
			// 
			this.UpdateButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.UpdateButton.Location = new System.Drawing.Point(374, 11);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(209, 132);
			this.UpdateButton.TabIndex = 34;
			this.UpdateButton.Text = "Изменить";
			this.UpdateButton.UseVisualStyleBackColor = false;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// updateLabelBox
			// 
			this.updateLabelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.updateLabelBox.FormattingEnabled = true;
			this.updateLabelBox.Location = new System.Drawing.Point(203, 79);
			this.updateLabelBox.Name = "updateLabelBox";
			this.updateLabelBox.Size = new System.Drawing.Size(146, 30);
			this.updateLabelBox.TabIndex = 32;
			// 
			// updateComposerBox
			// 
			this.updateComposerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.updateComposerBox.FormattingEnabled = true;
			this.updateComposerBox.Location = new System.Drawing.Point(203, 45);
			this.updateComposerBox.Name = "updateComposerBox";
			this.updateComposerBox.Size = new System.Drawing.Size(146, 30);
			this.updateComposerBox.TabIndex = 31;
			// 
			// updatePriceText
			// 
			this.updatePriceText.Location = new System.Drawing.Point(203, 148);
			this.updatePriceText.Name = "updatePriceText";
			this.updatePriceText.Size = new System.Drawing.Size(146, 28);
			this.updatePriceText.TabIndex = 30;
			// 
			// updateNameText
			// 
			this.updateNameText.Location = new System.Drawing.Point(203, 11);
			this.updateNameText.Name = "updateNameText";
			this.updateNameText.Size = new System.Drawing.Size(146, 28);
			this.updateNameText.TabIndex = 28;
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(18, 183);
			this.textBox11.Name = "textBox11";
			this.textBox11.ReadOnly = true;
			this.textBox11.Size = new System.Drawing.Size(146, 28);
			this.textBox11.TabIndex = 27;
			this.textBox11.Text = "Жанры";
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(18, 149);
			this.textBox12.Name = "textBox12";
			this.textBox12.ReadOnly = true;
			this.textBox12.Size = new System.Drawing.Size(146, 28);
			this.textBox12.TabIndex = 26;
			this.textBox12.Text = "Цена";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(18, 115);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(146, 28);
			this.textBox13.TabIndex = 25;
			this.textBox13.Text = "ISRC";
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(18, 79);
			this.textBox15.Name = "textBox15";
			this.textBox15.ReadOnly = true;
			this.textBox15.Size = new System.Drawing.Size(146, 28);
			this.textBox15.TabIndex = 23;
			this.textBox15.Text = "Лейбл";
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(18, 45);
			this.textBox16.Name = "textBox16";
			this.textBox16.ReadOnly = true;
			this.textBox16.Size = new System.Drawing.Size(146, 28);
			this.textBox16.TabIndex = 22;
			this.textBox16.Text = "Исполнитель";
			// 
			// textBox17
			// 
			this.textBox17.Location = new System.Drawing.Point(18, 11);
			this.textBox17.Name = "textBox17";
			this.textBox17.ReadOnly = true;
			this.textBox17.Size = new System.Drawing.Size(146, 28);
			this.textBox17.TabIndex = 21;
			this.textBox17.Text = "Название";
			// 
			// updateGenresBox
			// 
			this.updateGenresBox.FormattingEnabled = true;
			this.updateGenresBox.ItemHeight = 22;
			this.updateGenresBox.Location = new System.Drawing.Point(203, 182);
			this.updateGenresBox.Name = "updateGenresBox";
			this.updateGenresBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.updateGenresBox.Size = new System.Drawing.Size(146, 70);
			this.updateGenresBox.TabIndex = 20;
			// 
			// isrcText
			// 
			this.isrcText.Location = new System.Drawing.Point(206, 525);
			this.isrcText.Mask = "LL-LLL-00-00000";
			this.isrcText.Name = "isrcText";
			this.isrcText.Size = new System.Drawing.Size(146, 28);
			this.isrcText.TabIndex = 21;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(25, 668);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(328, 41);
			this.button2.TabIndex = 22;
			this.button2.Text = "Загрузить .mp3 файл";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// loadedFileBox
			// 
			this.loadedFileBox.Location = new System.Drawing.Point(25, 717);
			this.loadedFileBox.Name = "loadedFileBox";
			this.loadedFileBox.ReadOnly = true;
			this.loadedFileBox.Size = new System.Drawing.Size(327, 28);
			this.loadedFileBox.TabIndex = 23;
			this.loadedFileBox.Text = "Файл не загружен!";
			this.loadedFileBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// playerPanel
			// 
			this.playerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.playerPanel.Controls.Add(this.songNameBox);
			this.playerPanel.Controls.Add(this.textBox8);
			this.playerPanel.Controls.Add(this.button3);
			this.playerPanel.Location = new System.Drawing.Point(377, 739);
			this.playerPanel.Name = "playerPanel";
			this.playerPanel.Size = new System.Drawing.Size(331, 89);
			this.playerPanel.TabIndex = 24;
			this.playerPanel.Visible = false;
			// 
			// songNameBox
			// 
			this.songNameBox.Location = new System.Drawing.Point(4, 40);
			this.songNameBox.Multiline = true;
			this.songNameBox.Name = "songNameBox";
			this.songNameBox.ReadOnly = true;
			this.songNameBox.Size = new System.Drawing.Size(241, 43);
			this.songNameBox.TabIndex = 5;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(4, 4);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(146, 28);
			this.textBox8.TabIndex = 0;
			this.textBox8.Text = "Сейчас играет:";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(261, 40);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(44, 43);
			this.button3.TabIndex = 4;
			this.button3.Text = "█";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// SongsCRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1163, 840);
			this.Controls.Add(this.playerPanel);
			this.Controls.Add(this.loadedFileBox);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.isrcText);
			this.Controls.Add(this.UpdateGroup);
			this.Controls.Add(this.labelBox);
			this.Controls.Add(this.composerBox);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.priceText);
			this.Controls.Add(this.nameText);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.GenresBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "SongsCRUD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактирование песен";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SongsCRUD_FormClosing);
			this.Load += new System.EventHandler(this.SongsCRUD_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.UpdateGroup.ResumeLayout(false);
			this.UpdateGroup.PerformLayout();
			this.playerPanel.ResumeLayout(false);
			this.playerPanel.PerformLayout();
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
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox priceText;
		private System.Windows.Forms.TextBox nameText;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.ComboBox composerBox;
		private System.Windows.Forms.ComboBox labelBox;
		private System.Windows.Forms.GroupBox UpdateGroup;
		private System.Windows.Forms.ComboBox updateLabelBox;
		private System.Windows.Forms.ComboBox updateComposerBox;
		private System.Windows.Forms.TextBox updatePriceText;
		private System.Windows.Forms.TextBox updateNameText;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.ListBox updateGenresBox;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Button HideUpdateButton;
		private System.Windows.Forms.MaskedTextBox isrcText;
		private System.Windows.Forms.MaskedTextBox updateIsrcText;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox loadedFileBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel playerPanel;
		private System.Windows.Forms.TextBox songNameBox;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Button button3;
	}
}