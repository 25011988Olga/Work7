//Задача 50. Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.WriteLine("введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [5,5];

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
         for (int j = 0; j < matrix.GetLength(1); j++)
            matrix [i,j] =new Random().Next(0,10);
        }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j ]} \t");
            Console.WriteLine(); 
    }
}

void ReleaseMatrix(int[,] matrix)
{
   
     if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
    
    Console.WriteLine("такого элемента нет");
   
    else
   
    Console.WriteLine($"значение элемента в строке {n} и в столбце {m} равно {matrix[n-1,m-1]}");
   
}
InputMatrix(matrix);
ReleaseMatrix(matrix);
PrintMatrix(matrix);
