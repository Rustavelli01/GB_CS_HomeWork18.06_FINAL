//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Ваше первое число, Хозяин!: ");
string userImput1 = Console.ReadLine() ?? "";
int a = int.Parse(userImput1);

Console.Write("Ваше второе число, Хозяин!: ");
string userImput2 = Console.ReadLine() ?? "";
int b = int.Parse(userImput2);

if( a > b )
{
    Console.WriteLine("Ваше первое число " + a + " больше чем второе " + b + " ,Хозяин! ");
}
else
{
    Console.WriteLine("Ваше второе число " + b + " больше чем первое " + a + " ,Хозяин! ");
}
