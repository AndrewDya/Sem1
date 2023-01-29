// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите количество элементов массива, M: ");
// int M = Convert.ToInt32(Console.ReadLine()); 
// int [] nums = new int[M];
// for (int i = 0; i < nums.Length; i++)
//  {
//      Console.Write($"Введите элементы массива под индексом {i}: ");
//      nums[i] = Convert.ToInt32(Console.ReadLine()); 
//  }
// int sum = 0;
// for (int i = 0; i < nums.Length; i++)
// { 
//    if (nums[i] > 0)
//    { 
//       sum = sum + 1;
//    }
// }
// Console.WriteLine();
// Console.Write($"Чисел больше нуля ввёл пользователь: {sum}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Нашли решение системы уранений и заменили х и y найденными параметрами

Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine()); 

double x = 0;
double y = 0;
x = (b2 - b1) / (k1 - k2);
y = (k1 * x) + b2;
Console.Write($"Координаты пересечения прямых: ({x};{y})");