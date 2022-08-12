// 1. Create new array filled with zeros; 2. Create a method to fill array; 3. Create a method to print filled array; 4. Create method to find a number
int[] array = new int [10];

void FillArray(int[] arrayFill)
{
    int size = arrayFill.Length;
    int count = 0;
    while (count < size)
    {
        arrayFill[count] = new Random().Next(1,10);
        count++;
    } 
}

void PrintArray(int[] arrayPr)
{
    int len = arrayPr.Length;
    int indx = 0;
    while (indx < len)
    {
        Console.Write(arrayPr[indx]+"  ");
        indx++;
    }
    if (indx == len) 
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
}

int FindIndex(int[]array, int find)
{
    int length = array.Length;
    int index = 0;
    int result = -1;
    while (index < length)
    {
        if (array[index] == find) 
        {
            result = index;
            break;
        }
        index++;
    } 
    return result;

}

FillArray(array);
PrintArray(array);

Console.WriteLine("Enter the number you want to find in this array:");
int numbFind = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
int indxPos = FindIndex(array, numbFind);

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
