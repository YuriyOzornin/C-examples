//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

 double Number1 = new Random().Next(); 
 Console.WriteLine(Number1); 
 double Number2 = new Random().Next(); 
 Console.WriteLine(Number2); 
 double Number3 = new Random().Next(); 
 Console.WriteLine(Number3); 
 double MaxNumber = Number1; 

 if (Number2 > MaxNumber) 
 { 
     MaxNumber = Number2; 
 } 
 if (Number3 > MaxNumber) 
 { 
     MaxNumber = Number3; 
 } 
 Console.Write("Max number is " + MaxNumber);