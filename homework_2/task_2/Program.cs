// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("enter any number");
int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}

if (number < 100)
{
    Console.WriteLine("no third digit");
}
else 
{
    while (number > 999)
    {
        number /= 10;
    }
    int thirdDigit = number % 10;
    
    Console.WriteLine ("third digit is " + thirdDigit);
}