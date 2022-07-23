// Программа, которая выведет все значения натуральных чисел в промежутке от M до N
string NumbersFromTo (int startUserNumber, int endUserNumber)
{
    if (startUserNumber == endUserNumber)
    return startUserNumber.ToString ();
    else
    {
        string userNumbers = String.Empty;
        userNumbers = startUserNumber.ToString () + " " + NumbersFromTo (startUserNumber + 1, endUserNumber);
        return userNumbers;
    }

}

Console.WriteLine ("Введите число M: ");
int m = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число N: ");
int n = Convert.ToInt32 (Console.ReadLine ());
if (n > m)
{
    Console.WriteLine ($"M = {m}; N = {n} -> {NumbersFromTo (m, n)}");
}
else Console.WriteLine ("Число N должно быть больше числа M, попробуйте заново");