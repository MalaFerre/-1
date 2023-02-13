// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10;
int number2 = number % 100;
int number3 = number2 / 10;
System.Console.WriteLine(number3);
