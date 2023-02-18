System.Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();
if (number!.Length < 3)
{
    System.Console.WriteLine("число не содержит третей цифры");
}
else
{
    System.Console.WriteLine(number[2]);
}