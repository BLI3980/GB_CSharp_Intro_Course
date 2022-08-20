//Task: An array is given. Change positive numbers to negative and vice versa

int[] array = new int[12];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine();


for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
    Console.Write(array[i] + " ");
}