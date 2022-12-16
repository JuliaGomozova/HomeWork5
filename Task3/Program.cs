/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

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
double[] InitArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();

    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.NextDouble();
    }
    return array;
}

//распечатать массив на консоль 
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double FindDiff(double[] array)
{
    double dif = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    dif = max - min;
    return dif;
}


Console.WriteLine("Введите колличество элементов массива");
int len = GetNumber(Console.ReadLine() ?? "");
double[] array = InitArray(len);

PrintArray(array);
Console.WriteLine($"разность максимально и минимального элементов массива = {FindDiff(array)}");
