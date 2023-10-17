Person person = new Person();
Console.WriteLine("Buongiorno ");

char x='s';
do
{
    Console.WriteLine("scegliere un opzione tar le disponibile ");
    Console.WriteLine("0 Inserire una persona/ 1 Codice fiscale / 2 Età / 3 mostrare i dati  ");
    int scelta = Int32.Parse(Console.ReadLine());
    switch (scelta)
    {
        case 0:
            Console.WriteLine("Hai scelto l'opzione 0.");
            Console.WriteLine("Inserimento dei dati persona: ");

            Console.Write("Nome: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Cognome: ");
            person.SecondName = Console.ReadLine();
            Console.Write("Sesso: ");
            //person.Gender = Console.ReadLine();
            Console.Write("Città di nascita: ");
            person.BirthCity = Console.ReadLine();
            Console.Write("Codice città di nascita: ");
            person.BirthCityCode = Console.ReadLine();
            Console.Write("Data di nascita (yyyy-MM-dd): ");


            break;
        case 1:
            Console.WriteLine("Hai scelto l'opzione 1.");
            Console.WriteLine("Codice Fiscale: ");
            Console.WriteLine($"Codice fiscale: {person.FiscalCode()}");

            break;
        case 2:
            Console.WriteLine("Hai scelto l'opzione 2.");
            Console.WriteLine("Età");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                person.BirthDate = birthDate;

                Console.WriteLine($"Età: {person.Age()}");
            }
            else
            {
                Console.WriteLine("Data di nascita non valida.");
            }
            break;
        case 3:
            Console.WriteLine("Hai scelto l'opzione 3.");
            Console.WriteLine("mostrare i dati della persona:");
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.SecondName);
            Console.WriteLine(person.BirthCity);
            Console.WriteLine(person.BirthCityCode);

            break;
        default:
            Console.WriteLine("Scelta non valida. Inserisci un valore tra 0 e 3.");
            break;
    }
    Console.WriteLine("Vuoi continuare.. s per si/n per no ");
    x = char.Parse(Console.ReadLine());
}
while (x!='n');







class Person
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public GenderType Gender { get; set; }
    public string BirthCity { get; set; }
    public string BirthCityCode { get; set; }
    public DateTime BirthDate { get; set; }

    public enum GenderType
    {
        Male,
        Female,
        NotSpecified
    }
    public void inserimento()
    {
        Person person = new Person();
        Console.Write("Nome: ");
        person.FirstName = Console.ReadLine();
        Console.Write("Cognome: ");
        person.SecondName = Console.ReadLine();
        Console.Write("Sesso: ");
        //person.Gender = Console.ReadLine();
        Console.Write("Città di nascita: ");
        person.BirthCity = Console.ReadLine();
        Console.Write("Codice città di nascita: ");
        person.BirthCityCode = Console.ReadLine();
        Console.Write("Data di nascita (yyyy-MM-dd): ");
        
        
        
    }

    public int Age()
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - BirthDate.Year;
        if (BirthDate > currentDate.AddYears(-age))
        {
            age--;
        }
        return age;
    }

    
     public string FiscalCode()
     {
         string result, gender;

         //create an istance of CodiceFiscale class
         CodiceFiscaleUtility.CodiceFiscale FiscalCode;

         //adapt the Gender property to the string type required by CodiceFiscale class

         if (this.Gender == GenderType.NotSpecified)
         {
             //if gender is missing, can't calculate fiscal code
             result = "";
         }
         else
         {
             if (this.Gender == GenderType.Male)
             {
                 gender = "M";
             }
             else
             {
                 gender = "F";
             }

             FiscalCode = new CodiceFiscaleUtility.CodiceFiscale(this.SecondName, this.FirstName, gender, this.BirthDate, this.BirthCity, this.BirthCityCode);

             //use CodiceFiscale class to generate the fiscal code
             result = FiscalCode.Codice;
         }
            
         return result;
    }

}





