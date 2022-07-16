// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// A(xa, ya, za) и B(xb, yb, zb)
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine("Enter");

int [] coordinateA = new int [3];
int [] coordinateB = new int [3];
char [] coordinates  = new char [3] {'x', 'y', 'z'};


Console.WriteLine("Enter coordinates for A: ");
getCoordinate(coordinateA, coordinates);
Console.WriteLine("Enter coordinates for B: ");
getCoordinate(coordinateB, coordinates);
// printArray(coordinateA);
// Console.WriteLine();
// printArray(coordinateB);


double distance = Math.Sqrt(getUnderSqrt(coordinateA, coordinateB));
Console.WriteLine("Distance between A and B is: " + Math.Round(distance, 2, MidpointRounding.AwayFromZero));
Console.WriteLine(distance);

double getUnderSqrt (int [] arrayA, int [] arrayB)
{
    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum = (arrayA[i] - arrayB[i]) * (arrayA[i] - arrayB[i]);
    }
    return Convert.ToDouble(sum);
}

void getCoordinate (int [] array, char [] symbols)
{
    int i = 0;
    while (i < 3)
    {
        Console.Write("Enter " + symbols[i] + ": ");
        array[i] = int.Parse(Console.ReadLine());
        i++;
    }
}

// void printArray (int [] array)
// {
//     for (int i=0; i<3; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
// }