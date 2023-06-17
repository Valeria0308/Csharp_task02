// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели: ");
int DayWeek = Convert.ToInt32(Console.ReadLine());
if (DayWeek >= 1 && DayWeek <= 5)
    System.Console.WriteLine("Нет");
else if (DayWeek == 6 || DayWeek == 7)
    System.Console.WriteLine("Да");
else
    System.Console.WriteLine("Такого дня не существует");
