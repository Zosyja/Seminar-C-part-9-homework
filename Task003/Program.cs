// Показать натуральные числа от M до N, N и M заданы

string NumbersRec (int A, int B, int step){
    if (A != B+step) return $"{A} " + NumbersRec (A+step,B, step);
    else return String.Empty;
}

Console.Write("Введите натуральное число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int step = 0;
if (M<N) step = 1;
else step = -1;

if (M<1 || N<1) Console.WriteLine("Введены не натуральные числа.");
else Console.WriteLine(NumbersRec(M,N,step));