/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = ReadLineInt("Введите трехзначное число: ");
int amountNumber = number.ToString().Length;

if (amountNumber < 3 || amountNumber > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
} 
int ReadLineInt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int InCenter(int a)
{
    int result = ((a / 10) % 10);
    return result;
}