namespace LAB03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            int dif = a - b;
            int product = a * b;
            double mean = (a + b) / 2;

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разность: {dif}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Среднее арифметическое: {mean}");
        }
    }
}
