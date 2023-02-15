// Показать натуральные числа от 1 до N, N задано

string NumbersRec (int i, int N){
    if (i <= N) return $"{i} " + NumbersRec (i+1, N);
    else return String.Empty;
}

Console.Write("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(NumbersRec(1,N));

