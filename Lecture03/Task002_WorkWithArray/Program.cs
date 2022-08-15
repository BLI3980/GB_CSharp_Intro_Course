//Task: Sort the array

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) //Loop swaps found min element with current position
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++) //Loop searches for min element from i+1 till the last element
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int tempPosition = array[i];
        array[i] = array[minPosition];
        array[minPosition] = tempPosition;
    }
}

PrintArray(arr);
SelectSort(arr);

PrintArray(arr);



