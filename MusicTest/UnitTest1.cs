using System.Data;
using Moq;
using Npgsql;
using MusicLibForms;
using System.Windows.Forms;

namespace MusicTest
{
	[TestClass]
	public class ValidatorTests
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
	}
}