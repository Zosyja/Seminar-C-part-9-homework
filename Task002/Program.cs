// Показать натуральные числа от N до 1, N задано

string NumbersRec (int N, int i){
    if (N >= i) return $"{N} " + NumbersRec (N-1, i);
    else return String.Empty;
}

Console.Write("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(NumbersRec(N,1));