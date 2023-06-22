/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


Console.Clear();
Console.WriteLine("Введите число:");
string number = Console.ReadLine() ??"";
int a = int.Parse(number);
if (a > 99)
{
while (a > 1000)
    {
        a = a / 10;
    }
Console.WriteLine($"{number}->{a % 10}");
}
else
{
    Console.WriteLine($"{a}->третьей цифры нет");
}
Console.WriteLine("У Вас осталось 2 попытки! ");
Console.WriteLine();