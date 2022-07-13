//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
{
    Console.WriteLine("max number = " + firstNumber);
}
else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
{
    Console.WriteLine("max number = " + secondNumber);
}
else
{
    Console.WriteLine("max number = " + thirdNumber);
}