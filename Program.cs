// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Stepen(int a, int b)
// {
//     int st = 1;
//     for(int i = 1; i<=b; i++)
//         st = st * a;
//     return st;
// }

// Console.Write("Enter your number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter your number b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int st = Stepen(a, b);
// Console.WriteLine("Ответ: " + st);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// int Counter(int a)
// {
//     if (a < 10)
//     return a;
//         int dig = a % 10;
//         int next = a /10;
//     return dig + Counter(next);
    
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = Counter(num);

// Console.WriteLine($"Сумма цифр числа {num} равно {res}");

// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.




// int[] Array(int numb)
// {
//     int [] arr = new int [1];
//     for (int i = 0; i < arr.Length; i++)
//     {
//     {
//         arr[i] = new Random().Next(0,99);
//     }
//     }
// }

// void PrintArry(int[] ad)
// {
//   int count = ad.Length;
//   int i = 0;
//   Console.Write("[");
//   while(i < count)
//   {
//     Console.Write(ad[i]);
//     i++;
//     if (i < count)
//     {
//       Console.Write(", ");
//     }
//   }
//   Console.Write("]");
// } 
// System.Console.WriteLine("Write");
// int LengthMass = Convert.ToInt32(Console.ReadLine());
// PrintArry(Array(LengthMass));
