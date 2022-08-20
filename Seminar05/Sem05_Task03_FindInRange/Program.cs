//Create one-dimension array with 123 elements. Find out how many element in the array are in the range between 10 and 99

int[] array = new int[10]; //using 10 elements array as an example because 123 elements array is too long

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine();

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if ((array[i] >=10) && (array[i] <=99))
    {
        count++;
    }
}

Console.WriteLine($"The amount of of numbers in the range between 10 and 99 is: {count} times");