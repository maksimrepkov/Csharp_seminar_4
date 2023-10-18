// Задача 27. 
// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

static int FindSum(int value)
{
    int res = 0;
    while (value > 0)
    {
        res = res + value % 10;
        value = value / 10;
    }
    return res;
}
Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int sum = FindSum(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sum}");