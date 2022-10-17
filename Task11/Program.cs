// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int RemoveSecondDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    return firstDigit * 10 + secondDigit;
}

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {num}");

int firstDigit = num / 100;
int secondDigit = num % 10;

// int result = firstDigit * 10 + secondDigit;
// Console.WriteLine(result);

int finalDigit = RemoveSecondDigit(num);
Console.WriteLine(finalDigit);