// 19. Программа, которая задает двумерный массив размером m*n,
// заполненный случайными вещественными числами.

double [,] CreataArray ()
{
double [,] array = new double[3,4];
for (int i=0; i< array.GetLength(0);i++)
{
    for (int j=0;j<array.GetLength(1);j++)
    {
        array[i,j]=new Random ().Next(-10,10);
    }
}
return array;
}
void PrintArray (double [,] array)
{
    for (int i=0; i< array.GetLength(0);i++)
{
    for (int j=0;j<array.GetLength(1);j++)
    {
        Console.Write($"{array[i,j]} | ");
    }
    System.Console.WriteLine();
}
}
double [,] array = CreataArray();
PrintArray(array);


// EnterInfomation(string message)
//{
//Console.Write(message);
//return int.Parse(Console.ReadLine()!);
//}
//double b1 = EnterInfomation(" Ввведите значение b1 : ");
//double k1 = EnterInfomation(" Ввведите значение k1 : ");
//double b2 = EnterInfomation(" Ввведите значение b2 : ");
//double k2 = EnterInfomation(" Ввведите значение k2 : ");
// формула нахождения точки для уравнений y=k1*x+b1, y=k2*x+b2 будет выглядеть так:
// x= (-b2+b1)/(-k1+k2) y = k2*x+b2.

//double x=(-b2+b1)/(-k1+k2);
//double y =k2*x+b2;

//System.Console.Write($"Две прямые пересекуться в точке с координатами X: {x}, Y; {y}");
