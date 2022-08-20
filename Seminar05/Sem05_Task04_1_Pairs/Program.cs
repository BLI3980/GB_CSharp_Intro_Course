//Задание: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

void FillPrintArray(int [] arr) // Метод для заполнения и печати массива
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next(-10, 10);
        Console.Write($"{arr [i]} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void MultArray (int [] arr) // Метод для произведения пар чисел, занесения в новый массив и вывода на печать
{
    //int [] newArr = new int [arr.Length/2]; // Массив для результата суммирования, если исходный массив состоит из четного кол-ва элементов
    int [] newArr = new int [arr.Length/2+1]; // Массив для результата суммирования, если исходный массив состоит из нечетного кол-ва элементов

    int length = arr.Length;
    for (int i = 0; i <= arr.Length/2-1; i++)
    {
        newArr[i] = arr[i]*arr[arr.Length - i - 1];
        Console.Write(newArr[i]+ " ");
    }
    if (arr.Length % 2 != 0) 
    {
        newArr[newArr.Length-1] = arr[arr.Length/2];
        Console.Write(newArr[newArr.Length-1]);
    }
}

int n = new Random().Next(2,11); // Случайный выбор размера исходного массива от 2 до 10
int [] array = new int [n]; // Исходный пустой массив

FillPrintArray(array); // Заполнение массива и вывод его на печать
MultArray(array); // Заполнение нового массива произведениями пары чисел и вывод его на печать
