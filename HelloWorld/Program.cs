using Shared;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        var answer = string.Empty;
        var options = new List<string> { "s", "n" };

        do
        {
            try
            {
                DateOnly dateConverted = new DateOnly();
                Console.WriteLine("¡Hola, Bienvenido al calculador de años!");
                var nameInput = ConsoleExtension.GetString("Escribe tu nombre: ");
                Console.WriteLine($"Un gusto conocerte {nameInput}");
                var birthDateInput = ConsoleExtension.GetString("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
                bool isDateValid = DateOnly.TryParse(birthDateInput, out dateConverted);
                if (!isDateValid)
                {


                    throw new Exception($"La fecha de nacimiento no es válida, usted nos envió este dato erróneo: {birthDateInput}");
                }

                var person = new Person()
                {
                    Name = nameInput,
                    BirthDate = dateConverted,
                    Age = DateTime.Now.Year - dateConverted.Year
                };

                Console.WriteLine($"Tú nombre es.............: {person.Name}");
                Console.WriteLine($"Tú fecha de nacimiento es: {person.BirthDate}");
                Console.WriteLine($"Tú edad es...............: {person.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            do
            {
                answer = ConsoleExtension.GetValidOptions("¿Deseas continuar? ¿[S]í, [N]o?: ", options);
            }
            while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
        }
        while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
        Console.WriteLine(":::::: GAME OVER ::::::");
    }
}

public class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public DateOnly BirthDate { get; set; }
}
