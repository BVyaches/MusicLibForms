using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MusicLibForms
{
	public partial class BuySongWindow : Form
	{
		MainWindow main;
		string userLogin;
		bool buyInProcess = false;
		bool buyFinished = false;
		WMPLib.WindowsMediaPlayer player;

		public BuySongWindow(MainWindow main, string login)
		{
			InitializeComponent();
			player = new WMPLib.WindowsMediaPlayer();
			this.main = main;
			this.userLogin = login;
			ConnectionSQL conn = new ConnectionSQL();
			NpgsqlDataReader dataReader = conn.Query(@"Select * from songs_info");
			if (dataReader.HasRows)
			{
				DataTable dt = new DataTable();
				dt.Load(dataReader);
				dataGridView1.DataSource = dt;
				dataGridView1.Columns["ID"].Visible = false;
				dataGridView1.Columns["Композитор"].HeaderText = "Исполнитель";
			}

			DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
			{
				Name = "Действие",
				Text = "Купить",
				UseColumnTextForButtonValue = true
			};

			DataGridViewButtonColumn playerColumn = new DataGridViewButtonColumn
			{
				Name = " ",
				Text = "▶",
				UseColumnTextForButtonValue = true
			};
			dataGridView1.Columns.Add(buttonColumn);
			dataGridView1.Columns.Insert(0, playerColumn);
			dataGridView1.Columns[" "].Width = 40;
		}

		private void BuySongWindow_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Если нажата кнопка в столбце Buy
			if (e.ColumnIndex == dataGridView1.Columns["Действие"].Index)
			{
				// Получаем объект песни, соответствующий выбранной строке
				int song_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

				string queue = @"SELECT
									u.legal_entity
								FROM
									users u
								WHERE
									u.login = @login";
				ConnectionSQL conn = new ConnectionSQL();
				NpgsqlCommand command = new NpgsqlCommand(queue, conn.conn);
				command.Parameters.AddWithValue("@login", userLogin);

				NpgsqlDataReader reader = conn.Query(command);
				
				if (reader.HasRows)
				{
					reader.Read();
					bool isLegal = reader.GetBoolean(0);
					if (isLegal)
					{
						EnterLegalDataWindow eldw = new EnterLegalDataWindow(userLogin, song_id, this);
						eldw.Show();
						Hide();

					}
					else
					{
						EnterPhisDataWindow epdw = new EnterPhisDataWindow(userLogin, song_id, this);
						epdw.Show();
						Hide();

					}
				}
				return;
			}

			else if (e.ColumnIndex == dataGridView1.Columns[" "].Index)
			{
				playerPanel.Visible = true;
				int song_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
				string songName = dataGridView1.CurrentRow.Cells["Название"].Value.ToString();
				string author = dataGridView1.CurrentRow.Cells["Композитор"].Value.ToString();
				player.controls.stop();
				player.URL = $"C:\\Users\\slava\\Music\\{song_id}.mp3";
				songNameBox.Text = author + " - " + songName;
				player.controls.play();
				
			}
		}

		private void BuySongWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void menuButton_Click(object sender, EventArgs e)
		{
			main.Show();
			Hide();
			player.controls.stop();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			player.controls.stop();
			playerPanel.Visible = false;
		}

		void UpdateFilter()
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = dataGridView1.DataSource;
			bs.Filter = "Композитор" + " LIKE '%" + composerFilter.Text + "%'" + " AND "
				+ "Название" + " LIKE '%" + songFilter.Text + "%'" + " AND "
				+ "Жанры" + " LIKE '%" + genresFilter.Text + "%'";
			dataGridView1.DataSource = bs;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void songFilter_TextChanged(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void genresFilter_TextChanged(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void historyButton_Click(object sender, EventArgs e)
		{
			player.controls.stop();
			playerPanel.Visible = false;
			HistoryWindow hw = new HistoryWindow(userLogin, this);
			hw.Show();
			Hide();
		}
	}
}
