/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


Console.Clear();
Console.WriteLine("Доброго времени суток! Задача 13 ");
Console.Write("ВВедите 3-х значное число: ");
string userImput = Console.ReadLine() ?? "";
int Num = int.Parse(userImput);
if (userImput.Length > 2)
{
  Console.WriteLine("третья цифра имеет символ -> " + userImput[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет!");
}
Console.WriteLine("У Вас осталось 2 попытки! ");
Console.WriteLine();