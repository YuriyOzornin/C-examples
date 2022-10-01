// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

 Console.WriteLine("Enter x1...");
 int x1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter y1...");
 int y1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter z1...");
 int z1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter x2...");
 int x2 = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter y2...");
 int y2 = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter z2...");
 int z2 = int.Parse(Console.ReadLine());

 double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((y2 - y1), 2));
 Console.WriteLine("длинна отрезка"+result);

 Console.WriteLine($"A ({x1},{y1},{z2}); B ({x2},{y2},{z2}) -> {result}");

