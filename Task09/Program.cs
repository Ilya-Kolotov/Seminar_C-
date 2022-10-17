// 9. Напишите программу, которая 
// выводит  случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапозона 10-99 -> {num}");

// int firstDigit = num / 10;
// int secondDigit = num % 10;

// int res = firstDigit;
// if (secondDigit > firstDigit) res = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num} = {res}");


// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа - {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа - {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num} - {result}");

// Console.Write($"Наибольшая цифра числа {num} = ");
// Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);

// int max = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа {num} - {max}");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра числа {num} - {maxDigit}");