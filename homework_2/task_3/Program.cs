// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter day number:");
int dayNumber = int.Parse(Console.ReadLine());

// закоменченный код ниже фактически явлеятся решением исходя из условий, я несколько расширил возможный вывод
// if (dayNumber == 6 || dayNumber == 7)
// {
//     Console.WriteLine(dayNumber + " is a holiday");
// }
// else
// {
//     Console.WriteLine(dayNumber + " is not a holiday");
// }


if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("incorrect day number");
}
else if (dayNumber > 5)
{
    Console.WriteLine(dayNumber + " is a holiday");
}
else
{
    Console.WriteLine(dayNumber + " is a working day");
}