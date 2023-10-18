// Задача 25.
// Напишите цикл, который принимает на вход 2 числа (A и B) и возводит A в натуральную степень B.

static int Pow(int val1, int val2)
{
    int res = 1;
    for (int i = 1; i <= val2; i++)
    {
        res = res * val1;
    }
    return res;
}
Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = Pow(A, B);
Console.WriteLine($"Результат: {C}");