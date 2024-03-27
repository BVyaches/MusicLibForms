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
	public partial class EnterLegalDataWindow : Form
	{
		string login; 
		int songId; 
		BuySongWindow parent;

		public EnterLegalDataWindow(string login, int songId, BuySongWindow parent)
		{
			InitializeComponent();
			this.login = login;
			this.songId = songId;
			this.parent = parent;

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox13_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox12_TextChanged(object sender, EventArgs e)
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

		private void EnterLegalDataWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Back();
		}

		private void EnterLegalDataWindow_Load(object sender, EventArgs e)
		{

		}

		private void enterButton_Click(object sender, EventArgs e)
		{
			string compName = compNameBox.Text;
			if (!Validator.ValidateNotEmpty(compName, "Название компании")) return;
			string urAdd = addressBox.Text;
			if (!Validator.ValidateNotEmpty(urAdd, "Юридический адрес")) return;
			string inn = innBox.Text;
			if (!Validator.ValidateNotEmpty(inn, "ИНН")) return;
			string kpp = kppBox.Text;
			if (!Validator.ValidateNotEmpty(kpp, "КПП")) return;
			string bank = BankBox.Text;
			if (!Validator.ValidateNotEmpty(bank, "Банк")) return;
			string bankAcc = bankAccBox.Text;
			if (!Validator.ValidateNotEmpty(bankAcc, "Расчетный счет")) return;
			string bik = bikBox.Text;
			if (!Validator.ValidateNotEmpty(bik, "БИК")) return;


			ArrayList data = new ArrayList { compName, urAdd, inn, kpp, bank, bankAcc, bik };
			PaymentWindow pw = new PaymentWindow(login, songId, true, data, this);
			Hide();
			pw.Show();
		}
	}
}
