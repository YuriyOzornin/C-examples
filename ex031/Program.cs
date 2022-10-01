//Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int n = 4;
int[,] fillingMatrix = new int[n, n];

int count = 1;
int i = 0;
int j = 0;

while (count <= fillingMatrix.GetLength(0) * fillingMatrix.GetLength(1))
{
  fillingMatrix[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < fillingMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= fillingMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > fillingMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(fillingMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}