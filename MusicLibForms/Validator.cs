using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibForms
{
	public class Validator
	{
		public static bool ValidateNotEmpty(string message, string boxName = "")
		{
			if (string.IsNullOrEmpty(message.Replace(" ", String.Empty)))
			{
				MessageBox.Show($"Пожалуйста, заполните поле {boxName}");
				return false;
			}
			return true;
		}

		public static bool Validatelogin(string message)
		{
			if (message.Contains(" ") || message.Contains("\t"))
			{
				MessageBox.Show($"Пожалуйста, введите логин без пробелов");
				return false;
			}
			return true;
		}

		public static bool ValidateIntLen(string message, int len, string boxName = "")
		{
			if (!ValidateNotEmpty(message, boxName))
			{
				return false;
			}

			if (!int.TryParse(message, out _))
			{
				MessageBox.Show($"Пожалуйста, введите корректный {boxName}");
				return false;
			}

			if (message.Length != len)
			{
				MessageBox.Show($"Пожалуйста, введите корректный {boxName}");
				return false;
			}
			return true;
		}

		public static bool ValidateEmail(string message, string boxName = "")
		{
			Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");

			if (!ValidateNotEmpty(message, boxName))
			{
				return false;
			}

			if (!validateEmailRegex.IsMatch(message))
			{
				MessageBox.Show($"Пожалуйста, введите корректный {boxName}");
				return false;
			}
			return true;
		}
	}
}
