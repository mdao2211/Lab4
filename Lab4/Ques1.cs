using System;

public delegate int ArithmeticOperation(int a, int b);

class Program
{
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;

    // Modified Division method to handle division by zero
    static int Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return 0;
        }
        return a / b;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int result;

        ArithmeticOperation addOperation = Add;
        result = addOperation(a, b);
        Console.WriteLine($"{a} + {b} = {result}");

        ArithmeticOperation subtractOperation = Subtract;
        result = subtractOperation(a, b);
        Console.WriteLine($"{a} - {b} = {result}");

        ArithmeticOperation multiplyOperation = Multiply;
        result = multiplyOperation(a, b);
        Console.WriteLine($"{a} * {b} = {result}");

        ArithmeticOperation divideOperation = Divide;
        result = divideOperation(a, b);
        Console.WriteLine($"{a} / {b} = {result}");
    }
}
