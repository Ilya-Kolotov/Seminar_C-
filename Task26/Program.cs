// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int CountDigits(int number)
{
    int count = 0;
    while (number != 0)
    {
        count++;
        number = number / 10;
    }
    return count == 0 ? 1 : count;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int countDigits = CountDigits(num);
Console.WriteLine($"В числе {num} - {countDigits} цифр");