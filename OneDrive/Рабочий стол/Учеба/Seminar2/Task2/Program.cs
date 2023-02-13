// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 9

Random random = new Random();
int RandomN = random.Next(100, 1000);
Console.WriteLine(RandomN);
// int leftN = RandomN / 100;
// int rightN = RandomN % 10;
// Console.WriteLine(leftN + "" + rightN);

int leftN = RandomN / 100 * 10;
int rightN = RandomN % 10;
int sum = leftN + rightN;
System.Console.WriteLine(sum);
