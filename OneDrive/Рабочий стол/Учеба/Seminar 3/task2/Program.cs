// Напишите программу, которая по заданному номеру четверти
// показывает диапазон возможных координат точек в этой четверти (x и y)

System.Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] strArray = {"x >0 и y>0", "x<0 и y>0", "x<0 и y<0", "x>0 и y<0", "Четверти не существует!"};
if(number > 0 && number <5 )
{
    System.Console.WriteLine(strArray[number-1]);
}
else
{
    System.Console.WriteLine("Четверти не существует!");
}



// System.Console.WriteLine("Введите номер четверти: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number == 1 )
// {
//     System.Console.WriteLine("x >0 и y>0");
// }
// else if (number == 2)
// {
//     System.Console.WriteLine("x<0 и y>0");
// }
// else if (number == 3)
// {
//     System.Console.WriteLine("x<0 и y<0");
// }
// else if (number == 4)
// {
//     System.Console.WriteLine("x>0 и y<0");
// }
// else
// {
//     System.Console.WriteLine("Четверти не существует!");
// }