
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] numbers = new int[8];
Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 2);
    Console.Write($"{numbers [i]}, ");
 }
Console.Write("]");

// Теория
// Push an existing repository from the command line
// git remote add origin https://github.com/AndrewDya/Sem1.git
// git branch -M master
// git push -u origin master
// || или (одно из условий должно выполняться); && и (оба условия должны выполняться)
// int a = new Random().Next(1,3); генерация случайного числа от 1 до 3
// for (int i = 0; i < 10; i++) цикл с условием
// Console.WtiteLine(Math.Abs(y)) модуль
// Console.WtiteLine(Math.Round(y, 2)) округление до 2 знаков после запятой
// dotnet new console - создать новый проект
// dotnet run - запустить проект
// % отстаток от деления: 22 % 2 == 0
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// Вводится число 
// string[] fact - массив строк название fact
// int[] numbers - массив числовой название numbers
// Console.WriteLine(f.Length) - вывести длину массива
// for (int i = 0; i < numbers.Length; i++)
// {
//  Console.WriteLine(numbers.Length);
// }
// double num = Math.Sqrt(x); квадратный корень
// double num = Math.Pow(x, 3); возведение в степень
// Методы 
// void SayLang()- метод (1) который ничего НЕ принимает, ничего НЕ возвращает
// метод (2) который принимает, но НЕ возвращает
// метод (3) который ничего НЕ принимает, но возвращает
// метод (4) который принимает и возвращает