// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [,] userCoordinates = new double [2,2];

getInputFromUser(userCoordinates);
getIntersectionCoordinates(userCoordinates);



void getIntersectionCoordinates (double [,] array)
{
    double intersectionX = (array[0,0] - array[0,1]) / (array[1,0] - array[1,1]) * (-1);   //(b1 - b2) / (k1 - k2) * -1
    double intersectionY = array[1,1] * intersectionX + array[0,1];                        //k2 * x + b2
    Console.WriteLine("Intersection point coordinates is: (" + intersectionX + "; " + intersectionY + ")");
}

void getInputFromUser(double [,] array) //по сути массив тут не нужен и избыточен, т.к. проще было бы запросить 4 координаты у пользоателя без циклов и массива. Прошу прощения, если это сложно проверять - хотел потренировать двумерные массивы
{
    int j;
    char coordinate = 'b';
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine("Enter " + coordinate + (j+1));
            array[i,j] = double.Parse(Console.ReadLine());
        }
        coordinate = 'k';
        j = 0;
    }
}