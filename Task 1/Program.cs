// Показать натуральные числа от M до N, N и M заданы

void ShowNumbersRec(int M, int N)
{
    if (M<=N)
    {
    Console.Write($"{M} ");
    ShowNumbersRec(M+1, N);
    }
}

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine() ?? "0");
if (M>0 && N>0)
ShowNumbersRec(M,N);
