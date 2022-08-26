// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Enter M:");
int startM = int.Parse(Console.ReadLine());
Console.WriteLine("Enter N:");
int endN = int.Parse(Console.ReadLine());
Console.WriteLine("Use recursion? (y/n)");
ConsoleKeyInfo userAnswer = Console.ReadKey();
Console.WriteLine();

if (userAnswer.Key == ConsoleKey.Y && startM < endN)
{
    Console.Write("\"\"");
    getNumbersRecursion(startM, endN);
    Console.Write("\"\"");
}
else if (userAnswer.Key == ConsoleKey.N && startM < endN)
{
    Console.Write("\"\"");
    getNumbers(startM, endN);
    Console.Write("\"\"");
}
else
{
    Console.WriteLine("Incorrect inputs. The program will be terminated. Try again");
    return;
}


void getNumbers (int start, int end) //вариант без рекурсии, на мой взгляд, оптимальнее, т.к. короче и ест меньше ресурсов при выполнении
{
    do
    {
        if (start != end)
        {
            Console.Write(start + ", ");
        }
        else
        {
            Console.Write(start);
        }
        start++;
    } while (start <= end);    
}


void getNumbersRecursion (int start, int end)
{
    if (start > end)
    {
        return;
    }
    if (start != end)
    {
        Console.Write(start + ", ");
    }
    else
    {
        Console.Write(start);
    }
    start++;
    getNumbersRecursion(start, end);
}