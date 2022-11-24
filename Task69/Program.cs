// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Pow(int numA, int numB)
{
    return numB == 0 ? 1 : numA * Pow(numA, numB - 1);
}
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int pow = Pow(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {pow}");