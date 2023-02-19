// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число: ");
string? number = (Console.ReadLine());
if (number!.Length < 5 || number!.Length > 5)
{
    System.Console.WriteLine("Некорректное число! ");
}
else if (number[1] == number[3] && number[0] == number[4])
{
    System.Console.WriteLine($"Число полиндром!");
}
else
{
    System.Console.WriteLine("Число не полиндром!");
}