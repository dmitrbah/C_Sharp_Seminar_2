int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число -> {number}");
// int firstDigit = number / 100;
// int lastDigit = number % 10;
// int result = firstDigit * 10 + lastDigit;
// Console.WriteLine($"{result}");

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}
Console.WriteLine($"{DeleteSecondDigit(number)}");
