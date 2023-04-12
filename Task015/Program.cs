// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Please enter number of day ");
int.TryParse(Console.ReadLine(), out int a);

if ( a == 6 | a == 7)
{
    Console.WriteLine("!!!This day is weekend!!!");
}
else
{
Console.WriteLine("This day is not weekend :(((");
}