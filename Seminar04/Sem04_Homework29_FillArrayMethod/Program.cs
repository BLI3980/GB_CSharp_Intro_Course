//Task: Fill up an array of 8 elements and print them out in terminal.

//Данная задача практически идентична задаче, разобранной на семинаре. Поэтому, чтобы немного усложнить ее выполнение, я использовал методы.
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 10);
}

void PrintArray(int[] array)
{
    foreach (int i in array) Console.Write(i + " ");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);