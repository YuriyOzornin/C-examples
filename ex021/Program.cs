// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

double[] array = new double[15];
void MinMaxArray(double[] arr)
{
  double MinNum= 0;
  double MaxNum= 0;
  
  for(int i = 0; i < arr.Length; i++)
 {
    arr[i] = new Random().Next(-5,25);
    Console.Write(arr[i]+" ");
 }
   for (int i = 1; i < arr.Length; i++)
 {
    if (arr[i] < MinNum) MinNum = arr[i];
    if (arr[i] > MaxNum) MaxNum = arr[i];
     
 }
     Console.WriteLine($"Min number array {MinNum}\nMax number array {MaxNum}");
     Console.WriteLine($"{MaxNum - MinNum}");
}
MinMaxArray(array);