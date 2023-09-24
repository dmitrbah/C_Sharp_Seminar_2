bool MultipalTwoNumbers(int num, int num1, int num2)
{
bool multipal = (num % num1 == 0) && (num % num2 == 0);
return multipal;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (MultipalTwoNumbers(number, 7, 23) == true) Console.WriteLine("кратно 7 и 23");
else Console.WriteLine("не кратно 7 и 23");