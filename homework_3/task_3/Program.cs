// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter N: ");
int numberN = int.Parse(Console.ReadLine());
int count = 1;

while (count <= numberN)
{
    Console.Write (getCube(count) + " ");
    count ++;
}


int getCube (int number)
{
    number *= number *= number;     //Используется приведённое решение вместо возведение в степень через Math.Exp т.к. double требует много места и избыточен для требуемой задачи
    return number;
}