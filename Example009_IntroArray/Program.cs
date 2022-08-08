//Introduction to arrays

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// //             0   1   2   3    4   5    6  7   8
// int[] array = {21, 52, 36, 458, 45, 36, 77, 80, 49};

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8]));

// Console.WriteLine(result);

//===============================================
//Repeat all
//             0   1   2   3   4   5   6   7   8   9
int[] array= {50, 92, 87, 73, 64, 58, 41, 93, 62, 31};

int Max(int A, int B, int C)
{
    int result = A;
    if (B > result) result = B;
    if (C > result) result = C;
    return result;
}

int max1 = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

int max = array[9];
if (max1 > max) max = max1;

Console.WriteLine(max);