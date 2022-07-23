// Программа, которая выводит сумму натуральных чисел в промежутке от M до N
int SumOfNumbers (int startUserNumber, int endUserNumber)
{
    if (startUserNumber == endUserNumber)
    return startUserNumber;
    else
    {
        int result = 0;
        result = startUserNumber + SumOfNumbers (startUserNumber + 1, endUserNumber);
        return result;
    }

}

Console.WriteLine ("Введите число M: ");
int m = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число N: ");
int n = Convert.ToInt32 (Console.ReadLine ());
if (n > m)
{
    Console.WriteLine ($"M = {m}; N = {n} -> {SumOfNumbers (m, n)}");
}
else Console.WriteLine ("Число N должно быть больше числа M. Попробуйте снова");
