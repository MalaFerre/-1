// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n1 = number % 10;
if( number > 100)
{
    System.Console.WriteLine($"{n1}");
}
else
{
    System.Console.WriteLine("Некорректно введено число!");
}


// int Prompt(string message)
// {
//     System.Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number /=10;
//     }
//     return number % 10;
// }

// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         System.Console.WriteLine("Третьей цифры нет!");
//         return false;
//     }
//     return true;
// }
// int number = Prompt("Введите число > ");
// if (ValidateNumber(number))
// {
//     System.Console.WriteLine(GetThirdRank(number));
// }