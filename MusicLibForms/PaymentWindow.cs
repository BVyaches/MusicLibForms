using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibForms
{
	[ExcludeFromCodeCoverage]
	public partial class PaymentWindow : Form
	{
		string login; 
		int songId; 
		bool isLegal; 
		ArrayList args;
		Form parent;
		public PaymentWindow(string login, int songId, bool isLegal, ArrayList args, Form parent)
		{
			InitializeComponent();
			this.login = login;
			this.songId = songId;
			this.isLegal = isLegal;
			this.args = args;
			this.parent = parent;
		}

		private void PaymentWindow_Load(object sender, EventArgs e)
		{

		}

		private void continueButton_Click(object sender, EventArgs e)
		{
			string queue = @"INSERT INTO purchases(song_id, client_id, date_time, price) 
								values(@song_id, 
										(SELECT id FROM users WHERE login = @login), 
										@date_time, 
										(SELECT s.price FROM songs s WHERE s.id = @song_id));
								SELECT 
									currval(pg_get_serial_sequence('Purchases','id'))";
			ConnectionSQL conn = new ConnectionSQL();
			conn.conn.Open();
			NpgsqlCommand command = new NpgsqlCommand(queue, conn.conn);


			command.Parameters.AddWithValue("@song_id", songId);
			command.Parameters.AddWithValue("@login", login);
			command.Parameters.AddWithValue("@date_time", DateTime.Now);

			int dealId = Convert.ToInt32(command.ExecuteScalar());
			conn.conn.Close();

			queue = @"SELECT
						u.full_name, u.email
					FROM
						users u
					WHERE
						u.login = @login";
			command = new NpgsqlCommand(queue, conn.conn);
			command.Parameters.AddWithValue("@login", login);

			NpgsqlDataReader reader = conn.Query(command);
			if (!reader.HasRows) return;
			reader.Read();
			string userName = reader.GetString(0);
			string email = reader.GetString(1);
			conn.Close();


			queue = @"SELECT
						c.name, l.name, s.name, s.isrc, c.nickname
					FROM
						songs s
					JOIN composers c ON
						s.composer_id = c.id
					LEFT JOIN labels l ON
						s.label_id = l.id
					WHERE
						s.id = @id";
			command = new NpgsqlCommand(queue, conn.conn);
			command.Parameters.AddWithValue("@id", songId);

			reader = conn.Query(command);
			if (!reader.HasRows) return;
			reader.Read();
			string composer = reader.GetString(0);

			string songName = reader.GetString(2);
			string isrc = reader.GetString(3);
			string nickname = reader.GetString(4);
			conn.Close();
			// Выводим сообщение об успешной покупке
			MessageBox.Show($"Транзакция успешна, код договора: {dealId}.\n" +
				$"Договор {dealId}.pdf сохранен в папку загрузки");

			DocxFiller doc = new DocxFiller("C:\\Users\\slava\\OneDrive\\Документы\\templates\\");
			doc.SaveTemplate(isLegal, $"{dealId}", args, userName, email, songName, isrc, composer, nickname, dealId.ToString());
			Hide();
			if (isLegal)
			{
				((EnterLegalDataWindow) parent).Back();
			}
			else
			{
				((EnterPhisDataWindow) parent).Back();
			}
		}

		private void Back()
		{
			Hide();
			parent.Show();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			Back();
			if (isLegal)
			{
				((EnterLegalDataWindow) parent).Back();
			}
			else 
			{
				((EnterPhisDataWindow) parent).Back();
			}
		}

		private void PaymentWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Back();
		}
	}
}
