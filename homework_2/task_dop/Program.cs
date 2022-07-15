// Дополнительное задание: Напишите программу, которая принимает на вход число N и выводит все простые числа в промежутке от 0 до N (включительно).
// После, попробуйте поэксперментировать с величиной значения N и понаблюдать за тем, как оно влияет на время выполнения программы.

using System.Diagnostics;

Console.WriteLine("Enter N");
int limitN = int.Parse(Console.ReadLine()); //в задание не указано, но исхожу из того что N в пределах int
int numberForTest = 3;
int[] oddNumbersToLimitN = new int [0];
Stopwatch stopwatch = new Stopwatch();

int index = 0;

stopwatch.Start();
while (numberForTest <= limitN)
{
    if (isOdd(numberForTest) == true)
    {
        Array.Resize(ref oddNumbersToLimitN, oddNumbersToLimitN.Length + 1);
        oddNumbersToLimitN [index] = numberForTest;
        index++;
    }
    numberForTest += 2;
}

printArray (oddNumbersToLimitN);
stopwatch.Stop();

Console.WriteLine();
Console.Write("time: " + stopwatch.ElapsedMilliseconds);



bool isOdd (int testedNumber)
{
    int count = 3;
        while (count <= testedNumber / 3)
        {
            if (testedNumber % count == 0)
            {
                return false;
            }
            count += 2;
        }
    return true;
}


void printArray (int[] arrayForPrint)
{
    if (limitN >= 2)
    {
    Console.Write ("2 ");                               //чтоб удобнее начать, а число 1 судя по данным из интернета не считается простым, поэтому его нет в выводе
    }
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        int a = arrayForPrint[i];
        Console.Write (a + " ");
    }
}
