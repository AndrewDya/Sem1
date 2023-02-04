// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] matrix = new double[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j] = new Random().Next(-10, 10);
//         matrix [i,j] = matrix [i,j] / new Random().Next(1, 10);
//         Console.Write($"{Math.Round(matrix[i, j], 2)} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.Write("Введите строку m: ");
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите столбец n: ");
// int n = Convert.ToInt32(Console.ReadLine()); 
// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         matrix [i,j] = new Random().Next(0, 10);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// if (m <= matrix.GetLength(0) && n <= matrix.GetLength(1))
// {
//     Console.Write($"Под индексом ({m},{n}), находится элемент: {matrix[m, n]} ");
// }
// else
// {
//     Console.Write("Такого элемента нет в массиве");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         matrix [i,j] = new Random().Next(0, 10);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// double sum1 = 0;
// for (int j = 0; j < matrix.GetLength(1); j++)
// {   
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {   
//         sum1 = sum1 + matrix[i, j];
//     }
//     double sum2 = sum1 / 3;
//     sum1 = 0;
// Console.WriteLine($" Среднее арифметическое {j} столбца = {Math.Round(sum2, 2)}");
// }

// Бонусная задача
// x1 ^ 5 + x2 ^ 5 + x3 ^ 5 + x4 ^ 5 = x5 ^ 5
// Сумма 4 чисел в 5 степени равна пятому числу в пятой степени
// Нужно найти эти числа
// 5 в 1 степени	5
// 5 в 2 степени	25
// 5 в 3 степени	125
// 5 в 4 степени	625
// 5 в 5 степени	3125
// 5 в 6 степени	15625
// 5 в 7 степени	78125
// 5 в 8 степени	390625
// 5 в 9 степени	1953125
// 5 в 10 степени	9765625
// 5 в 11 степени	48828125
// 5 в 12 степени	244140625
// 5 в 13 степени	1220703125

int [] nums = new int[15];
for (int i = 0; i < nums.Length; i++)
 {
     nums[i] = Math.Pow(i, 5); 
     Console.Write($"Массив {nums[i]} ");
 }
