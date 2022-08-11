// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Укажите размер массива:");
int sizeOfArray = int.Parse(Console.ReadLine());

int[] randomArray = new int [sizeOfArray];

ArrayFill(randomArray);
printArray(randomArray);
Console.Write("\nчётных чисел в массиве: " + getCountOfEvenNumbers(randomArray));



void ArrayFill (int [] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(100, 1000);    //magic number введены исходя из условий про трёхзначное число
    }
}

void printArray (int [] Array)
{
    Console.WriteLine("Сгенерирован массив:");
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}

int getCountOfEvenNumbers (int [] Array)    //можно было считать сразу при заполнении в цикле функции ArrayFill (или даже не вводить функции вообще, а решить через 1 цикл), но я решил не скидывать весь функционал в одну функцию и поделить. Получилось длинее но мне кажеться не лишним будет разделить функционал
{
    int result = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if(i%2 == 0)
        {
            result++;
        }
    }
    return result;
}
