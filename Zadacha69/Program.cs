/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

void StepenNumber(int a, int b, int count = 0, int rez = 1)
{
    Console.WriteLine($"{a},{b},{count},{rez}");
    if (count == b)
    {
        Console.WriteLine($"{rez}");
        return;
    }
    rez = rez * a;
    count++;
    StepenNumber(a, b, count, rez);
}
StepenNumber(3, 5);
