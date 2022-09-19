//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Clear();
Console.WriteLine("Введите число а:");
int number_a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b:");
int number_b=int.Parse(Console.ReadLine());
if (number_a>=number_b)
{
  Console.WriteLine($"Максимальное число =  {number_a}");  
}
else
{
 Console.WriteLine($"Максимальное число =  {number_b}");
}