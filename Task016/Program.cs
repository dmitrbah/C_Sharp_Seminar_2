bool SquareOfTwoNumbers(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = SquareOfTwoNumbers(number1, number2);
Console.WriteLine(result ? "да" : "нет");
