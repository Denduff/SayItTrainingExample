public class program
{
    public static void Main()
    {
        float value1;
        float value2;
        float result;
        string type;
        //Prompt user for number
        Console.WriteLine("Enter your first numnber");
        //Save number in variable
        value1 = float.Parse(GetInput());
        Console.Clear();

        Console.WriteLine("Choose Operation\n+\n-\n*\n/");
        type = GetInput();

        Console.Clear();
        Console.WriteLine($"{value1} {type}\n");

        Console.WriteLine("Enter your second number");
        value2 = float.Parse(GetInput());

        result = Calculate(value1, value2, type);
        PrintResult(result, value1, value2, type);
        Console.ReadLine();
    }

    public static string GetInput()
    {
        string input = Console.ReadLine();
        return input;
    }

    public static float Addition(float val1, float val2)
    {
        float res = val1 + val2;

        return res;
    }

    public static float Subtraction(float val1, float val2)
    {
        float res = val1 - val2;
        return res;
    }

    public static float Multiplication(float val1, float val2)
    {
        float res = val1 * val2;
        return res;
    }

    public static float Division(float val1, float val2)
    {
        float res = (val1 / val2);
        return res;
    }

    public static void PrintResult(float result, float val1, float val2, string type)
    {
        Console.Clear();
        Console.WriteLine($"The result of {val1} {type} {val2} = {result}");
    }

    public static float Calculate(float val1, float val2, string type)
    {
        switch (type)
        {
            case "+":
                return Addition(val1, val2);
            case "-":
                return Subtraction(val1, val2);
            case "*":
                return Multiplication(val1, val2);
            case "/":
                return Division(val1, val2);
            default:
                throw new Exception("The chosen operation is not valid given the context");
        }
    }
}