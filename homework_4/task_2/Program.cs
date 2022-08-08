// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter number:");
int number = int.Parse(Console.ReadLine());

number = Math.Abs(number);
int result = 0;

if (number < 10)
{
    result = number;
}
else
{
    while (number >= 10)
    {
        result += number % 10;
        number = number / 10;
    }
    result += number;
}

Console.WriteLine("All digit sum is: " + result);