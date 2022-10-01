// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 Console.Write("Enter number of day"); 
 int number = Convert.ToInt32(Console.ReadLine()); 
 if (number >= 1 && number <=5) 
 {
     Console.WriteLine("is not Day off");
 }
 else if (number==6 || number ==7)
 {
     Console.WriteLine ("This is Day Off");
 }
 else 
 {
   Console.WriteLine("data entry error");
 }