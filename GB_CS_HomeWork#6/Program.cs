/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка)
4 -> да
-3 -> нет
7 -> нет*/

Console.Clear();

Console.Write("Я кибер мозг, дайте мне число: ");
string userInput = Console.ReadLine() ??"";
int userNumber = int.Parse(userInput);

int number = userNumber % 2;

if(number == 0)
{
    Console.WriteLine($"Да. Это число четное! {userNumber} :-) ");
}
else
{
    Console.WriteLine($"Нет. Это число не четное! {userNumber} :-( ");
}