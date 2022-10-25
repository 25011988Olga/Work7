//Задайте двумерный массив из целых чисел. Найдите 
//среднее арифметическое элементов в каждом столбце.

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,m];

void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
   {
     for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i, j] = new Random().Next(0,10);
      }
   }
}
void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i,j]} \t ");
        Console.WriteLine(); 
    }
}

void SredneeArifm(int[,] matrix)
{
  double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum = 0;  
     for (int i = 0; i < matrix.GetLength(0); i++)
      { 
        sum = sum + Convert.ToDouble(matrix[i,j]);
      }
     sum = Math.Round(sum/(matrix.GetLength(1)-1), 2);
        
    Console.WriteLine($"Среднее арифметическое столбцов{ j+1 }: {sum} \t ");

    }
}
    
InputMatrix(matrix);
PrintMatrix(matrix);
SredneeArifm(matrix);
