using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace MusicLibForms
{
	public class ConnectionSQL // Пользовательский класс для подключение к MySQL
	{
		public NpgsqlConnection conn;
		NpgsqlDataReader reader; // средство чтения прямого потока строк из MySQL

		/// <summary>
		/// Подключение к Postgre по ссылке
		/// </summary>
		public ConnectionSQL()
		{
			string host = "server1.hosting.reg.ru"; // ВСТАВИТЬ СВОИ ДАННЫЕ !!!!!!!!!!
			
			string database = ""; // ВСТАВИТЬ СВОИ ДАННЫЕ !!!!!!!!!!
			string username = ""; // ВСТАВИТЬ СВОИ ДАННЫЕ !!!!!!!!!!
			string password = ""; // ВСТАВИТЬ СВОИ ДАННЫЕ !!!!!!!!!!

			// ----- ЛОКАЛЬНО НА localhost
			//string host = "localhost";
			//int port = 3306;
			//string database = "name_database";
			//string username = "root";
			//string password = "";

			string connStr = "Host=db.fkflxdbyxxluwnisodtu.supabase.co;Username=postgres;Password=Slavatop228;Database=postgres";

			conn = new NpgsqlConnection(connStr);
		}

		/// <summary>
		/// Чтение результата запроса из таблицы
		/// </summary>
		/// <param name="sqlQuery"> Запрос в виде строчки </param>
		/// <returns></returns>
		public NpgsqlDataReader Query(string sqlQuery) // передаем текст запроса
		{
			conn.Open(); // открытие соединения 
			NpgsqlCommand command = new NpgsqlCommand(sqlQuery, conn);

			reader = command.ExecuteReader(); // исполнение запроса и получение данных из БД
			
			return reader;
		}


		/// <summary>
		/// Закрыть объект NpgsqlDataReader
		/// </summary>
		public void Close()
		{
			reader.Close();
			conn.Close();
		}
	}
}
