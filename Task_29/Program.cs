// задаёт массив из 8 элементов и выводит их на экран

int [] ArrayEight(int len)
{
    int[] arr = new int [len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0,9);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{arr[i]}");
    }
}
PrintArray(ArrayEight(8));