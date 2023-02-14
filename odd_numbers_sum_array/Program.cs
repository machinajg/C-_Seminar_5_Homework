// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
       collection[index] = new Random().Next(1, 10);
       Console.Write($"{collection[index]}, ");
       index++;
    }   
    Console.WriteLine();
}
int GetOddSum (int[] odds)
{
    int size = odds.Length;
    // int position = 0;
    int SumOdds = 0;
    for(int position=0; position<size; position++)
    {
        if(position % 2 != 0)
        {SumOdds = SumOdds + odds[position];};
    }
    Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {SumOdds}");
    return SumOdds;
}
int[]Oddnum = new int[10];
FillArray(Oddnum);
GetOddSum(Oddnum);
