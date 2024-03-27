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
	public partial class AnalyticWindow : Form
	{
		MainWindow main;
		public AnalyticWindow(MainWindow main)
		{
			InitializeComponent();
			this.main = main;
		}


		private void topSongsButton_Click(object sender, EventArgs e)
		{
			TopSongsWindow tsw = new TopSongsWindow(this);
			tsw.Show();
			Hide();
		}

		private void TopComposersButton_Click(object sender, EventArgs e)
		{
			TopComposers tc = new TopComposers(this);
			tc.Show();
			Hide();
		}

		private void AnalyticWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void AnalyticWindow_Load(object sender, EventArgs e)
		{

		}

		private void backToMenuButton_Click(object sender, EventArgs e)
		{
			main.Show();
			Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TopGenres tg = new TopGenres(this);
			tg.Show();
			Hide();
		}
	}
}
