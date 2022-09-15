/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
 */

int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}
Console.WriteLine("Введите m для функции Аккермана:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n для функции Аккермана:");
int n = Convert.ToInt32(Console.ReadLine());
if ((n < 0) ^ (m < 0))
{
    Console.WriteLine("Числа не могут быть отрицательными");
}
else
{
    Console.WriteLine($"Функция аккремана при m={m} n={n} равняется {A(m, n)}");
}
