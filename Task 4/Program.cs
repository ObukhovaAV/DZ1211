// Написать программу, показывающую первые N чисел, 
//для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем

int Sum (int n, int m, int c)
{
    int sum = n + m;
    if (c==0) return 1;
    else return Sum ()
}

Console.WriteLine("Введите первое число ");
int first = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе  число ");
int second = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество  чисел ");
int count = int.Parse (Console.ReadLine() ?? "0");

for (int i = first; i < count; i++)
{
  Console.WriteLine(Sum(i));
}