//  Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1 )
{
    System.Console.WriteLine("weekday");
}
else if (number == 2)
{
    System.Console.WriteLine("weekday");
}
else if (number == 3)
{
    System.Console.WriteLine("weekday");
}
else if (number == 4)
{
    System.Console.WriteLine("weekday");
}
else if (number == 5)
{
    System.Console.WriteLine("weekday");
}
else if (number == 6)
{
    System.Console.WriteLine("WEEKEND");
}
else if (number == 7)
{
    System.Console.WriteLine("WEEKEND");
}
else
{
    System.Console.WriteLine("Error, there is no such day!");
}