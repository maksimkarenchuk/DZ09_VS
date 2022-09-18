﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string NaturNun(int M, int N)
{
   if (M==N) return $"{N}";
   return $"{M} {NaturNun(M+1, N)}";
}
Console.WriteLine(NaturNun(1, 5));