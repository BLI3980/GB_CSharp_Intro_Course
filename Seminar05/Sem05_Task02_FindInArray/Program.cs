//Task: Create a randomly filled array. Find out if a given number exists in created array (output index of array element if it exists)

void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next (-100,100);
    }
}

void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr [i]} ");
    }
}

int FindIndex(int[]arr, int find)
{
    int length = arr.Length;
    int index = 0;
    int result = -1;
    while (index < length)
    {
        if (arr[index] == find) 
        {
            result = index;
            break;
        }
        index++;
    } 
    return result;

}

int [] array = new int [5];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Enter the number you want to find in this array:");
int numbFind = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");

int indxPos = FindIndex(array, numbFind); //Calling for created method FindIndex by new variable indxPos

if (indxPos == -1) 
{
    Console.WriteLine("There is no such number in this array");
    Console.WriteLine(" ");
}
else
{
    Console.WriteLine($"This number is under {indxPos} position in this array");
    Console.WriteLine(" ");
}