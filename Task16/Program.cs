// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите целое число A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B ");
int b = Convert.ToInt32(Console.ReadLine());

if (CheckSquareNumber(a, b) || CheckSquareNumber(b, a))
{
    Console.WriteLine ("Да");
}
else 
{
    Console.WriteLine ("Нет");
}


bool CheckSquareNumber(int first, int second)
{
    return first * first == second;
}