// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// System.Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("\nВведите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x >0 && y > 0)
// {
//     System.Console.WriteLine( "I четверть");
// }
// else if(x<0 && y>0)
// {
//     System.Console.WriteLine("II Четверть");
// }
// else if(x<0 && y<0)
// {
//     System.Console.WriteLine("III Четверть");
// }
// else if(x>0 && y<0)
// {
//     System.Console.WriteLine("IV Четверть");
// }
// else
// {
//     System.Console.WriteLine("Коордитаты на осях");
// }

int[] coords = new int[2];
System.Console.Write("Введите координату X: ");
coords[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("\nВведите координату Y: ");
coords[1] = Convert.ToInt32(Console.ReadLine());

if(coords[0]>0 && coords[1]>0)
{
    System.Console.WriteLine( "I четверть");
}
else if(coords[0]<0 && coords[1]>0)
{
    System.Console.WriteLine("II Четверть");
}
else if(coords[0]<0 && coords[1]<0)
{
    System.Console.WriteLine("III Четверть");
}
else if(coords[0]>0 && coords[1]<0)
{
    System.Console.WriteLine("IV Четверть");
}
else
{
    System.Console.WriteLine("Коордитаты на осях");
}