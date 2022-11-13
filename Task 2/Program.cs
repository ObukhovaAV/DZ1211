// Найти сумму элементов от M до N, N и M заданы

int SumNumbersRec(int M, int N)
{
    if (M==N) return N;
    else return M + SumNumbersRec (M+1, N);    
  
}

Console.WriteLine ("Введите М");
int M = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine ("Введите N");
int N = int.Parse (Console.ReadLine() ?? "0");

int sum = SumNumbersRec (M,N);
Console.WriteLine ($"Сумма элементов от M до N = {sum}");
