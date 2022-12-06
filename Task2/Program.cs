/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.Write("Введите число: ");
int numberStr = int.Parse(Console.ReadLine()??"");

if (ThirdDigit(numberStr) == 0)
    Console.WriteLine("третьей цифры нет");
else
    Console.WriteLine($"Третья цифра {ThirdDigit(numberStr)}");

int ThirdDigit(int number)
{
    int result = 0;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}