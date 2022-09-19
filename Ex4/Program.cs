//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.


Console.Clear();
Console.WriteLine("Введите число а:");
int number_n=int.Parse(Console.ReadLine());
int count=2;
while (count <= number_n)
{
Console.Write($"{count}  ");
count=count+2;
}
