//Task: Fill up an array of 8 elements with randomly selected 1 or 0 values.

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i]);
}

