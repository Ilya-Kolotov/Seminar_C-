// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите целое число A ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((Multiple(num, 7) && Multiple(num, 23)) ? "Да" : "Нет");

 
bool Multiple(int first, int second)
{
    return first % second == 0;
}