// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

 double[,] arr = new double[7, 12];
 void TwoDigitArr()
 {
 Random digit = new Random();
 for (int i = 0; i < 7; i++)
 {
     for (int j = 0; j < 12; j++)
     {
         arr[i, j] = digit.NextDouble() * 100; 
         // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
         Console.Write("{0,6:F2}", arr[i, j]); // 0,6 это расстояние между столбцами
                                              //  f2 - округление вещественных чисел в массиве
     }
     Console.WriteLine();
 }
 }
 TwoDigitArr();