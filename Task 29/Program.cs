/* Задача 29: 
Напишите программу, которая спрашивает у пользователя кол-во элементов массива,
затем сами элементы. Программ должна вывести массив на экран.

8
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

Console.Clear();

Console.WriteLine("Введите кол-во элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа массива: ");

int[] array = new int[N];

    for (int i = 0; i < N; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
Console.WriteLine($"{String.Join(", ", array)}");
Console.WriteLine($"Введённый массив: [{String.Join(", ", array)}]");
     