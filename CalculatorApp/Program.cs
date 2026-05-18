namespace CalculatorAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Сумма 5 + 3");
            Console.WriteLine(calculator.Add(5, 3));
        }
    }
}