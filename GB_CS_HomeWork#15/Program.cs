/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Clear();

try 
{ 
    Console.Write("Введи цифру, обозначающую день недели: "); 
    string dayOfTheWeek = Console.ReadLine() ?? ""; 
    int dayNumber = int.Parse(dayOfTheWeek); 

    weeeeeek(dayNumber); 
} 
catch (Exception exc) 
        {
            Console.WriteLine($"***ЭТО ЧТО ТО НОВОЕ!!!*** {exc.Message}");
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
                        Console.WriteLine("Веселый ты человек!-) Давай еще раз!");
                    }
                    else Console.WriteLine("(этот день не выходной?) -> нет, иди работай!");

}
