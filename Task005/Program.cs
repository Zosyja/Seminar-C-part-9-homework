// Найти сумму цифр числа

int SumDigits (int A){
    if (A==0) return 0;
    else return A%10 + SumDigits(A/10);
}

Console.Write("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Сумма цифр числа = ");
Console.Write(SumDigits(N));