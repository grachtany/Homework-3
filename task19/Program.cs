// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите число a - ");
string mas = Console.ReadLine();

int n = mas.Length;
int index = 0;
int result = 0;
while (index < n)
{
    if (mas[index] == mas[n-index-1]) 
    {
       result = result + 0;
       index++;}
    else
    {
        result = result + 1;
        index++;
    }
}
if (result == 0) Console.WriteLine ($"{mas} - является палиндромом");
else
{
Console.WriteLine ($"{mas} - не является палиндромом");
}