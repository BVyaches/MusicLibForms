using System;
using System.Collections;
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
	public partial class EnterPhisDataWindow : Form
	{
		string login;
		int songId;
		BuySongWindow parent;
		public EnterPhisDataWindow(string login, int songId, BuySongWindow parent)
		{
			InitializeComponent();
			this.login = login;
			this.songId = songId;
			this.parent = parent;

		}

		private void passportDate_ValueChanged(object sender, EventArgs e)
		{

		}

		private void EnterPhisDataWindow_Load(object sender, EventArgs e)
		{

		}

		public void Back()
		{
			Hide();
			parent.Show();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Back();
		}

		private void enterButton_Click(object sender, EventArgs e)
		{
			string inn = innBox.Text;
			if (!Validator.ValidateNotEmpty(inn, "ИНН")) return;
			DateTime bDate = birthDate.Value.Date;
			string passport = passportText.Text;
			if (!Validator.ValidateNotEmpty(passport, "Серия и номер паспорта")) return;
			DateTime pDate = passportDate.Value.Date;
			string address = addressBox.Text;
			if (!Validator.ValidateNotEmpty(address, "Адрес проживания")) return;

			ArrayList data = new ArrayList {inn, bDate, passport, pDate, address};
			PaymentWindow pw = new PaymentWindow(login, songId, false, data, this);
			Hide();
			pw.Show();

		}

		private void EnterPhisDataWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Back();
		}
	}
}
