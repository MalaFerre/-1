// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = number1 / number2;
if (number1 % number2 == 0)
{
    System.Console.WriteLine($"Кратно: {sum} остаток:{ number1 % number2}");
}
else
{
    System.Console.WriteLine($"Не кратно: целое {sum} остаток:{ number1 % number2}");
}