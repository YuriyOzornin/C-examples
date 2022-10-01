//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Enter number...");
void Progressive()
{
    Console.WriteLine("number A");
    int numberA = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("number B");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int result = numberA;
   for(int i=1; i<= numberB;i++)
   {
       result *= numberA;
       Console.WriteLine(result);      
   }
   Console.WriteLine(result);
}
Progressive();