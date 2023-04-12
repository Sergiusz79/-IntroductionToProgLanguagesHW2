// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Please enter number ");
int.TryParse(Console.ReadLine(), out int a);

int n = (int) Math.Log10(a);
if ( n > 1 )
{
    int c = a / (int) Math.Pow(10, n-2) % 10;
    Console.WriteLine($"The third digit is {c} ");
}
else
{
Console.WriteLine("No third digit");
}
