
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Promt (string text)
{
    Console.WriteLine (text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Promt("write m");
int n = Promt("write n");

Console.WriteLine (PrintNumbers (m));


int PrintNumbers (int m)
{
    if (m == n)
    {
        return m;
    }
    return m + PrintNumbers (m+1);

}