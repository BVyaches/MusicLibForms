using Microsoft.Office.Interop.Word;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
namespace MusicLibForms
{

	public interface IWordApplication
	{
		IWordDocument Add(string Template, object NewTemplate, object DocumentType, object Visible);
		
	}

	public interface IWordDocument
	{
		Bookmarks Bookmarks { get; }
		void SaveAs(string FileName);
		void Close();
		
	}

	public class DocxFiller
	{
		string tempLoc;

		public DocxFiller(string tempLoc)
		{
			this.tempLoc = tempLoc;
		}

		public Word._Document FillLegal(ArrayList data, string songName, string isrc, string composer, 
			string nickname, string userName, string dealNum)
		{
            // Определение переменной oWord
			Word._Application oWord = new Word.Application();
			Word._Document oDoc = oWord.Documents.Add(tempLoc + "legalTemp.docx");
			oDoc.Bookmarks["dealNum"].Range.Text = dealNum;
			oDoc.Bookmarks["date"].Range.Text = DateTime.Today.ToString("d");
			oDoc.Bookmarks["fio"].Range.Text = userName;

			oDoc.Bookmarks["songName"].Range.Text = songName;
			oDoc.Bookmarks["songISRC"].Range.Text = isrc;
			oDoc.Bookmarks["songComposer"].Range.Text = composer;
			oDoc.Bookmarks["songNickname"].Range.Text = nickname;

			oDoc.Bookmarks["compName"].Range.Text = data[0].ToString();
			oDoc.Bookmarks["buyerAddress"].Range.Text = data[1].ToString();
			oDoc.Bookmarks["buyerInn"].Range.Text = data[2].ToString();
			oDoc.Bookmarks["buyerKpp"].Range.Text = data[3].ToString();
			oDoc.Bookmarks["buyerBank"].Range.Text = data[4].ToString();
			oDoc.Bookmarks["buyerBankAcc"].Range.Text = data[5].ToString();
			oDoc.Bookmarks["buyerBik"].Range.Text = data[6].ToString();
			return oDoc;
		}

		public Word._Document FillPhis(ArrayList data, string songName, string isrc, string composer, 
			string nickname, string userName, string dealNum, string email)
		{
			// Определение переменной oWord
			Word._Application oWord = new Word.Application();
			Word._Document oDoc = oWord.Documents.Add(tempLoc + "phisTemp.docx");
			oDoc.Bookmarks["dealNum"].Range.Text = dealNum;
			oDoc.Bookmarks["date"].Range.Text = DateTime.Today.ToString("d");
			oDoc.Bookmarks["fio"].Range.Text = userName;

			oDoc.Bookmarks["songName"].Range.Text = songName;
			oDoc.Bookmarks["songISRC"].Range.Text = isrc;
			oDoc.Bookmarks["songComposer"].Range.Text = composer;
			oDoc.Bookmarks["songNickname"].Range.Text = nickname;

			oDoc.Bookmarks["inn"].Range.Text = data[0].ToString();
			oDoc.Bookmarks["bDate"].Range.Text = ((DateTime) data[1]).ToString("d");
			oDoc.Bookmarks["passport"].Range.Text = data[2].ToString();
			oDoc.Bookmarks["passDate"].Range.Text = ((DateTime) data[3]).ToString("d");
			oDoc.Bookmarks["address"].Range.Text = data[4].ToString();
			
			oDoc.Bookmarks["email"].Range.Text = email;
			return oDoc;
		}

		public void SaveTemplate(bool isLegal, string targetLoc, ArrayList data, string userName, string email,
			string songName, string isrc, string composer, string nickname, string dealNum)
		{
			Word._Document doc;
			if (isLegal)
			{
				doc = FillLegal(data, songName, isrc, composer, nickname, userName, dealNum);
			}
			else
			{
				doc = FillPhis(data, songName, isrc, composer, nickname, userName, dealNum, email);
			}
			
			doc.SaveAs(FileName: "C:\\Users\\slava\\Downloads\\" + $"{targetLoc}.docx");
			doc.Close();
		}

	}
}
