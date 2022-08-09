// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень для первого числа");
int degree = int.Parse(Console.ReadLine());

int result = 1;

if (degree == 1)
{
    result = number;
}
else
{
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
}
Console.WriteLine("Число " + number + " в степени " + degree + " равно: " + result);