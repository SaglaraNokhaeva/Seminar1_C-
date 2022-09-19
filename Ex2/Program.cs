//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите число а:");
int number_a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b:");
int number_b=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c:");
int number_c=int.Parse(Console.ReadLine());
if (number_a>=number_b)
{
  if (number_a>=number_c)
  {
    Console.WriteLine($"Максимальное число =  {number_a}");
  }
  else
  {
    Console.WriteLine($"Максимальное число =  {number_c}");
  }
}
else
{
   if (number_b>=number_c)
  {
    Console.WriteLine($"Максимальное число =  {number_b}");
  }
  else
  {
    Console.WriteLine($"Максимальное число =  {number_c}"); 
  }
}