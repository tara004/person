namespace TestPerson
{
	[TestClass]
	public class TestPerson
	{
		[TestMethod]
		public void TestConstructors()
		{
			//declare variable
			personClass.Person myPerson;

			//test parametless constructor
			myPerson = new personClass.Person();

			//test constructor
			myPerson = new personClass.Person("Mario", "Rossi");

			//test constructor
			myPerson = new personClass.Person("Mario", "Rossi", personClass.Person.GenderType.Male);

			//test constructor
			myPerson = new personClass.Person("Mario", "Rossi", personClass.Person.GenderType.Male, "Roma", new DateTime(2000, 10, 15));

			//test constructor
			myPerson = new personClass.Person("Mario", "Rossi", personClass.Person.GenderType.Male, "Roma", "RM", new DateTime(2000, 10, 15));
		}

		[TestMethod]
		public void TestFiscalCode(){
			//declare variable
			personClass.Person myPerson;

			//create object
			myPerson = new personClass.Person("Cladio", "Rossi", personClass.Person.GenderType.Male, "Rimini", "RN", new DateTime(1972, 8, 21));

			if (myPerson.FiscalCode() != "RSSCLD72M21H294M"){
				throw new Exception("Wrong fiscal code!");
			}

		}
	}
}