// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Укажите размер массива:");
int sizeOfArray = int.Parse(Console.ReadLine());
Console.WriteLine("От 0 до какого значения (включительно) могут быть использованы целые части вещественных чисел при заполнении массива?:");
int limitOfRandom = int.Parse(Console.ReadLine());

double[] randomArray = new double [sizeOfArray];

ArrayFill(randomArray, limitOfRandom);
printArray(randomArray);
double result = getMax(randomArray) - getMin(randomArray);
Console.Write("\nРазница максимального и минимального значений равна: " + Math.Round(result, 2, MidpointRounding.AwayFromZero)); //результат округлил для удобства, можно этого не делать или округлять все элементы

//Ниже 2 строки - для простоты проверки (можно раскоментить)
// Console.WriteLine("\nmax is: " + getMax(randomArray));
// Console.WriteLine("min is: " + getMin(randomArray));



void ArrayFill (double [] array, int limit)
{
    limit++;        //чтобы корректно отображалась граница рандома
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() + Convert.ToDouble(new Random().Next(limit * -1, limit));  //не получилось придумать более простой способ генерации вещественного больше 1
        array[i] = Math.Round(array[i], 2, MidpointRounding.AwayFromZero);  // строка для убдоства чтения результатов. В условии нет ничего про округление, так что её можно исключить, если точно важна
    }
}

void printArray (double [] array)
{
    Console.WriteLine("Сгенерирован массив:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double getMin (double [] array) 
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double getMax (double [] array)  
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}