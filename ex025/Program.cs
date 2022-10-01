// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

 bool Content(int[,] array, int element)
 {
     for(int i = 0; i < array.GetLength(0); i++)
     {
         for(int j = 0; j < array.GetLength(1); j++)
         {
             if (array [i,j] == element)
             {
                 return true;
             }
         }
     }
     return false;
 }
 void PrintArray(int [,] array)
 {
      for(int i = 0; i < array.GetLength(0); i++)
     {
         for(int j = 0; j < array.GetLength(1); j++)
         {
            Console.Write($"{array[i,j]} ");
         }
         System.Console.WriteLine();
     }
 }
 var Array = NewArray(rows,columns);
 PrintArray(Array);
 System.Console.WriteLine(Content(Array, 12));
 