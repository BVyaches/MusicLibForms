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

			string connStr = @"User Id=postgres.fkflxdbyxxluwnisodtu;
								Password=Slavatop228;
								Server=aws-0-eu-central-1.pooler.supabase.com;
								Port=5432;
								Database=postgres;
								CommandTimeout=300;
								Timeout=300;";

			conn = new NpgsqlConnection(connStr);
		}

		public ConnectionSQL(string connStr)
		{

			connStr = @"User Id=postgres.fkflxdbyxxluwnisodtu;
								Password=Slavatop228;
								Server=aws-0-eu-central-1.pooler.supabase.com;
								Port=5432;
								Database=postgres;
								CommandTimeout=300;
								Timeout=300;";

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

		// <summary>
		/// Чтение результата запроса из таблицы
		/// </summary>
		/// <param name="sqlQuery"> Запрос в виде строчки </param>
		/// <returns></returns>
		public NpgsqlDataReader Query(NpgsqlCommand command) // передаем 
		{
			conn.Open(); // открытие соединения 

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
