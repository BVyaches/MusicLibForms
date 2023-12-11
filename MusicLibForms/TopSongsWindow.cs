using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibForms
{
	//public partial class MainWindow : Form
	//{
	//	public MainWindow()
	//	{
	//		InitializeComponent();
	//	}

	//	private void MainWindow_Load(object sender, EventArgs e)
	//	{

	//	}
	//}

	public partial class TopSongsWindow : Form
	{
		public TopSongsWindow()
		{
			InitializeComponent();
			dataGridView1.Rows.Clear();

			ConnectionSQL conn = new ConnectionSQL();
			NpgsqlDataReader dataReader = conn.Query(@"WITH count_purchases AS (
													SELECT
														p.song_id,
														count(1) AS counter
													FROM
														purchases p
													GROUP BY
														p.song_id)
													SELECT
														s.name as Песня,
														c.nickname as Композитор,
														l.name as Лейбл,
														CASE
															WHEN cp.counter IS NULL THEN 0
															ELSE cp.counter
														END AS Количество_покупок,
														CASE
															WHEN cp.counter IS NULL THEN 0::money
															ELSE cp.counter * s.price
														END AS Итоговая_сумма
													FROM
															songs s
													LEFT JOIN composers c ON
															s.composer_id = c.id
													LEFT JOIN labels l ON
															s.label_id = l.id
													LEFT JOIN count_purchases cp ON
															s.id = cp.song_id
													ORDER BY
															Итоговая_сумма DESC;");
			if (dataReader.HasRows)
			{
				DataTable dt = new DataTable();
				dt.Load(dataReader);
				dataGridView1.DataSource = dt;
			}
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			MainWindow mw = new MainWindow();
			mw.Show();
			Hide();
		}

		private void TopSongsWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
