// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// Например:
//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine("Please enter number ");
int.TryParse(Console.ReadLine(), out int a);

int n = (int) Math.Log10(a);
int c = a / (int) Math.Pow(10, n-1) % 10;

Console.WriteLine($"The second digit is {c} ");
