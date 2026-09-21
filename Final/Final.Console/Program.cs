using Shared;
using Final.Core;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
var opt = string.Empty;

do
{
    try
    {
        do
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("::::::::: DESAFIOS DE PROGRAMACIÓN BÁSICA :::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine();

            opt = Menu();
            switch (opt)
            {
                case "1":
                    var Challenge1 = new Challenge1();
                    Challenge1.Run();
                    break;
                case "2":
                    var Challenge2 = new Challenge2();
                    Challenge2.Run();
                    break;
                case "3":
                    var Challenge3 = new Challenge3();
                    Challenge3.Run();
                    break;
                case "4":
                    var Challenge4 = new Challenge4();
                    Challenge4.Run();
                    break;
                case "5":
                    var Challenge5 = new Challenge5();
                    Challenge5.Run();
                    break;
                case "6":
                    var Challenge6 = new Challenge6();
                    Challenge6.Run();
                    break;
                case "7":
                    var Challenge7 = new Challenge7();
                    Challenge7.Run();
                    break;
                case "8":
                    var Challenge8 = new Challenge8();
                    Challenge8.Run();
                    break;
                case "9":
                    var Challenge9 = new Challenge9();
                    Challenge9.Run();
                    break;
                case "10":
                    var Challenge10 = new Challenge10();
                    Challenge10.Run();
                    break;
                case "11":
                    var Challenge11 = new Challenge11();
                    Challenge11.Run();
                    break;
                case "12":
                    var Challenge12 = new Challenge12();
                    Challenge12.Run();
                    break;
                case "13":
                    var Challenge13 = new Challenge13();
                    Challenge13.Run();
                    break;
                case "14":
                    var Challenge14 = new Challenge14();
                    Challenge14.Run();
                    break;
                case "15":
                    var Challenge15 = new Challenge15();
                    Challenge15.Run();
                    break;
                default:
                    if (opt != "0")
                    {
                        throw new Exception(">>> El valor ingresado no es válido <<<");
                    }
                    break;
            }

        } while (opt != "0");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar? ¿[S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine(":::::: GAME OVER ::::::");


string Menu()
{
    Console.WriteLine("1. Determinar si un número es par o impar.");
    Console.WriteLine("2. Determinar el número mayor.");
    Console.WriteLine("3. Determinar si un año es bisiesto.");
    Console.WriteLine("4. Calcular Descuento.");
    Console.WriteLine("5. Calcular valor de matrícula.");
    Console.WriteLine("6. Calcular tarifa para envío de mercancías.");
    Console.WriteLine("7. Calcular suma y promedio.");
    Console.WriteLine("8. Calcular el factorial de un número.");
    Console.WriteLine("9. Calcular serie de taylor.");
    Console.WriteLine("10. Calcular ecuaciones cuadráticas.");
    Console.WriteLine("11. Generar la serie fibonacci.");
    Console.WriteLine("12. Generar números primos.");
    Console.WriteLine("13. Calcular el número 'e'.");
    Console.WriteLine("14. Generar el número 'PI'.");
    Console.WriteLine("15. Generar Calendario.");
    Console.Write("Ingrese el número del ejercicio que desea ejecutar: ");
    return Console.ReadLine()!;
}

