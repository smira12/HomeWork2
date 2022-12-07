/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

string WorkHoliday(int a)
{
    if (a > 0 && a <= 7)
    {
        if (a == 6 || a == 7)
        {
            Console.WriteLine("Выходной день");
        }
        else
        {
            Console.WriteLine("Рабочий день");
        }
    }
    else
    {
        Console.WriteLine("Такого дня нет");
    }
    return "";
}










// Console.Write("Введите день недели: ");
// int num = int.Parse(Console.ReadLine() ?? "");
// if (num >= 1 && num <= 5)
// {
//     Console.Write(" Рабочий день");
// }

// else if (num >= 6 && num <= 7)
// {
//     Console.Write(" Выходной день");
// }
// else Console.Write(" Не существует такого дня недели");