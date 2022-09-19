//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
Console.Clear();
Console.WriteLine("Введите число а:");
int number_a=int.Parse(Console.ReadLine());
if (number_a%2==0)
{
    Console.WriteLine("Число а - чётное");
}
else
{
    Console.WriteLine("Число а - нечётное");
}