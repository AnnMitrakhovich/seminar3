// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16
// int InputAB(string message)
// {
// 	Console.Write(message);
// 	int num = int.Parse(Console.ReadLine()!);
// 	return num;
// }
// int a = InputAB("Введите число А: ");
// int b = InputAB("Введите число В: ");

// int StepNumber (int a1, int b1)
// {
//     int step = b1;
//     int result = 1;
//     for (int i = 0; i < step; i++) result = result * a1;
//     return result;
// }
// int res = StepNumber(a,b);
// Console.WriteLine(res);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int InputNumber(string message)
{
	Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}
int SumDigits (int n)
{
    int sum = 0;
    while (n != 0) 
    {
        sum += n % 10;
        n /= 10;
    }

    return sum;
}
int n1 = InputNumber("Enter N: ");
int res = SumDigits (n1);
Console.WriteLine(res);


// int[] InputSomeNums()
// {
//     Console.Write("Введите количество чисел: ");
//     int size = int.Parse(Console.ReadLine()!);
//     int[] array = new int[size];

//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите {i + 1}-е число: ");
//         array[i] = int.Parse(Console.ReadLine()!);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < array.Length - 1)
//             Console.Write(", ");
//         else
//             Console.Write(".");
//     }
// }

// int[] myArray = InputSomeNums();
// PrintArray(myArray);

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < array.Length - 1)
//             Console.Write(", ");
//         else
//             Console.Write(".");
//     }
// }

// int num = int.Parse(Console.ReadLine());
// int temp = num;

// int count = 0;
// while (temp != 0)
// {
//     temp = temp / 10; // num /= 10;
//     count++;
// }

// int[] array = new int[count];

// for (int i = array.Length - 1; i >= 0; i--)
// {
//     array[i] = num % 10;
//     num /= 10;
// }

// PrintArray(array);

// Console.Write($"\n{array[2]}");

// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// int InputNum (string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int quarter (int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     else if (x < 0 && y > 0) return 2;
//     else if (x < 0 && y < 0) return 3;
//     else if (x > 0 && y < 0) return 4;
//     else return -1;
// }

// int x = InputNum("Введите координату х: ");
// int y = InputNum("Введите координату y: ");

// int res = quarter(x, y);

// if (res == - 1) 
//     Console.WriteLine("Точка находится на пересечении четвертей");
// else
//     Console.WriteLine($"Четверть {res}");

// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).
// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int quarter = int.Parse(Console.ReadLine()!);
//     return quarter;
// }
// int quarter = InputNum("Введите номер четверти (1-4): ");

// string GetQuarter(int quarter1)
// {
//     if (quarter1 == 1) return "Координаты х и y должны быть больше 0";
//     else if (quarter1 == 2) return "Координата х должна быть меньше 0, а координата y - больше 0";
//     else if (quarter1 == 3) return "Координаты х и y должны быть меньше 0";
//     else if (quarter1 == 4) return "Координата х должна быть больше 0, а координата y - меньше 0";
//     else return "Введено неверное число";
// }

// string N = GetQuarter(quarter);
// Console.WriteLine(N);
// void Koord(string massage) 
// { 
//  System.Console.WriteLine(massage); 
//  int a = int.Parse(System.Console.ReadLine()!); 
//  if (a > 0 && a < 5) 
//  { 
//  if (a == 1) 
//  System.Console.WriteLine("x > 0, y > 0."); 
//  else if (a == 2) 
//  System.Console.WriteLine("x < 0, y > 0."); 
//  else if (a == 3) 
//  System.Console.WriteLine("x < 0, y < 0."); 
//  else if (a == 4) 
//  System.Console.WriteLine("x > 0, y < 0."); 
//  } 
//  else 
//  System.Console.WriteLine("Такой четверти нет."); 
// } 
// Koord("Введите номер четверти: ");
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве. 
// Используем формулу Пифагора:
// d = √((хА – хВ)2 + (уА – уВ)2)
// int InputNum(string message)
// {
// 	Console.Write(message);
// 	int num = int.Parse(Console.ReadLine()!);
// 	return num;
// }
// int xA = InputNum("entre x point A: ");
// int yA = InputNum("entre y point A: ");
// int xB = InputNum("entre x point B: ");
// int yB = InputNum("entre y point B: ");

// double Root(int xA, int yA, int xB, int yB)
// {
// 	double res1 = Math.Pow(xB - xA, 2);
// 	double res2 = Math.Pow(yB - yA, 2);
//   double res = Math.Sqrt(res1 + res2);
// 	return res;
// }

// double distance = Root(xA, yA, xB, yB);
// //Console.Write(distance);
// Console.WriteLine(Math.Round(distance, 2));
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4
// int InputNum(string message)
// {
// 	Console.Write(message);
// 	int num = int.Parse(Console.ReadLine()!);
// 	return num;
// }
// int num = InputNum("enter number N: ");
// for(int i = 1; i <= num; i++)
// {
// 	Console.Write($"{Math.Pow(i, 2)}");
// 	if(i < num)
// 	{
// 		Console.Write(", ");
// 	}
// 	else
// 	{
// 		Console.Write(".");
// 	}
// }
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// int InputNum(string message)
// {
//     Console.Write(message);
//     int number = Convert.ToInt32(Console.ReadLine()!);
//     return number;
// }
// int GetReverseNumber(int N)
// {
//     int section = 0;
//     int reversenumber = 0;
//     while (N > 0)
//     {
//         reversenumber = reversenumber * 10 + N % 10;
//         N /= 10;
//         section++;
//     }
//     return reversenumber;
// }
// string Answer(int reversenumber, int temp1)
// {
//     string answer = "неизвестно";
//     if (temp1 > 10 && temp1 == reversenumber)
//     {
//         answer = "Да.Это число-палиндром";
//     }
//     else
//     {
//         answer = "Это число не является палиндромом";
//     }
//      return answer;
// }
// int N = InputNum("Введите число: ");
// int temp = N;
// int rev = GetReverseNumber(N);
// string A = Answer (rev, temp);
// Console.WriteLine (A);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// double InputPointCoordinations (string message)
// {
//     Console.Write(message);
//     double X = double.Parse(Console.ReadLine());
//     return X;
// }
// double xA = InputPointCoordinations("Введите координату по оси X для точки А: ");
// double yA = InputPointCoordinations("Введите координату по оси Y для точки А: ");
// double zA = InputPointCoordinations("Введите координату по оси Z для точки А: ");
// double xB = InputPointCoordinations("Введите координату по оси X для точки B: ");
// double yB = InputPointCoordinations("Введите координату по оси Y для точки B: ");
// double zB = InputPointCoordinations("Введите координату по оси Z для точки B: ");

// double distance = Math.Round(Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2)), 2);
// Console.WriteLine($"Pасстояние между точками А и В в 3D пространстве равно {distance}.");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// int InputN(string message)
// {
//     Console.WriteLine(message);
//     int N = int.Parse(Console.ReadLine());
//     return N;
// }
// int num = InputN("Введите число: ");
// for (int i = 1; i < num; i++)
// {
//     double cub = Math.Pow(i, 3);
//     Console.Write($"{cub}, ");
// }
// Console.Write($"{Math.Pow(num, 3)}.");

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// int InputNum(string message)
// {
//     Console.Write(message);
//     int number = Convert.ToInt32(Console.ReadLine()!);
//     return number;
// }
// int N = InputNum("Enter number: ");
// int temp = N;
// int section = 1;
// while (N / 10 != 0)
// {
//     N /= 10;
//     section++;
// }
// int[] digits = new int[section];
// for (int i = 0; i < digits.Length; i++)
// {
//     digits[i] = temp % 10;
//     temp /= 10;
// }
// bool CheckNumber (int[] digits)
// {
//     for (int i = 0; i <= digits.Length / 2; i++)
//     {
//         if (digits[i] == digits[digits.Length - i])
//         {
//             Console.WriteLine("Да.Это число-палиндром");
//             return true;
//         }
//         else
//         {
//             Console.WriteLine("Это число не является палиндромом");
//             return false;
//         }
//     }
// }
// string result = CheckNumber(digits);
// Console.WriteLine(result);


