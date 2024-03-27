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
	public partial class HistoryWindow : Form
	{
		string login; 
		BuySongWindow parent;
		public HistoryWindow(string login, BuySongWindow parent)
		{
			InitializeComponent();
			this.login = login;
			this.parent = parent;
			ConnectionSQL conn = new ConnectionSQL();
			NpgsqlDataReader dataReader = conn.Query($@"SELECT
															si.""Название"",
															si.""Композитор"",
															si.""Лейбл"",
															to_char(p.date_time,
															'DD.MM.YYYY HH24:MI') AS ""Дата и время покупки"",
															p.price AS ""Цена""
														FROM
															purchases p
														LEFT JOIN songs_info si ON
															p.song_id = si.""ID""
														LEFT JOIN users u ON
															u.id = p.client_id
														WHERE
															u.login = '{login}'
														ORDER BY
															p.date_time DESC;");
			if (dataReader.HasRows)
			{
				DataTable dt = new DataTable();
				dt.Load(dataReader);
				dataGridView1.DataSource = dt;
				dataGridView1.Columns["Композитор"].HeaderText = "Исполнитель";
			}
		}

		private void HistoryWindow_Load(object sender, EventArgs e)
		{

		}

		private void HistoryWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			parent.Show();
			Hide();
		}
	}
}
