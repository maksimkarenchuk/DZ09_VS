// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29


int akerman (int m, int n)
{
    if (m == 0) return n+1;
    if (m>0 && n==0) return akerman(m-1, 1);
    if (m>0 && n>0) return akerman(m-1,akerman(m,n-1));
    return akerman(m,n);
}
Console.WriteLine(akerman(1,4));