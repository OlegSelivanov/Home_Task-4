/*
Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.
Не использовать Math.Pow

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int B = Convert.ToInt32(Console.ReadLine());
ToDegree(A, B);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Число {a} в степени {b} = {result}");
}
