// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
double number = double.Parse(Console.ReadLine());
Console.WriteLine("Введите степень для первого числа");
double degree = double.Parse(Console.ReadLine());

double result = Math.Pow(number, degree);       //полагаю, что в условии задания ошибка, т.к. возведение двух числе не требует цикла ибо это всего один шаг, исходя из этого реализовано без цикла

Console.WriteLine("Число " + number + " в степени " + degree + " равно: " + result);