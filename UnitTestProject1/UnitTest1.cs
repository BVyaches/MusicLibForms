using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MusicLibForms;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestValidateNotEmpty()
		{
			Assert.IsFalse(Validator.ValidateNotEmpty(" "));
			Assert.IsTrue(Validator.ValidateNotEmpty("Hello"));
		}

		[TestMethod]
		public void TestValidatelogin()
		{
			Assert.IsFalse(Validator.Validatelogin("Hello World"));
			Assert.IsTrue(Validator.Validatelogin("HelloWorld"));
		}

		[TestMethod]
		public void TestValidateIntLen()
		{
			Assert.IsFalse(Validator.ValidateIntLen("1234", 3));
			Assert.IsTrue(Validator.ValidateIntLen("123", 3));
		}

		[TestMethod]
		public void TestValidateEmail()
		{
			Assert.IsFalse(Validator.ValidateEmail("test"));
			Assert.IsTrue(Validator.ValidateEmail("test@example.com"));
		}

		[TestMethod]
		public void SongsCr()
		{
			var sc = new SongsCRUD();
			Assert.IsTrue(true);
		}
	}
}
