// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    number = (number / 10) % 10;

System.Console.WriteLine("Вторая цифра этого числа: " + number);
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}