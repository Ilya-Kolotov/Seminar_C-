﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите целое число A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B ");
int b = Convert.ToInt32(Console.ReadLine());

int Div(int first, int second)
{
    int result = first % second;
    return result;
}

if (Div(a, b) == 0)
{
    Console.WriteLine("Кратно");
}
else 
{
     Console.WriteLine("Не кратно");
}