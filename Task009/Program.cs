int number = new Random().Next(10, 100); // max = 99 + 1
Console.WriteLine($"Cлучайное число из отрезка [10, 99] -> {number}");

// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // Тернарный оператор
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10; // 78 / 10 = 7
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}

