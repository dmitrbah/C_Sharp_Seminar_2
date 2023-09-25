// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 && number >= 1) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine($"{ThirdDigit(number)}");
