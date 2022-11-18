// Написать программу, показывающую первые N чисел, 
//для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем


void SumNumber(int first, int second, int n)
{
  int sum = 0;
  if (n > 0)
    {
      Console.Write(first + second + " ");
      sum = first+second;
      first = second;
      second = sum;
      SumNumber(first, second, n - 1);
    }
}

Console.WriteLine ("Введите первое число");
int first = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine ("Введите второе  число");
int second = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine ("Введите количество чисел");
int n = int.Parse (Console.ReadLine() ?? "0");
Console.Write ($"{first} {second} ");
SumNumber(first, second, n-2);