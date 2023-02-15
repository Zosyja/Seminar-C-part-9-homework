// Найти сумму элементов от M до N, N и M заданы

int SumRec (int A, int B, int step){
    if (A==B+step) return 0;
    else return A + SumRec(A+step,B, step);
}

Console.Write("Введите натуральное число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int step = 0;
if (M<N) step = 1;
else step = -1;

Console.WriteLine(SumRec(M,N,step));