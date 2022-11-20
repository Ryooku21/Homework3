// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.WriteLine("Введите натуральное число");
int anyNumber = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    if (num > 0)
    {
        int count = 1;
        while (count <= num)
        {
            Console.WriteLine($"{count,5}   {count * count * count,5}");
            count++;
        }
    }
    else
    if (num < 0)
    {
        int count = 1;
        while (count >= num)
        {
            Console.WriteLine($"{count,5}      {count * count * count,5}");
            count--;
        }
    }
    else
    if (num == 0)
    {
        Console.WriteLine("0 - некорректное значение, введите натуральное число!");
    }
}

Cube(anyNumber);