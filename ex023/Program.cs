// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int CountPositivEnteredNumbers(int countOfNumbers) // первый вариант ввода чисел
// {
//     Console.WriteLine($"Введите {countOfNumbers} целых чисел...");

//     int[] arrayEnteredNumbers = new int [countOfNumbers];
//     int count=0;

//     for (int i = 0; i < countOfNumbers; i++)
//     {
//         arrayEnteredNumbers[i] = Convert.ToInt32(Console.ReadLine()); 
//         if(arrayEnteredNumbers[i]> 0)
//         {
//             count++;
//         } 

//     }


//     Console.WriteLine($"Введённые числа: {String.Join(", ", arrayEnteredNumbers)}");
    
//     return count;
// }
// Console.WriteLine(CountPositivEnteredNumbers(10)); 


void EnteredNumbersFromUser() // второй вариант ввода чисел
 {
     Console.Write("Введите элементы(через пробел): ");

     int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // Разделяем строку 
     //на несколько или один разделитель, то есть поэлементно.
     int count = 0;
    
     for (int i = 0; i < arr.Length; i++)
     {
         if (arr[i] > 0)
         {
             count++;
         }
     }
    
     Console.WriteLine($"Кол-во элементов > 0: {count}");
 }
 EnteredNumbersFromUser();