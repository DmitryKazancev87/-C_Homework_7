// 21. Программа, которая задает двумерный массив из целых чисел и находит среднее арифметическое
// элементов в каждом столбце.

int [,] CreataArray ()
{
int m = 3;
int n = 4;
int [,] array = new int[m,n];
int Row = array.GetLength(0);
int Column = array.GetLength(1);
for (int i=0; i< Row;i++)
{
    for (int j=0;j<Column;j++)
    {
        array[i,j]=new Random ().Next(1,10);
    }
}
return array;
}
void PrintArray (int [,] array)
{
int Row = array.GetLength(0);
int Column = array.GetLength(1);
    for (int i=0; i< Row;i++)
{
    for (int j=0;j<Column;j++)
    {
        Console.Write($"{array[i,j]} | ");
    }
    System.Console.WriteLine();
}
}

void Arif (int [,] array)
{
    int Row = array.GetLength(0);
    int Column = array.GetLength(1); 
    for (int j=0; j<Column;j++)
{
    int sum=0;
    for (int i=0; i<Row;i++)
    {
        sum+=array[i,j];
    }
    double average=(double)sum/Row;
    Console.WriteLine($"Среднее арифметическое столбца {j+1}: {average}; ");
    }
}
 Console.WriteLine();
int [,] array = CreataArray();
PrintArray(array);
Arif(array);