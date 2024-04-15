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
			if (!Validator.ValidateIntLen(inn, 10, "ИНН")) return;
			string kpp = kppBox.Text;
			if (!Validator.ValidateIntLen(kpp, 9, "КПП")) return;
			string bank = BankBox.Text;
			if (!Validator.ValidateNotEmpty(bank, "Банк")) return;
			string bankAcc = bankAccBox.Text;
			if (!Validator.ValidateIntLen(bankAcc, 20, "Расчетный счет")) return;
			string bik = bikBox.Text;
			if (!Validator.ValidateIntLen(bik, 9, "БИК")) return;


			ArrayList data = new ArrayList { compName, urAdd, inn, kpp, bank, bankAcc, bik };
			PaymentWindow pw = new PaymentWindow(login, songId, true, data, this);
			Hide();
			pw.Show();
		}

		private void innBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}
	}
}
