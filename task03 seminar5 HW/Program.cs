// Написать программу копирования массива
void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }

}

void PrintArray(int[] printArr)
{
    int size1 = printArr.Length;
    for (int m = 0; m < size1; m++)
    {
        Console.Write($"{printArr[m]} ");
    }
}
int[] origineArray = new int[10];
FillArray(origineArray);
Console.WriteLine("Массив, заполненный случайными числами:");
PrintArray(origineArray);
Console.WriteLine();
Console.WriteLine("Копия массива:");
PrintArray(origineArray);


