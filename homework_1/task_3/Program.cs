// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter any number: ");
int number = int.Parse(Console.ReadLine());

if (number%2 == 0)
{
    Console.WriteLine("Number " + number + " is even");
}
else
{
    Console.WriteLine("Number " + number + " is not even");
}