
/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/
Console.WriteLine("Введите массив ширина");
int ShirinaMasia = Convert.ToInt32(Console.ReadLine());
int [] Massib  = new int[ShirinaMasia];
for (int i =0; i < ShirinaMasia; i++)
{
    Massib[i] = new Random().Next(1,100);
    Console.WriteLine($"A {i} = {Massib[i]}");
}
