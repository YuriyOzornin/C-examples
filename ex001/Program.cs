﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

 Console.Write("Enter first number..."); 
 int Number1 = Convert.ToInt32(Console.ReadLine()); 
 Console.Write("Enter second number..."); 
 int Number2 = Convert.ToInt32(Console.ReadLine()); 
 int max = 0;

 if (Number1 > Number2)
 {
     max = Number1;
 }
 else
 {
     max = Number2;
 }
 Console.WriteLine("max" + max);