namespace Shared;

public class ConsoleExtension
{
    public static int GetInt(string message)
    {
        Console.Write(message);
        var input = Console.ReadLine();
        if (int.TryParse(input, out int numberInt))
        {
            return numberInt;
        }
        throw new Exception("El valor ingresado no es válido.");
    }

    public static double GetDouble(string message)
    {
        Console.Write(message);
        var input = Console.ReadLine();
        if (double.TryParse(input, out double numberDouble))
        {
            return numberDouble;
        }
        throw new Exception("El valor ingresado no es válido.");
    }

    public static float GetFloat(string message)
    {
        Console.Write(message);
        var input = Console.ReadLine();
        if (float.TryParse(input, out float numberFloat))
        {
            return numberFloat;
        }
        throw new Exception("El valor ingresado no es válido.");
    }

    public static decimal GetDecimal(string message)
    {
        Console.Write(message);
        var input = Console.ReadLine();
        if (decimal.TryParse(input, out decimal numberDecimal))
        {
            return numberDecimal;
        }
        throw new Exception("El valor ingresado no es válido.");
    }

    public static string GetString(string message)
    {
        Console.Write(message);
        var input = Console.ReadLine()!.ToLower();
        if (!string.IsNullOrEmpty(input))
        {
            return input;
        }
        throw new Exception("El valor ingresado no es válido.");
    }

    public static string? GetValidOptions(string message, List<string> options)
    {
        Console.Write(message);
        var answer = Console.ReadLine();
        if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
        {
            return answer;
        }
        return null;
    }
}
