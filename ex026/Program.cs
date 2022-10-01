//  Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.

int rows = 2;
int columns = 6;

int [,] NewArray(int m, int n)
{
    var result = new int[m,n];
    for(int i=0;i<m; i++)
    {
        for(int j=0;j<n; j++)
        {
            result [i,j] = new Random().Next(100);
        }
    }
    return result;
}

double[] GetAvePerColumn(int[,] array) 
{ 
    var result = new double[array.GetLength(1)]; 
 
    for (int i = 0; i < array.GetLength(1); i++) 
    { 
        double sum = 0; 
 
        for (int j = 0; j < array.GetLength(0); j++) 
        { 
            sum += array[j, i]; 
        } 
        result[i] = Math.Round(sum / array.GetLength(0), 2); 
    } 
    return result; 
} 
 
void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]} "); 
        } 
        System.Console.WriteLine(); 
    } 
} 
 
int[,] arr = NewArray(rows, columns); 
 
PrintArray(arr); 
 
System.Console.WriteLine(); 
 
foreach (var item in GetAvePerColumn(arr)) 
{ 
    System.Console.WriteLine(item); 
}