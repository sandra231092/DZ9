//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM >= 0 && numberN >= 0)
{
    int sum = PrintSumMtoN (numberM, numberN);
    Console.WriteLine($"A(m,n) = {sum}");
}
else
{
    Console.WriteLine("Число M и число N не должны быть отрицательными");
}

int PrintSumMtoN (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return PrintSumMtoN (m - 1, 1);
    }
    else
    {
        return PrintSumMtoN (m - 1, PrintSumMtoN (m, n - 1));
    }
}
