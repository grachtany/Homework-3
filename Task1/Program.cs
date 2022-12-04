// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear ();

int SetString (string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double Qub (int a)
{   
    double b = Math.Pow (a,3);
    // int b = a*a*a;
    return (b);

}
int x = SetString ("Введите число N = ");
int count = 1;
while (count <= x)
{
    double a = Qub(count);
    Console.Write ($" {a},");
    count++;
}