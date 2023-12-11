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
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TopSongsWindow tsw = new TopSongsWindow();
			tsw.Show();
			Hide();
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

		private void TopComposersButton_Click(object sender, EventArgs e)
		{
			TopComposers tc = new TopComposers();
			tc.Show();
			Hide();
		}

		private void buySongs_Click(object sender, EventArgs e)
		{
			BuySongWindow bsw = new BuySongWindow();
			bsw.Show();
			Hide();
		}
	}
}
