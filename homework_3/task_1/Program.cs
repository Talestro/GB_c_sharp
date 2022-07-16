// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter number from 10 000 to 99 999 (included):");
int number = int.Parse(Console.ReadLine());
int[] digitsOfNumber = new int [5];

if (number <= 9999 || number >= 100000)
{
    Console.WriteLine("Please enter correct number");
}
else
{
    for (int i = 0; i < 5; i++)
    {
        digitsOfNumber[i] = number % 10;
        number /= 10;
    }

    if (digitsOfNumber[0] == digitsOfNumber[4] && digitsOfNumber[1] == digitsOfNumber[3])
    {
        Console.Write("entered number is a palindrome");
    }
    else
    {
        Console.Write("entered number not a palindrome");
    }
}