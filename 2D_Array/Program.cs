
int [,] array2D = new int [5, 5];

int n = 5;

int row = 0, col = 0, m = n, i = 1;
array2D [row, col] = 0;

//Console.WriteLine();

while ( m > 0 )
{
    for (int counter = 0; counter < m; counter++)
    {
        array2D [row, col] = i;
        //Console.Write($"[{row}, {col}: {array2D[row,col]}]  ");
        col++;
        i++;
    }
    row++; col--; m--;
    for (int counter = 0; counter < m; counter++)
    {
        array2D [row, col] = i;
        //Console.Write($"[{row}, {col}: {array2D[row,col]}]  ");
        row++;
        i++;
    }
    row--; col--;
    for (int counter = 0; counter < m; counter++)
    {
        array2D [row, col] = i;
        //Console.Write($"[{row}, {col}: {array2D[row,col]}]  ");
        col--;
        i++;
    }
    row--; col++; m--;
    for (int counter = 0; counter < m; counter++)
    {
        array2D [row, col] = i;
        //Console.Write($"[{row}, {col}: {array2D[row,col]}]  ");
        row--;
        i++;
    }
    row++; col++;
}
// Console.WriteLine();
// Console.WriteLine();

row = 0; col = 0;
Console.WriteLine();
Console.WriteLine("[row, column, array number]");
Console.WriteLine();

for (col = 0; col < n; col++)
{
Console.Write($"[{row}, {col}: {array2D[row,col]}]   ");
}
Console.WriteLine();
row++;

while (row < n)
{
    for (col = 0; col < n; col++)
    {
    Console.Write($"[{row}, {col}: {array2D[row,col]}]  ");
    }
    Console.WriteLine();
    row++;
}
Console.WriteLine();
Console.WriteLine();




