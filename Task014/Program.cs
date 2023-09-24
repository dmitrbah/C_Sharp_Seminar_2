bool MultipalTwoNumbers(int num)
{
bool multipal = (num % 7 == 0) && (num % 23 == 0);
return multipal;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (MultipalTwoNumbers(number) == true) Console.WriteLine("кратно 7 и 23");
else Console.WriteLine("не кратно 7 и 23");