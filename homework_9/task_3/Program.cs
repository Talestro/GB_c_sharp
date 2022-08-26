// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Enter M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter N:");
int n = int.Parse(Console.ReadLine());

Console.Write($"A(m,n) = {akkermanFunc(m,n)}");


//Функция верна, но без расширения стэка у меня не ситает значения из примера (3 и 4), но отрабатывает на 1, 1 например.
//Стэк расширять не стал, так как потоков ещё не было.
//Впрочем с ними знаком и работал в С++ (не в шарпе) и если это действительно нужно - думаю что смогу написать.
//Однако в условии нет прямых требований к расширению стэка.
int akkermanFunc (int m, int n)  
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (n != 0 && m == 0)
    {
        return akkermanFunc(n - 1, 1);
    }
    else
    {
        return akkermanFunc(n - 1, akkermanFunc(n, m - 1));
    }
}


