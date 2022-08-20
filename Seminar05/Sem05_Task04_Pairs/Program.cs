//Create one-dimension array. Multiply pair of elements as first to last, second to last but one, etc.
//Example:
// [1 32 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int [5]; // Create an empty array

void FillPrintArray (int[] arr) // Method to fill an array
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next (1, 11);
        Console.Write(array[i] +" ");
    }
}

FillPrintArray(array); // Fill-up the array

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i <= array.Length/2-1; i++) // Multiply pairs
{

    Console.WriteLine($"{array[i] * array[array.Length - (i+1)]} ");

}
if (array.Length % 2 != 0)
{
    Console.WriteLine($"{array[array.Length/2]} ");
}






//Incorrect option//
// int[] array = new int[6];

// int length = array.Length;
// int index = 0;

// while(index < length)
// {
//     array[index] = new Random().Next(1, 11);
//      Console.Write($"{array[index]} ");
//     index++;
    
   
// }
// Console.WriteLine();
// for ( int i = 0; i <( (length / 2) + 1); i++)
// {
//     Console.WriteLine();
//     if (i != (length -i -1) )
//     {
//         Console.Write($"{ array[i] * array[length -i -1]} ");
        
//     }
//     else 
//     {
//     Console.WriteLine(array[i]);
//     }

// }





