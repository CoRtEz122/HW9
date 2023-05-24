// Задача 63: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());



// void PrintNumber(int N)
// {
//     for (int i = 1; i < N ; i++)
//     {
//         Console.Write(i+",");

//             if (N<=i)
//             {
//                 return;
//             }
//     }
// }
// PrintNumber(N+1);


// Задача 65: Задайте значения M и N.
//  Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int M = Convert.ToInt32(Console.ReadLine());
// PrintNambers(N, M);


// if (M > N)
// {
//     System.Console.WriteLine("Введены невенрные данные");
//     return;
// }



// void PrintNambers(int N, int M)
// {
//     if (M > N)
//     {
//         return;
//     }
//     Console.Write(M + " ");
//     PrintNambers(N, M + 1);
// }


// Задача 67: Напишите программу,
//  которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// int n = ReadInt("Введите число N: ");
// if(n < 0)
// {
//     System.Console.WriteLine("Не корректное число");
//     return;
// }
// System.Console.WriteLine(SumNumbers(n));

// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumNumbers(int n)
// {
//     if (n < 1)
//     {
//         return 0;
//     }
//     return n % 10 + SumNumbers(n/10);
// }

// Задача 69: Напишите программу, которая на вход принимает два числа
//  A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



