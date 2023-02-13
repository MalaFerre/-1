//  Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите число дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:{
        System.Console.WriteLine("weekday");
        break; 
    }
    case 2:{
        System.Console.WriteLine("weekday");
        break;
    }
    case 3:{
        System.Console.WriteLine("weekday");
        break;
    }
    case 4 :{
        System.Console.WriteLine("weekday");
        break;
    }
    case 5:{
        System.Console.WriteLine("weekday");
        break;
    }
    case 6:{
        System.Console.WriteLine("WEEKEND");
        break;
    }
    case 7:{
        System.Console.WriteLine("WEEKEND");
        break;
    }
    default:{
        System.Console.WriteLine("Error, there is no such day!");
        break;
    }
}