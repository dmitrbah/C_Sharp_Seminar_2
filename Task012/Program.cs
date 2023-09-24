Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Remainder(int FirstPar, int SecondPar)
{
    return FirstPar % SecondPar;
}

int remainder = Remainder(number1, number2);
if (remainder == 0) Console.WriteLine("кратно"); 
else Console.WriteLine($"не кратно, остаток равен {remainder}");

