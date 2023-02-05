// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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



// // 2 8 2 3
// for (int k = 0; k < matrix.GetLength(1); k++)
//     {   
//         int MaxPosition = k;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//         if (matrix [0,j] > matrix [0,j])
//         int temp = 0;
//         temp = matrix [0,j];
//         matrix [0,j] = matrix [0,j];
//         matrix [0,j] = temp;
//         }
//     }



// Console.WriteLine();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите число строк (столбцов) прямоугольного массива: ");
// int m = Convert.ToInt32(Console.ReadLine()); 
// int[,] matrix = new int[m,m];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         matrix [i,j] = new Random().Next(0, 10);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// int k = 0;
// int temp = 250;
// int temp1 = 0;
// while (k != m)
// {
//     int sum = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//     sum = sum + matrix [k,j];
//     }
//     k++;
//     Console.WriteLine($"Сумма {k} строки {sum}"); 
//     if (temp > sum)
//     {
//         temp1 = k;
//         temp = sum;
//     }
//     sum = 0;
// }
// Console.WriteLine($"Номер строки с наименьшей суммой элементов в строке: {temp1}; эта сумма оказалась {temp}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите размерности матриц: ");
// int m = Convert.ToInt32(Console.ReadLine()); 
// int[,] matrix1 = new int[m,m];
// for (int i = 0; i < matrix1.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix1.GetLength(1); j++)
//     {   
//         matrix1 [i,j] = new Random().Next(0, 10);
//         Console.Write($"{matrix1[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// int[,] matrix2 = new int[m,m];
// for (int i = 0; i < matrix2.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix2.GetLength(1); j++)
//     {   
//         matrix2 [i,j] = new Random().Next(0, 10);
//         Console.Write($"{matrix2[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// int[,] matrix3 = new int[m,m];
// Console.WriteLine("Результирующая матрица произведения: ");
// for (int i = 0; i < matrix3.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix3.GetLength(1); j++)
//     {   
//         matrix3 [i,j] = matrix2 [i,j] * matrix1 [i,j];
//         Console.Write($"{matrix3[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Write("Введите число строк (столбцов) прямоугольного массива: ");
// int m = Convert.ToInt32(Console.ReadLine()); 
// int[,,] matrix = new int[m,m,m];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         for (int k = 0; k < matrix.GetLength(2); k++)
//         {   
//         matrix [i,j,k] = new Random().Next(10, 100);
//         Console.Write($"{matrix[i, j, k]} ");
//         }
//     }
//     Console.WriteLine();
// }
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] matrix = new int[4,4];
// for (int j = 0; j < matrix.GetLength(1); j++)
// {   
//     int i = 0;
//     matrix [i,j] = 1 + i;
//     Console.WriteLine($"{matrix[i, j]}");
// }
// Console.WriteLine();

// // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
// int a = 0;
// int b = matrix.GetLength(1) - 2;
// for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         a = matrix [0,j];
//         matrix [0,j] = matrix [b,j];
//         matrix [b,j] = a;
//     }
// Console.WriteLine();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Console.Write("Введите число строк m: ");
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число столбцов n: ");
// int n = Convert.ToInt32(Console.ReadLine()); 
// int[,] matrix = new int[m,n];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         matrix [i,j] = new Random().Next(0, 10);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// if (m == n)
// {
// int a = 0;
// int i = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         a = matrix [i,j];
//         matrix [i,j] = matrix [j,i];
//         matrix [j,i] = a;
//     }
// i++;
// for (int j = 1; j < matrix.GetLength(1); j++)
//     {   
//         a = matrix [i,j];
//         matrix [i,j] = matrix [j,i];
//         matrix [j,i] = a;
//     }

// i++;
// for (int j = 2; j < matrix.GetLength(1); j++)
//     {   
//         a = matrix [i,j];
//         matrix [i,j] = matrix [j,i];
//         matrix [j,i] = a;
//     }
// i++;
// for (int j = 2; j < matrix.GetLength(1); j++)
//     {   
//         a = matrix [i,j];
//         matrix [i,j] = matrix [j,i];
//         matrix [j,i] = a;
//     }
// }
// else
// {
//  Console.Write("Не получится");
// }
// Console.WriteLine();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника