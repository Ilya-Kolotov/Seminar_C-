// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
bool Div(int first, int second)
{
    return first % second == 0;
}
int Multiple(int number1, int number2)
{
    return number1 % number2;
}

Console.Write("Введите целое число A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B ");
int b = Convert.ToInt32(Console.ReadLine());

if (Div(a, b))
{
    Console.WriteLine("Кратно");
}
else 
{
     Console.WriteLine("Не кратно");
}


int rest = Multiple(num1,num2);
Console.WriteLine(rest == 0? "Кратно" : $"не кратно, остаток {rest}");
