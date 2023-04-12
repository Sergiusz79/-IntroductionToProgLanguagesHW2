// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Please enter number ");
int.TryParse(Console.ReadLine(), out int a);

int n = (int) Math.Log10(a);
int c = a / (int) Math.Pow(10, n-1) % 10;

Console.WriteLine($"The second digit is {c} ");
