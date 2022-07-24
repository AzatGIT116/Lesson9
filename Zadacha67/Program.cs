/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

void SumFunt(int num, int sum = 0)
{
    Console.WriteLine($"{num} {sum}");
    if (num == 0)
    {
        Console.Write($"{sum}");
        return;
    }

    sum += num % 10;
    num = num / 10;

    SumFunt(num, sum);
}
SumFunt(123456);