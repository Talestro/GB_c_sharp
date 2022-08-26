// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Enter M:");
int startM = int.Parse(Console.ReadLine());
Console.WriteLine("Enter N:");
int endN = int.Parse(Console.ReadLine());
Console.WriteLine("Use recursion? (y/n)");
ConsoleKeyInfo userAnswer = Console.ReadKey();
Console.WriteLine();
int sum = 0;

if (userAnswer.Key == ConsoleKey.Y && startM < endN)
{
    getNumbersRecursion(startM, endN, sum);
}
else if (userAnswer.Key == ConsoleKey.N && startM < endN)
{
    getNumbers(startM, endN, sum);
}
else
{
    Console.WriteLine("Incorrect inputs. The program will be terminated. Try again");
    return;
}


void getNumbers (int start, int end, int sum) //вариант без рекурсии, на мой взгляд, оптимальнее, т.к. короче и ест меньше ресурсов при выполнении
{
    do
    {
        sum += start;
        start++;
    } while (start <= end);
    Console.Write($"Sum of numbers from M to N is: {sum}");
}


void getNumbersRecursion (int start, int end, int sum)
{
    if (start > end)
    {
        Console.Write($"Sum of numbers from M to N is: {sum}");
        return;
    }
    sum += start;
    start++;
    getNumbersRecursion(start, end, sum);
}