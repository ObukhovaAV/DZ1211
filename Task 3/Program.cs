// Написать программу вычисления функции Аккермана

int Ackermann (int m, int n)
{
    if (m==0) return n+1;
    if (m>0 && n==0) return Ackermann (m-1, 1);
    if (m>0 && n>0) return Ackermann ((m-1), Ackermann (m,n-1));
    return Ackermann (m,n);
}
Console.WriteLine ("Введите число m");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine ("Введите число n");
int n = int.Parse(Console.ReadLine() ?? "0");
int f = Ackermann (m,n);
Console.WriteLine ($"Функция Аккермана для чисел {m} и {n} равна {f}");