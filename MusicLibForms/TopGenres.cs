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
	public partial class TopGenres : Form
	{

		AnalyticWindow analWind;
		public TopGenres(AnalyticWindow analWind)
		{
			InitializeComponent();
			this.analWind = analWind;
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
															g.name as ""Жанр"",
															SUM(cp.counter) AS ""Количество покупок"",
															SUM(cp.counter * s.price) AS ""Сумма покупок""
														FROM
															genres g
														JOIN songs_genres sg
														ON
															sg.genre_id = g.id
														JOIN count_purchases cp
														ON
															cp.song_id = sg.song_id
														JOIN songs s
														ON
															s.id = cp.song_id
														GROUP BY
															g.id
														ORDER BY
															""Количество покупок"" DESC");
			if (dataReader.HasRows)
			{
				DataTable dt = new DataTable();
				dt.Load(dataReader);
				dataGridView1.DataSource = dt;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			analWind.Show();
			Hide();
		}

		private void TopGenres_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void TopGenres_Load(object sender, EventArgs e)
		{

		}
	}
}
