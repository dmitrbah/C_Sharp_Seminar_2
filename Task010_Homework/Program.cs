// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
    int firstDigit = num / 100;
    int firstAndSecondDigit = num / 10;
    int secondDigit = firstAndSecondDigit - firstDigit * 10;
    return secondDigit;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000) Console.WriteLine($"Вторая цифра числа {number} -> {SecondDigit(number)}");
else Console.WriteLine("Некорректный ввод");