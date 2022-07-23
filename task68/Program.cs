internal class Program
{
    private static void Main(string[] args)
    {
        int AckermannFunction (int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return AckermannFunction (m - 1, 1);
            }
            else return AckermannFunction (m - 1, AckermannFunction (m, n - 1));
        }

        Console.Write("Введите неотрицательное целое число m: ");
        int firstUserNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите неотрицательное целое число n: ");
        int secondUserNumber = Convert.ToInt32(Console.ReadLine());
        if (firstUserNumber >= 0 && secondUserNumber >= 0)
        {
            int res = AckermannFunction (firstUserNumber, secondUserNumber);
            Console.Write($"m = {firstUserNumber}, n = {secondUserNumber} -> A (m, n) = {res}");
        }
        else Console.WriteLine("Числа m и n не могут быть отрицательными. Повторите ввод");
    }
}