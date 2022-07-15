// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine ("Enter number from 100 to 999:");
int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}

int secondDigit = (number / 10) % 10;

Console.WriteLine ("Second digit is " + secondDigit);