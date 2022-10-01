//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int[] arrayPalindrom = {0, 0, 0, 0, 0}; 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[0] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[1] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[2] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[3] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[4] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Your array is: " + arrayPalindrom[0] + arrayPalindrom[1] + arrayPalindrom[2] + arrayPalindrom[3] + arrayPalindrom[4]); 
 
if ((arrayPalindrom[0] == arrayPalindrom[4]) && (arrayPalindrom[1] == arrayPalindrom[3])) 
{ 
    Console.WriteLine("This number is palindrome!"); 
} 
else 
{ 
    Console.WriteLine("This number is normal"); 
}
