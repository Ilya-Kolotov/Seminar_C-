// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }

    return sum;
}
if (a > 0)
{
    int sumNumbers = SumNumbers(a);
    Console.WriteLine($"Сумма чисел от 1 до {a} = {sumNumbers}");
}
else Console.WriteLine("Введено некорректное число. Введите положительное число");