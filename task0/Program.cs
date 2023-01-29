// Напишите программу, которая на вход принимает 
// число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// ● 4 -> 16 
// ● -3 -> 9 
// ● -7 -> 49

Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine () );
int sqr = number * number;
Console.WriteLine("квадрат числа " + number + " равен = " + sqr);        