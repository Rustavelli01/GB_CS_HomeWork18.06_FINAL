/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Clear();

//К сожалению задача не выполнена. Вариант из интернета. выражение" || " было записанно в чате. Чат к сожалению в записи не отображается.

Console.WriteLine("Задача 15 ");

Console.Write("Введи цифру, обозначающую день недели: ");
string dayOfTheWeek = Console.ReadLine() ?? "";
int dayNumber = int.Parse(dayOfTheWeek);

try
    {catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
            return;
        }
            void weeeeeek(int dayNumber)
                {
                if (dayNumber == 6 || dayNumber == 7)
                    {
                        Console.WriteLine("(этот день выходной?) -> да, может попьем пиво?");
                    }
                    else if (dayNumber < 1 || dayNumber > 7)
                    {
                        Console.WriteLine("это вообще не день недели");
                    }
                    else Console.WriteLine("(этот день не выходной?) -> нет, иди работай!");

                }
                }
        

    

weeeeeek(dayNumber);
Console.WriteLine();

/*try
{
    Console.Write("Введите день недели: ");
    a = int.Parse(Console.ReadLine());

 
    }
    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
}


if ((a > 0) && (a < 8))
{
    if (a == 6 || a == 7)
    { Console.WriteLine($"{a}-> да"); }
    else
    { Console.WriteLine($"{a}-> нет "); }
}
else
{ Console.WriteLine($"{a}-> такого дня недели нету "); }*/