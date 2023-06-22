/* Задача 10:       Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/



/*Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("ВВедите 3-х значное число: ");
string result = Console.ReadLine() ?? "";
int num = int.Parse(result);
int a1 = num / 10;
int a2 = num % 10;
int res = a1 * 1 + a2;
Console.WriteLine($"{num}->{a2}->{res}");
//Console.WriteLine($"вторая цифра этого числа -> "+ result[1]);*/

/*456%10=45           782%10=78
45/10=4,5           78/10=7,8*/
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
