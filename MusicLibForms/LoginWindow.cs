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
	public partial class LoginWindow : Form
	{
		MainWindow main;
		public LoginWindow(MainWindow main)
		{
			InitializeComponent();
			this.main = main;
		}

		private void LoginWindow_Load(object sender, EventArgs e)
		{

		}

		private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			string login = loginBox.Text;
			if (!Validator.ValidateNotEmpty(login)) return;

			string password = passwordBox.Text;
			if (!Validator.ValidateNotEmpty(password)) return;

			
			ConnectionSQL conn = new ConnectionSQL();
			string queue = $@"select password, privileges from users where login = @login";
			NpgsqlCommand command = new NpgsqlCommand(queue, conn.conn);
			command.Parameters.AddWithValue("@login", login);
			var reader =  conn.Query(command);
			if (!reader.HasRows)
			{
				MessageBox.Show("Данной учетной записи не существует");
				return;
			}
			reader.Read();
			if (reader.GetString(0) == password)
			{
				int privilege = reader.GetInt32(1);

				if (privilege == 0)
				{
					BuySongWindow bsq = new BuySongWindow(main, login);
					bsq.Show();
				}
				else if (privilege == 1)
				{
					AnalyticWindow aw = new AnalyticWindow(main);
					aw.Show();
				}
				else if (privilege == 2)
				{
					SongsCRUD scrud = new SongsCRUD();
					scrud.Show();
				}
				Hide();
			}
			else
			{
				MessageBox.Show("Введен неверный пароль");
				return;
			}
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			Hide();
			main.Show();
		}
	}
}
