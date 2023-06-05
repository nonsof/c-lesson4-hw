// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("write a number");
int a = Convert.ToInt32(Console.ReadLine());
void summ (int s)
{
    string magic = Convert.ToString(s);
    int count = magic.Length;
    int result = 0;
    for (int i = 0; i<count; i++)
    {
        result = result + magic[i];
        Console.WriteLine (result);
    }

}

summ (a);