//Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N)
{
    Console.WriteLine("Число М не может быть больше N");
}
else
{
   int sum = PrintSumMtoN (N, M); 
   Console.WriteLine(sum);
}

int PrintSumMtoN(int n, int m)
{
    if (n < m) return 0;
    int sum = PrintSumMtoN(n - 1, m);
    return sum += n;
}
