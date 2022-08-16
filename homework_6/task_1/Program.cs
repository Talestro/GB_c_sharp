// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Enter how much numbers you whant enter:");
int m = int.Parse(Console.ReadLine());

int[] userNumbers = new int [m];

getNumbersFromUser(userNumbers);
Console.WriteLine("You entered " + getResult(userNumbers) + " numbers thet > 0");


int getResult (int [] array) //подсчёт моджно было делать сразу при запросе и не хранить ввод в отдельном массиве. По сути - массив тут избыточен, и если введённые данные хранить не треубуется - можно сократить решение
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

void getNumbersFromUser (int [] array)
{
    Console.Write("Enter any numbers. Enter - 'q' key to stop entering numbers\n");
    string input;
    for(int i = 0; i < array.Length; i++)
    {
        input = Console.ReadLine();
        if(input[0] == 'q')
        {
            return;
        }
        else
        {
            array[i] = int.Parse(input);
        }
    }
}