﻿// Напишите программу, которая будет 
// выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if(number == 1)
{
    Console.Write("Понедельник");
}
if(number == 2)
{
    Console.Write("Вторник");
}
if(number == 3)
{
    Console.Write("Среда");
}
if(number == 4)
{
    Console.Write("Четверг");
}
if(number == 5)
{
    Console.Write("Пятница");
}
if(number == 6)
{
    Console.Write("Суббота");
}
if(number == 7)
{
    Console.Write("Воскресенье");
}
if(number > 7)
{
    Console.Write("Не верно");
}
if(number < 1)
{
    Console.Write("Не верно");
}