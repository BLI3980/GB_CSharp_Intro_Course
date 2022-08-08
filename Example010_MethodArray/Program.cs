//Finding an element of an array which matches given number and outputting found element index

int[] array = {50, 92, 87, 77, 64, 58, 41, 77, 62, 31};

int size = array.Length;
Console.Write("Enter a number you want to find in the array: ");
int find = Convert.ToInt32(Console.ReadLine());
int index = 0;
int result = -1;

while (index < size)
{
    if(array[index] == find) 
    {
        result = index;
        break;
    }
    index++;
}

if (result == -1)
{
    Console.WriteLine("No such number in given array");
}
else
{
    Console.WriteLine($"The index of this number in given array is: {result}");
}
