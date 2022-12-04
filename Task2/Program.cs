// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
int SetCoordinaty (string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double Argumenty ( int x1, int y1, int z1, int x2, int y2, int z2)
 {
    double formula = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return formula;
 }

int x1 = SetCoordinaty ("Введите координаты x1 = ");
int y1 = SetCoordinaty ("Введите координаты y1 = ");
int z1 = SetCoordinaty ("Введите координаты z1 = ");
int x2 = SetCoordinaty ("Введите координаты x2 = ");
int y2 = SetCoordinaty ("Введите координаты y2 = ");
int z2 = SetCoordinaty ("Введите координаты z2 = ");

double ras = Argumenty (x1, y1, z1, x2, y2, z2);

Console.WriteLine ($"Растояние между точками с координатами (х1;у1;z1) и (х2;у2;z2) = {ras}");