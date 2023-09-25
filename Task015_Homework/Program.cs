// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7) Console.WriteLine("Некорректный ввод");
else if (number < 6) Console.WriteLine($"Число дня недели {number} не является выходным");
else Console.WriteLine($"Число дня недели {number} является выходным");