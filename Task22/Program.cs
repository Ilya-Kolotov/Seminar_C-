// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
    Console.WriteLine("Недопустимое число");
}
else
{
    Square(n);
}

void Square(int number)
{

    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i, 4} {i * i, 4}");
    }
}