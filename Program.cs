// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] nums = new int[10];
// void array(int[] nums)
// {
// Console.Write("[");
// for (int i = 0; i < nums.Length; i++)
//  {
//     nums [i] = new Random().Next(100, 1000);
//     Console.Write($"{nums [i]}, ");
//  }
// Console.Write("]");
// }
// array(nums);

// int b = 0; 
// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] % 2 == 0)
//     {
//         b = b + 1; 
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Число чётных цифр в массиве: {b}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

// int [] nums = new int[10];
// void array(int[] nums)
// {
// Console.Write("[");
// for (int i = 0; i < nums.Length; i++)
//  {
//     nums [i] = new Random().Next(0, 20);
//     Console.Write($"{nums [i]}, ");
//  }
// Console.Write("]");
// }
// array(nums);

// int sum = 0; 
// for (int i = 0; i < nums.Length; i = i + 2)
// {
//  sum = nums [i] + sum;
// }
// Console.WriteLine();
// Console.Write($"Сумма элементов стоящих на нечётных позициях: {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76