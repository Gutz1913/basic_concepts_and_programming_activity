using Shared;

// ***** Conditionals *****

var answer = string.Empty;
var options = new List<string> { "s", "n" };

Console.WriteLine("::::::::::::::::::::::::::::::::::");
Console.WriteLine("::::: EJERCICIO DE MULTIPLOS :::::");
Console.WriteLine("::::::::::::::::::::::::::::::::::");

do
{
    try
    {
        var number1 = ConsoleExtension.GetInt("Ingrese el primer número.: ");
        var number2 = ConsoleExtension.GetInt("Ingrese el segundo número: ");

        if (number1 % number2 == 0)
        {
            Console.WriteLine($"{number1} es multiplo de {number2}.");
        }
        else
        {
            Console.WriteLine($"{number1} no es multiplo de {number2}.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: { ex.Message }");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar? ¿[S]í, [N]o?: ", options);
    }
    while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("::::: GAME OVER :::::");
// ***** End Conditionals *****



// ***** Operators *****
// var answer = string.Empty;
// var options = new List<string> { "s", "n" };

// Console.WriteLine(":::::::::::::::::::::::::::::::::::");
// Console.WriteLine("::::: EJERCICIO DE OPERADORES :::::");
// Console.WriteLine(":::::::::::::::::::::::::::::::::::");

// do
// {
//     try
//     {
//         var n1 = ConsoleExtension.GetInt("Ingrese el primer número.: ");
//         var n2 = ConsoleExtension.GetInt("Ingrese el segundo número: ");

//         var suma = CalcularSuma(n1, n2);
//         var resta = CalcularResta(n1, n2);
//         var multip = CalcularMultiplicacion(n1, n2);
//         var divis = CalcularDivision(n1, n2);

//         Console.WriteLine($"La suma es..........: {suma}.");
//         Console.WriteLine($"La resta es.........: {resta}.");
//         Console.WriteLine($"La multiplicación es: {multip}.");
//         Console.WriteLine($"La división es......: {divis}.");
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Error: {ex.Message}");
//     }

//     do
//     {
//         answer = ConsoleExtension.GetValidOptions("¿Deseas continuar? ¿[S]í, [N]o?: ", options);
//     }
//     while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
// }
// while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
// Console.WriteLine("::::: GAME OVER :::::");


// double CalcularSuma(int n1, int n2)
// {
//     var suma = n1 + n2;
//     return suma;
// }

// double CalcularResta(int n1, int n2)
// {
//     var resta = n1 - n2;
//     return resta;
// }

// double CalcularMultiplicacion(int n1, int n2)
// {
//     var multip = n1 * n2;
//     return multip;
// }

// double CalcularDivision(int n1, int n2)
// {
//     var divis = (double)n1 / (double)n2;

//     if (n2 <= 0)
//     {
//         throw new Exception("No se puede dividir por cero.");
//     }
//     return divis;
// }
// ***** End Operators *****
