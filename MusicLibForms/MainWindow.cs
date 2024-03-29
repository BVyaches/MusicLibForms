using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibForms
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
			this.Select();
		}

		

		private void MainWindow_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			SongsCRUD sc = new SongsCRUD();
			sc.Show();
			Hide();
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}


		private void loginButton_Click(object sender, EventArgs e)
		{
			LoginWindow lw = new LoginWindow(this);
			lw.Show();
			Hide();
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			RegisterWindow rw = new RegisterWindow(this);
			rw.Show();
			Hide();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
