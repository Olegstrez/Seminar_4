﻿/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */
int a = Convert.ToInt16(Console.ReadLine());
int b = Convert.ToInt16(Console.ReadLine());

double Method1 (int a, int b)
{
    double result = Math.Pow(a,b); 
    return result;
}

Console.WriteLine(Method1 (a,b));
