// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



using System.Xml.Schema;

int urIndex = 8;
int[] elem8here = new int [urIndex];

int count = elem8here.Length;

for (int i = 0; i < count; i++)
{
    elem8here[i] = new Random().Next();
    if (i == 0) Console.Write("{");
    Console.Write(elem8here[i]);
    if (i < count-1) Console.Write(", ");
    if (i == urIndex - 1 ) Console.Write("}");
}
