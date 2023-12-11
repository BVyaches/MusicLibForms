using Npgsql;
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
	public partial class TopComposers : Form
	{
		public TopComposers()
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
															c.nickname as Псевдоним,
															c.name as ФИО,
															sum(CASE
																WHEN cp.counter IS NULL THEN 0
																ELSE cp.counter
															END) AS Количество_покупок,
															sum(CASE
																WHEN cp.counter IS NULL THEN 0::money
																ELSE cp.counter * s.price
															END) AS Итоговая_сумма 
														FROM
																songs s
														LEFT JOIN composers c ON
																s.composer_id = c.id
														LEFT JOIN count_purchases cp ON
																s.id = cp.song_id
														GROUP BY
															c.id
														ORDER BY
																Итоговая_сумма DESC;");
			if (dataReader.HasRows)
			{
				DataTable dt = new DataTable();
				dt.Load(dataReader);
				dataGridView1.DataSource = dt;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MainWindow mw = new MainWindow();
			mw.Show();
			Hide();
		}

		private void TopComposers_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void TopComposers_Load(object sender, EventArgs e)
		{

		}
	}
}
