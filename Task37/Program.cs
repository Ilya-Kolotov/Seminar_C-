// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] GetMultipleElem(int[] array)
{
    int len = array.Length;
    int even = len % 2;
    int[] MultipleElem = new int[len / 2 + even];
    int i = 0;
    while (i < len/2)
    {
        MultipleElem[i] = array[i] * array[len - 1 - i];
        i++;
    }
    if (even == 1) MultipleElem[i] = array[i];
    return MultipleElem;
}

int[] arr = CreateArrayRndInt(5, 0, 9);
PrintArray(arr);
int[] getMultipleElem = GetMultipleElem(arr);
PrintArray(getMultipleElem);