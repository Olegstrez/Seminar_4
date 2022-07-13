/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int x = Convert.ToInt32(Console.ReadLine());
string str = x.ToString();
int[] b = new int[str.Length];
for ( int i = 0;i< str.Length; i++)
{
b [i] = int.Parse(Convert.ToString(x)[i].ToString());
}
int sum = 0;
for ( int i = 0;i< str.Length; i++)
{
    
    sum = b [i] + sum ;

}

Console.WriteLine($"Сумма чисел = {sum}");
 