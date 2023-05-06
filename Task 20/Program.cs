// 20. Программа, которая на вход принимает позиции элементов в двумерном
// массиве и возвращает значение этого элемента или же указывает, что такого элемента нет.

int [,] CreataArray ()
{
int m = 3;
int n = 3;
int [,] array = new int[m,n];
for (int i=0; i< array.GetLength(0);i++)
{
    for (int j=0;j<array.GetLength(1);j++)
    {
        array[i,j]=new Random ().Next(-10,10);
    }
}
return array;
}
System.Console.WriteLine("Введите позицию элемента в массиве : ");
System.Console.Write(" 1. Введите номер строки : ");
int Row = int.Parse(System.Console.ReadLine()!);
System.Console.Write(" 2. Ввведите номер столбца : ");
int Column = int.Parse(System.Console.ReadLine()!);

if (Row>=array.GetLength(0) || Column>=array.GetLength(1))
{
    System.Console.WriteLine("Такого элемента нет в массиве! ");
}
else
{
    System.Console.WriteLine($"Значение элемента: {array[Row,Column]}");
}

int [,] array = CreataArray();




// EnterInfomation(string message)
//{
//Console.Write(message);
//return int.Parse(Console.ReadLine()!);
//}
//double b1 = EnterInfomation(" Ввведите значение b1 : ");
//double k1 = EnterInfomation(" Ввведите значение k1 : ");
//double b2 = EnterInfomation(" Ввведите значение b2 : ");
//double k2 = EnterInfomation(" Ввведите значение k2 : ");