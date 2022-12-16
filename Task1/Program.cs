/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//запросить натуральное число
int GetNumber (string numStr)
{
    bool isNum = false;
    int num = 0;
    
 
    while (!isNum)
    {   
        if (int.TryParse(numStr, out num) && num > 0)
            isNum = true;
        else 
        {
            Console.WriteLine("Некорректный ввод числа. Введите число > 0:");
            numStr = Console.ReadLine() ?? "";
        }
    }
    return num;
}

//получить заполненный массив рандомными числами
int[] InitArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();

    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

//распечатать массив на консоль 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

//найти количество четных элементов
int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
            count ++;
    }
    return count;
}

Console.WriteLine("Введите колличество элементов массива");
int len = GetNumber(Console.ReadLine() ?? "");
int[] array = InitArray(len);
//int count = ;

PrintArray(array);
Console.WriteLine($"Количество четных элементов в массиве = {CountEven(array)}");
