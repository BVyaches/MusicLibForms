namespace MusicLibForms
{
	partial class AnalyticWindow
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
			this.TopComposersButton = new System.Windows.Forms.Button();
			this.topSongsButton = new System.Windows.Forms.Button();
			this.backToMenuButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TopComposersButton
			// 
			this.TopComposersButton.Location = new System.Drawing.Point(282, 99);
			this.TopComposersButton.Name = "TopComposersButton";
			this.TopComposersButton.Size = new System.Drawing.Size(222, 51);
			this.TopComposersButton.TabIndex = 4;
			this.TopComposersButton.Text = "Топ исполнителей";
			this.TopComposersButton.UseVisualStyleBackColor = true;
			this.TopComposersButton.Click += new System.EventHandler(this.TopComposersButton_Click);
			// 
			// topSongsButton
			// 
			this.topSongsButton.Location = new System.Drawing.Point(282, 156);
			this.topSongsButton.Name = "topSongsButton";
			this.topSongsButton.Size = new System.Drawing.Size(222, 51);
			this.topSongsButton.TabIndex = 3;
			this.topSongsButton.Text = "Топ песен";
			this.topSongsButton.UseVisualStyleBackColor = true;
			this.topSongsButton.Click += new System.EventHandler(this.topSongsButton_Click);
			// 
			// backToMenuButton
			// 
			this.backToMenuButton.Location = new System.Drawing.Point(12, 324);
			this.backToMenuButton.Name = "backToMenuButton";
			this.backToMenuButton.Size = new System.Drawing.Size(186, 64);
			this.backToMenuButton.TabIndex = 5;
			this.backToMenuButton.Text = "Выйти";
			this.backToMenuButton.UseVisualStyleBackColor = true;
			this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(282, 213);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(222, 50);
			this.button1.TabIndex = 6;
			this.button1.Text = "Топ жанров";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AnalyticWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 400);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.backToMenuButton);
			this.Controls.Add(this.TopComposersButton);
			this.Controls.Add(this.topSongsButton);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "AnalyticWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Аналитика";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnalyticWindow_FormClosing);
			this.Load += new System.EventHandler(this.AnalyticWindow_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button TopComposersButton;
		private System.Windows.Forms.Button topSongsButton;
		private System.Windows.Forms.Button backToMenuButton;
		private System.Windows.Forms.Button button1;
	}
}