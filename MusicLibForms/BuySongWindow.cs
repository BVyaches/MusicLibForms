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
		public BuySongWindow()
		{
			InitializeComponent();
			ConnectionSQL conn = new ConnectionSQL();
			NpgsqlDataReader dataReader = conn.Query(@"Select * from songs_info");
			if (dataReader.HasRows)
			{
				DataTable dt = new DataTable();
				dt.Load(dataReader);
				dataGridView1.DataSource = dt;
				dataGridView1.Columns["ID"].Visible = false;
			}

			DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
			{
				Name = "Действие",
				Text = "Купить",
				UseColumnTextForButtonValue = true
			};
			dataGridView1.Columns.Add(buttonColumn);
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
				
				string clienName = nameBox.Text;

				if (clienName.Length != 0 && clienName.Count(x => x == ' ') >= 2)
				{
					string queue = @"INSERT INTO 
										purchases (song_id, client_name, date_time) 
									VALUES (@song_id, @client_name, @date_time);
									SELECT 
										currval(pg_get_serial_sequence('Purchases','id'))";
					ConnectionSQL conn = new ConnectionSQL();
					conn.conn.Open();
					NpgsqlCommand command = new NpgsqlCommand(queue, conn.conn);

					
					command.Parameters.AddWithValue("@song_id", song_id);
					command.Parameters.AddWithValue("@client_name", clienName);

					command.Parameters.AddWithValue("@date_time", DateTime.Now);

					int dealId = Convert.ToInt32(command.ExecuteScalar());
					// Выводим сообщение об успешной покупке
					MessageBox.Show($"Транзакция успешна, код договора: {dealId}");
					return;
				}


				MessageBox.Show("Введите корректные ФИО");
				
			}
		}

		private void BuySongWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void menuButton_Click(object sender, EventArgs e)
		{
			MainWindow mw = new MainWindow();
			mw.Show();
			Hide();
		}
	}
}
