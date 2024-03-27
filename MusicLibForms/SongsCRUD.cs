using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.CodeAnalysis;

namespace MusicLibForms
{
	public partial class SongsCRUD : Form
	{
		string newFilePath;
		string musicPath = "C:\\Users\\slava\\Music\\";
		WMPLib.WindowsMediaPlayer player;
		public SongsCRUD()
		{
			InitializeComponent();
			UpdateSongsData();
			player = new WMPLib.WindowsMediaPlayer();
			player.settings.volume = 50;
			ConnectionSQL conn = new ConnectionSQL();
			
			NpgsqlDataReader dataReader = conn.Query("SELECT id, nickname FROM Composers ORDER BY id ASC");
			if (dataReader.HasRows)
			{
				DataTable dt = new DataTable();
				dt.Load(dataReader);
				composerBox.DataSource = dt;
				composerBox.DisplayMember = "nickname";
				composerBox.ValueMember = "id";
			}
			conn = new ConnectionSQL();


			dataReader = conn.Query("SELECT id, name FROM Labels ORDER BY id ASC");
			if (dataReader.HasRows)
			{
				DataTable dt = new DataTable();
				dt.Load(dataReader);

				DataRow emptyRow = dt.NewRow();
				emptyRow["id"] = 0;
				emptyRow["name"] = "";

				dt.Rows.InsertAt(emptyRow, 0);
				labelBox.DataSource = dt;
				labelBox.Text = "";
				labelBox.DisplayMember = "name";
				labelBox.ValueMember = "id";
				labelBox.SelectedValue = 0;
			}
			conn = new ConnectionSQL();
			dataReader = conn.Query("SELECT id, name FROM Genres ORDER BY id ASC");
			if (dataReader.HasRows)
			{
				// Получение данных из таблицы Genres
				DataTable table = new DataTable();
				table.Load(dataReader);

				GenresBox.DataSource = table;
				GenresBox.DisplayMember = "name";
				GenresBox.ValueMember = "id";
				GenresBox.SelectionMode = SelectionMode.MultiSimple;
			}

			UpdateGroup.Visible = false;
			
		}
		private int idToUpdate;
		public void UpdateSongsData()
		{

			ConnectionSQL conn = new ConnectionSQL();
			NpgsqlDataReader dataReader = conn.Query(@"Select * from songs_info");
			if (dataReader.HasRows)
			{
				DataTable dt = new DataTable();
				dt.Load(dataReader);
				dataGridView.DataSource = dt;
				dataGridView.Columns["ID"].Visible = false;
				DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
				{
					Name = "Удаление",
					Text = "Удалить",
					UseColumnTextForButtonValue = true
				};
				if (!dataGridView.Columns.Contains("Удаление"))
				{
					dataGridView.Columns.Add(buttonColumn);
				}

				DataGridViewButtonColumn buttonColumnUpdate = new DataGridViewButtonColumn
				{
					Name = "Изменение",
					Text = "Изменить",
					UseColumnTextForButtonValue = true
				};
				if (!dataGridView.Columns.Contains("Изменение"))
				{
					dataGridView.Columns.Add(buttonColumnUpdate);
				}

				DataGridViewButtonColumn playerColumn = new DataGridViewButtonColumn
				{
					Name = " ",
					Text = "▶",
					UseColumnTextForButtonValue = true
				};
				if (!dataGridView.Columns.Contains(" "))
				{
					dataGridView.Columns.Insert(0, playerColumn);
				}
				dataGridView.Columns["Композитор"].HeaderText = "Исполнитель";
				dataGridView.Columns[" "].Width = 40;
				dataGridView.Columns["Изменение"].Width = 90;
				dataGridView.Columns["Удаление"].Width = 90;



			}
		}

		private void SongsCRUD_Load(object sender, EventArgs e)
		{

		}

		private void SongsCRUD_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MainWindow mw = new MainWindow();
			mw.Show();
			Hide();
			player.controls.stop();
		}

		private int AddSong(string name, int? composerId, int? labelId, 
			TimeSpan duration, string isrc, decimal price, List<int> genres_ids)
		{
			ConnectionSQL conn = new ConnectionSQL();
			conn.conn.Open();
			NpgsqlCommand command = new NpgsqlCommand($@"INSERT
													INTO
													Songs (name,
													composer_id,
													label_id,
													duration,
													ISRC,
													price)
												VALUES(@name,
													@composer_id,
													@label_id,
													@duration,
													@ISRC,
													@price
												);
												SELECT 
													currval(pg_get_serial_sequence('Songs','id'))", conn.conn);
			
			if (labelId == 0)
			{
				command.Parameters.AddWithValue("@label_id", DBNull.Value);
			}
			else
			{
				command.Parameters.AddWithValue("@label_id", labelId);
			}
			command.Parameters.AddWithValue("@name", name);
			command.Parameters.AddWithValue("@composer_id", composerId);
			
			command.Parameters.AddWithValue("@duration", duration);
			command.Parameters.AddWithValue("@ISRC", isrc);
			command.Parameters.AddWithValue("@price", price);

			int newId = Convert.ToInt32(command.ExecuteScalar());

			foreach (int i in genres_ids)
			{
				command = new NpgsqlCommand("INSERT INTO Songs_genres VALUES(@song_id, @genre_id)", conn.conn);
				command.Parameters.AddWithValue("@song_id", newId);
				command.Parameters.AddWithValue("@genre_id", i);
				command.ExecuteNonQuery();
			}

			return newId;

		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			int composerId = (int) composerBox.SelectedValue;
			int labelId = (int) labelBox.SelectedValue;
			List<int> genreIds = new List<int>();
			foreach (DataRowView item in GenresBox.SelectedItems)
			{
				genreIds.Add((int) item["id"]);
			}

			if (genreIds.Count == 0)
			{
				MessageBox.Show("Выберите хотя бы один жанр!");
				return;
			}

			string priceTextRaw = priceText.Text;
			priceTextRaw = priceTextRaw.Replace(".", ",");
			


			if (nameText.Text != "" && isrcText.Text != "" && priceTextRaw != "" && !string.IsNullOrEmpty(newFilePath))
			{
				// Получаем длительность
				WMPLib.WindowsMediaPlayer durPlayer = new WMPLib.WindowsMediaPlayer();
				WMPLib.IWMPMedia media = durPlayer.newMedia(newFilePath);
				string duration = media.durationString;
				MessageBox.Show(duration);
				durPlayer = null;
				TimeSpan dur = TimeSpan.ParseExact(duration, "mm\\:ss", null);
				MessageBox.Show(dur.ToString());



				int songId = AddSong(nameText.Text, composerId, labelId, dur, isrcText.Text, Convert.ToDecimal(priceTextRaw), genreIds);
				UpdateSongsData();
				System.IO.File.Move(newFilePath, musicPath+$"{songId}.mp3");


				newFilePath = null;
				loadedFileBox.Text = "Файл не загружен!";
			}
			else
			{
				MessageBox.Show("Заполните все поля!");
			}
		}

		private void showUpdate_Click(object sender, EventArgs e)
		{
			UpdateGroup.Visible = !UpdateGroup.Visible;
			if (UpdateGroup.Visible)
			{
				updateNameText.Text = nameText.Text;

				DataTable dt = (DataTable) composerBox.DataSource;
				updateComposerBox.DataSource = dt.Copy();
				updateComposerBox.DisplayMember = "nickname";
				updateComposerBox.ValueMember = "id";
				updateComposerBox.SelectedValue = composerBox.SelectedValue;

				dt = (DataTable) labelBox.DataSource;
				updateLabelBox.DataSource = dt.Copy();
				updateLabelBox.DisplayMember = "name";
				updateLabelBox.ValueMember = "id";
				updateLabelBox.SelectedValue = labelBox.SelectedValue;


				updateIsrcText.Text = isrcText.Text;
				updatePriceText.Text = priceText.Text;

				dt = (DataTable) GenresBox.DataSource;
				updateGenresBox.DataSource = dt.Copy();
				updateGenresBox.DisplayMember = "name";
				updateGenresBox.ValueMember = "id";
				updateGenresBox.SelectionMode = SelectionMode.MultiSimple;
				updateGenresBox.SelectedIndices.Clear();
				foreach (int index in GenresBox.SelectedIndices)
				{
					updateGenresBox.SelectedIndices.Add(index);
				}
			}
		}

		private void OpenForUpdate(string name, string composer, string label, string isrc, string price, List<string> genres)
		{
			UpdateGroup.Visible = true;
			updateNameText.Text = name;

			DataTable dt = (DataTable) composerBox.DataSource;
			updateComposerBox.DataSource = dt.Copy();
			updateComposerBox.DisplayMember = "nickname";
			updateComposerBox.ValueMember = "id";
			foreach (DataRow row in dt.Rows)
			{
				if ((string) row["nickname"] == composer)
				{
					updateComposerBox.SelectedValue = Convert.ToInt32(row["id"]);
					break;
				}
			}

			dt = (DataTable) labelBox.DataSource;
			updateLabelBox.DataSource = dt.Copy();
			updateLabelBox.DisplayMember = "name";
			updateLabelBox.ValueMember = "id";
			foreach (DataRow row in dt.Rows)
			{
				if ((string) row["name"] == label)
				{
					updateLabelBox.SelectedValue = Convert.ToInt32(row["id"]);
					break;
				}
			}


			updateIsrcText.Text = isrc;
			updatePriceText.Text = price;

			dt = (DataTable) GenresBox.DataSource;
			updateGenresBox.DataSource = dt.Copy();
			updateGenresBox.DisplayMember = "name";
			updateGenresBox.ValueMember = "id";
			updateGenresBox.SelectionMode = SelectionMode.MultiSimple;
			updateGenresBox.SelectedIndices.Clear();
			foreach (DataRow row in dt.Rows)
			{
				if (genres.Contains(row["name"]))
				{
					updateGenresBox.SelectedIndices.Add(Convert.ToInt32(row["id"]) - 1);
				}
			}
		}

		private void UpdateSong(string newName, int? newComposerId, int? newLabelId, string newIsrc, 
			decimal newPrice, List<int> newGenres_ids)
		{
			ConnectionSQL conn = new ConnectionSQL();
			conn.conn.Open();


			NpgsqlCommand command = new NpgsqlCommand(@"BEGIN;

										UPDATE
											Songs
										SET
											name = @newName,
											composer_id = @newComposerId,
											label_id = @newLabelId,
											isrc = @newIsrc,
											price = @newPrice::money
										WHERE
											id = @idToUpdate;

										DELETE
										FROM
											songs_genres
										WHERE
											song_id = @idToUpdate;

										COMMIT;", conn.conn);

			if (newLabelId == 0)
			{
				command.Parameters.AddWithValue("@newLabelId", DBNull.Value);
			}
			else
			{
				command.Parameters.AddWithValue("@newLabelId", newLabelId);
			}
			command.Parameters.AddWithValue("@newName", newName);
			command.Parameters.AddWithValue("@newComposerId", newComposerId);

			command.Parameters.AddWithValue("@newIsrc", newIsrc);
			command.Parameters.AddWithValue("@newPrice", newPrice);
			command.Parameters.AddWithValue("@idToUpdate", idToUpdate);
			command.ExecuteNonQuery();

			foreach (int i in newGenres_ids)
			{
				command = new NpgsqlCommand("INSERT INTO Songs_genres VALUES(@song_id, @genre_id)", conn.conn);
				command.Parameters.AddWithValue("@song_id", idToUpdate);
				command.Parameters.AddWithValue("@genre_id", i);
				command.ExecuteNonQuery();
			}
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{

			int newComposerId = (int) updateComposerBox.SelectedValue;
			int newLabelId = (int) updateLabelBox.SelectedValue;
			List<int> newGenres_ids = new List<int>();
			foreach (DataRowView item in updateGenresBox.SelectedItems)
			{
				newGenres_ids.Add((int) item["id"]);
			}


			string newPriceTextRaw = updatePriceText.Text;
			newPriceTextRaw = newPriceTextRaw.Replace(".", ",");
			if (updateIsrcText.Text.Length != 15)
			{
				MessageBox.Show("Введите корректный ISRC код");
				return;
			}
			if (updateNameText.Text != "" && updateIsrcText.Text != "" && newPriceTextRaw != "")
			{
				UpdateSong(updateNameText.Text, newComposerId, newLabelId, updateIsrcText.Text, Convert.ToDecimal(newPriceTextRaw), newGenres_ids);
				UpdateSongsData();
				UpdateGroup.Visible = false;
			}
			else
			{
				MessageBox.Show("Заполните все поля!");
			}
		}

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Если нажата кнопка в столбце Buy
			if (e.ColumnIndex == dataGridView.Columns["Удаление"].Index)
			{
				// Получаем объект песни, соответствующий выбранной строке
				int song_id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());


				ConnectionSQL conn = new ConnectionSQL();
				conn.conn.Open();
				NpgsqlCommand command = new NpgsqlCommand(@"BEGIN;

										DELETE
										FROM
											Songs
										WHERE
											id = @idToDelete;

										DELETE
										FROM
											songs_genres
										WHERE
											song_id = @idToDelete;

										COMMIT;", conn.conn);
				command.Parameters.AddWithValue("@idToDelete", song_id);
				command.ExecuteNonQuery();

				MessageBox.Show("Успешно удалено");
				UpdateSongsData();
			}

			else if (e.ColumnIndex == dataGridView.Columns["Изменение"].Index)
			{


				// Получаем объект песни, соответствующий выбранной строке
				idToUpdate = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
				string name = dataGridView.CurrentRow.Cells["Название"].Value.ToString();
				string composer = dataGridView.CurrentRow.Cells["Композитор"].Value.ToString();
				string label = dataGridView.CurrentRow.Cells["Лейбл"].Value.ToString();
				string isrc = dataGridView.CurrentRow.Cells["ISRC"].Value.ToString();
				string price = dataGridView.CurrentRow.Cells["Цена"].Value.ToString();
				List<string> genres = dataGridView.CurrentRow.Cells["Жанры"].Value.ToString().Replace("; ", ";").Split(';').ToList();

				
				
				OpenForUpdate(name, composer, label, isrc, price, genres);

			}

			else if (e.ColumnIndex == dataGridView.Columns[" "].Index)
			{
				playerPanel.Visible = true;
				int song_id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
				string songName = dataGridView.CurrentRow.Cells["Название"].Value.ToString();
				string author = dataGridView.CurrentRow.Cells["Композитор"].Value.ToString();
				player.controls.stop();
				player.URL = $"{musicPath}{song_id}.mp3";
				songNameBox.Text = author + " - " + songName;
				player.controls.play();

			}
		}

		private void HideUpdateButton_Click(object sender, EventArgs e)
		{
			UpdateGroup.Visible = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "MP3|*.mp3";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog1.FileName;
				FileInfo info = new FileInfo(filePath);
				string fileName = info.Name;
				loadedFileBox.Text = "Загружено: " + fileName;
				newFilePath = filePath;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			player.controls.stop();
			playerPanel.Visible = false;
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
