// Задача 4: Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22


Console.Clear();

Console.WriteLine("Давайте поиграем с числами и найдем максимальное... ");
Console.Write("Введите Ваше первое целое число: ");
string userImput1 = Console.ReadLine() ?? "";
int a = int.Parse(userImput1);

Console.Write("Введите Ваше второе целое число: ");
string userImput2 = Console.ReadLine() ?? "";
int b = int.Parse(userImput2);

Console.Write("Введите Ваше второе целое число: ");
string userImput3 = Console.ReadLine() ?? "";
int c = int.Parse(userImput3);

int max=0;

/*if(a>max) max = a;
if(b>max) max = b;
if(c>max) max = c;*/

/*if (a > b)
{
    Console.WriteLine($"Самое большое число: {a}");
}
else if (a > c)
{
    Console.WriteLine($"Самое большое число: {a}");
}

else if (a < b)
{
    Console.WriteLine($"Самое большое число: {b}");
}

else if (b > c)
{
    Console.WriteLine($"Самое большое число: {b}");
}

else if (c > a)
{
    Console.WriteLine($"Самое большое число: {c}");
}

else if (c > b)
{
    Console.WriteLine($"Самое большое число: {c}");
}*/
if(a > max)
{
    max = a;
}
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}

Console.WriteLine("Самое большое число: " + max);
