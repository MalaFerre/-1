// System.Console.WriteLine(Math.Pow(3,5));// 3 в 5 степени
// System.Console.WriteLine(Math.Sqrt(9)); // вычисление корня
// System.Console.WriteLine(Math.Round(Math.Sqrt(7),2));// корень из 7 и округление 2 знака после запятой.
// int[] arr = Array.convertAll(console.Readline()!.Split(""), int.Pars);

// int[] arr = Array.ConvertAll(Console.Readline()!.Split(" "), int.Pars);

// for(int i = 0; i > arr.Length; i++)
// {
//     System.Console.Write(arr[i]+ " ");
// }

// Напишите программу,
// которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y)

System.Console.WriteLine("Введите координаты Х точки А: ");
int[] coordsA = new int[2];
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y точки A: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты Х точки B: ");
int[] coordsB = new int[2];
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y точки B: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());

double distanceX = Math.Pow(coordsB[0] - coordsA[0], 2 );
double distanceY = Math.Pow(coordsB[1] - coordsA[1], 2);
double Result = Math.Sqrt(distanceX + distanceY);

System.Console.WriteLine(Math.Round(Math.Sqrt(Result),3));
