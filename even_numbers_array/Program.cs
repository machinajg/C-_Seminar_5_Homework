//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void GetArray(int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
       arr[index] = new Random().Next(100, 1000);
       Console.Write($"{arr[index]}, ");
    }
    Console.WriteLine();
}
int GetEven(int[] arrev)
{
    int size = arrev.Length;
    int position = 0;
    int counteven = 0;
    while (position < size)
    {
        if (arrev[position] % 2 == 0)
        {
            counteven += 1;   
        }
        position++;
    }
    Console.WriteLine($"количество чётных чисел в массиве: {counteven}");
    return counteven;
}
int[]digs = new int[5];
GetArray (digs);
GetEven (digs);
