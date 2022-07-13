//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("max number = " + firstNumber);
}
else
{
    Console.WriteLine("max number = " + secondNumber);
}