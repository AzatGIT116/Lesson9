//Рекурскией 
/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

void PlusFunt(int n, int temp = 1)
{
    if (temp > n)
        return;
    Console.Write($"{temp}");
    PlusFunt(n, temp + 1);
}
PlusFunt(6);