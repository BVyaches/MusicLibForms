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
	public partial class RegisterWindow : Form
	{
		MainWindow main;
		public RegisterWindow(MainWindow main)
		{
			InitializeComponent();
			this.main = main;
		}

		private void RegisterWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			main.Show();
			Hide();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			string login = loginBox.Text;
			if (!Validator.ValidateNotEmpty(login)) return;

			string name = nameBox.Text;
			if (!Validator.ValidateNotEmpty(name)) return;
			string password = passwordBox.Text;
			if (!Validator.ValidateNotEmpty(password)) return;
			string repeat = repeatPassBox.Text;

			if (password != repeat)
			{
				MessageBox.Show("Похоже, пароли не совпадают");
				return;
			}

			string email = emailBox.Text;
			if (!Validator.ValidateNotEmpty(email) || !email.Contains("@")) return;
			bool isLegal = isLegalBox.Checked;


			ConnectionSQL conn = new ConnectionSQL();
			string queue = $@"INSERT " +
				$"INTO users (login, full_name, password, privileges, legal_entity, email) " +
				$"VALUES (@login, @full_name, @password, 0, @isLegal, @email);";
			NpgsqlCommand command = new NpgsqlCommand(queue, conn.conn);
			command.Parameters.AddWithValue("@login", login);
			command.Parameters.AddWithValue("@full_name", name);
			command.Parameters.AddWithValue("@password", password);
			command.Parameters.AddWithValue("@isLegal", isLegal);
			command.Parameters.AddWithValue("@email", email);
			try
			{
				conn.Query(command);
				conn.conn.Close();
				BuySongWindow bsq = new BuySongWindow(main, login);
				bsq.Show();
				Hide();
			}
			catch (Npgsql.PostgresException)
			{
				MessageBox.Show("Данный логин уже занят");
				return;
			}
		}

		private void RegisterWindow_Load(object sender, EventArgs e)
		{

		}
	}
}
