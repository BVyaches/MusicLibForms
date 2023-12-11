namespace MusicLibForms
{
	partial class MainWindow
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
			this.button2 = new System.Windows.Forms.Button();
			this.TopComposersButton = new System.Windows.Forms.Button();
			this.buySongs = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(21, 380);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 46);
			this.button1.TabIndex = 0;
			this.button1.Text = "Топ песен";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(21, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(200, 54);
			this.button2.TabIndex = 1;
			this.button2.Text = "Песни (таблица)";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// TopComposersButton
			// 
			this.TopComposersButton.Location = new System.Drawing.Point(21, 319);
			this.TopComposersButton.Name = "TopComposersButton";
			this.TopComposersButton.Size = new System.Drawing.Size(200, 46);
			this.TopComposersButton.TabIndex = 2;
			this.TopComposersButton.Text = "Топ композиторов";
			this.TopComposersButton.UseVisualStyleBackColor = true;
			this.TopComposersButton.Click += new System.EventHandler(this.TopComposersButton_Click);
			// 
			// buySongs
			// 
			this.buySongs.Location = new System.Drawing.Point(575, 16);
			this.buySongs.Name = "buySongs";
			this.buySongs.Size = new System.Drawing.Size(200, 46);
			this.buySongs.TabIndex = 3;
			this.buySongs.Text = "Купить";
			this.buySongs.UseVisualStyleBackColor = true;
			this.buySongs.Click += new System.EventHandler(this.buySongs_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1300, 905);
			this.Controls.Add(this.buySongs);
			this.Controls.Add(this.TopComposersButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainWindow";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button TopComposersButton;
		private System.Windows.Forms.Button buySongs;
	}
}