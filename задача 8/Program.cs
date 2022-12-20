// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите правую границу диапазона чисел: ");
int A = int.Parse(Console.ReadLine());
int N = 2;
while ( N <= A )
{
    Console.Write($"{N} ");
    N = N + 2;
}