namespace MusicLibForms
{
	partial class BuySongWindow
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.menuButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.playerPanel = new System.Windows.Forms.Panel();
			this.songNameBox = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.composerFilter = new System.Windows.Forms.TextBox();
			this.genresFilter = new System.Windows.Forms.TextBox();
			this.songFilter = new System.Windows.Forms.TextBox();
			this.historyButton = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.playerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 52);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1321, 522);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// menuButton
			// 
			this.menuButton.Location = new System.Drawing.Point(12, 697);
			this.menuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.menuButton.Name = "menuButton";
			this.menuButton.Size = new System.Drawing.Size(232, 60);
			this.menuButton.TabIndex = 3;
			this.menuButton.Text = "Выйти";
			this.menuButton.UseVisualStyleBackColor = true;
			this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(339, 37);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 40);
			this.button1.TabIndex = 4;
			this.button1.Text = "█";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// playerPanel
			// 
			this.playerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.playerPanel.Controls.Add(this.songNameBox);
			this.playerPanel.Controls.Add(this.textBox1);
			this.playerPanel.Controls.Add(this.button1);
			this.playerPanel.Location = new System.Drawing.Point(13, 582);
			this.playerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.playerPanel.Name = "playerPanel";
			this.playerPanel.Size = new System.Drawing.Size(391, 86);
			this.playerPanel.TabIndex = 6;
			this.playerPanel.Visible = false;
			// 
			// songNameBox
			// 
			this.songNameBox.Location = new System.Drawing.Point(3, 37);
			this.songNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.songNameBox.Multiline = true;
			this.songNameBox.Name = "songNameBox";
			this.songNameBox.ReadOnly = true;
			this.songNameBox.Size = new System.Drawing.Size(318, 40);
			this.songNameBox.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 4);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(146, 28);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Сейчас играет:";
			// 
			// composerFilter
			// 
			this.composerFilter.Location = new System.Drawing.Point(219, 17);
			this.composerFilter.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.composerFilter.Name = "composerFilter";
			this.composerFilter.Size = new System.Drawing.Size(157, 28);
			this.composerFilter.TabIndex = 7;
			this.composerFilter.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// genresFilter
			// 
			this.genresFilter.Location = new System.Drawing.Point(1019, 17);
			this.genresFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.genresFilter.Name = "genresFilter";
			this.genresFilter.Size = new System.Drawing.Size(157, 28);
			this.genresFilter.TabIndex = 12;
			this.genresFilter.TextChanged += new System.EventHandler(this.genresFilter_TextChanged);
			// 
			// songFilter
			// 
			this.songFilter.Location = new System.Drawing.Point(56, 17);
			this.songFilter.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.songFilter.Name = "songFilter";
			this.songFilter.Size = new System.Drawing.Size(157, 28);
			this.songFilter.TabIndex = 17;
			this.songFilter.TextChanged += new System.EventHandler(this.songFilter_TextChanged);
			// 
			// historyButton
			// 
			this.historyButton.Location = new System.Drawing.Point(1081, 697);
			this.historyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.historyButton.Name = "historyButton";
			this.historyButton.Size = new System.Drawing.Size(253, 60);
			this.historyButton.TabIndex = 18;
			this.historyButton.Text = "История покупок";
			this.historyButton.UseVisualStyleBackColor = true;
			this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox2.Location = new System.Drawing.Point(12, 12);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(38, 31);
			this.textBox2.TabIndex = 19;
			this.textBox2.Text = "🔎︎:";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// BuySongWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1344, 766);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.historyButton);
			this.Controls.Add(this.songFilter);
			this.Controls.Add(this.genresFilter);
			this.Controls.Add(this.composerFilter);
			this.Controls.Add(this.playerPanel);
			this.Controls.Add(this.menuButton);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "BuySongWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Покупка песен";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuySongWindow_FormClosing);
			this.Load += new System.EventHandler(this.BuySongWindow_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.playerPanel.ResumeLayout(false);
			this.playerPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button menuButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel playerPanel;
		private System.Windows.Forms.TextBox songNameBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox composerFilter;
		private System.Windows.Forms.TextBox genresFilter;
		private System.Windows.Forms.TextBox songFilter;
		private System.Windows.Forms.Button historyButton;
		private System.Windows.Forms.TextBox textBox2;
	}
}