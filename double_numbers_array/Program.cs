// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void GetArray(double[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
       arr[index] = new Random().Next(10, 200);
       Console.Write($"{arr[index]}, ");
    }
    Console.WriteLine();
}
double GetMaxMin(double[] Numbers)
{
    int length = Numbers.Length;
    double MaxNum = Numbers[0];
    double MinNum = Numbers [0];
    double Diff = 0;
    for (int i = 0; i < length; i++)
    {
        if (Numbers[i] > MaxNum)  MaxNum = Numbers[i];   
        else if (Numbers[i] < MinNum)  MinNum = Numbers[i];
    }
    Diff = MaxNum - MinNum;
Console.WriteLine($"разница между max и min элементами в массиве: {Diff}");
return Diff;
}
double[] Numbs = new double[10];
GetArray(Numbs);
GetMaxMin(Numbs);

