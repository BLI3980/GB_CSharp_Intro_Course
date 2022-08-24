//Task: Write a program which outputs reverse array of input array. 
//I.e. the first element of resulting array equals to the last element of input array and so on.
//Example: { 1 2 3 4 5} -> {5 4 3 2 1}

Console.WriteLine("Input the amount of elements in the input array: ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] arr) //Randomly fill an array
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] arr) //Print an array
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[] ReverseArray(int[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
    {
        result[i] = input[j];
    }
    return result;
}

int[] input = new int[n];
Console.Clear();
FillArray(input);
PrintArray(input);
PrintArray(ReverseArray(input));