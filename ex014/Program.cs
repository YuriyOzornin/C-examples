// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

 Console.WriteLine("Enter number...");
 int number = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Таблица кубов");

 for(int i = 1;i<=number;i++)
 {
         Console.WriteLine(Math.Pow(i,3));
         Console.WriteLine("");
        
 }