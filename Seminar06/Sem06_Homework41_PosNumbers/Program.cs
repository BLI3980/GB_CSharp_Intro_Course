//Task: Several numbers are entered through the console. Find out how many of them are larger than zero.

// Console.WriteLine("Enter how many numbers you want to see listed: ");
// int m = Convert.ToInt32(Console.ReadLine());

// void FillPrintArray(int[] arr) //Randomly fill and print an array of m elements
// {
//     Console.WriteLine();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9, 9);
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }

// int PosElements(int[] arr) //Finding out how many positive elements in the array
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) count++;
//     }
//     return count;
// }

// int[] array = new int[m];

// FillPrintArray(array);
// int count = PosElements(array);
// Console.WriteLine("The amount of elements larger than zero is: " + count);
// Console.WriteLine();

//OPTION 2 ==================================================
Console.WriteLine("Enter how many numbers you want to see listed: ");
int m = Convert.ToInt32(Console.ReadLine());

void FillPrintArray(int[] arr) //Randomly fill and print an array of m elements
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[] array = new int[m];

FillPrintArray(array);

int count = 0;
void CountPositive(int i) //Count positive elements using recursion version 1
{
    if (i == m) return;
    if (array[i] > 0) count++;
    CountPositive(i + 1);

}

// int CountPositive(int i)//Count positive elements using version 2.
// {
//     if (i < m)
//     {
//         if (array[i] > 0) count++;
//         CountPositive(i + 1);
//     }
//     return count;
// }


CountPositive(0);
Console.WriteLine(count);







