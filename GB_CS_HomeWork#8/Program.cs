/*Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Clear();

Console.Write("Какое число хотите разложить?: ");
string userInput = Console.ReadLine() ??"";
int Number = int.Parse(userInput);

int userNumber = 2;

if(Number > 1)
{
    while(userNumber <= Number)
    {
        Console.Write(userNumber + ", ");
        userNumber = userNumber + 2;
    }
}