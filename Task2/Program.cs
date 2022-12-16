/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        array[i] = rnd.Next(0, 50);
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

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if( i % 2 == 0)
            sum += array[i];
    }
    return sum;
}


Console.WriteLine("Введите колличество элементов массива");
int len = GetNumber(Console.ReadLine() ?? "");
int[] array = InitArray(len);

PrintArray(array);
Console.WriteLine($"сумма элементов на четных позициях = {GetSum(array)}");