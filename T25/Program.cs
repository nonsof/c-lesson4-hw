// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("write a number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write a number");
int b = Convert.ToInt32(Console.ReadLine());
void aInb (int a1, int a2)
{
    double result = Math.Pow (a1, a2);
    int res = Convert.ToInt32 (result);
    Console.WriteLine(result);
}

aInb (a, b);
