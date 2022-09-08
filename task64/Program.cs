//Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(N);

void PrintNumbersToN(int i)
{
    if (i < 1) return;
    Console.Write(i + ", ");
    PrintNumbersToN(i - 1);
}