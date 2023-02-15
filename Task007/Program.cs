// Написать программу возведения числа А в целую степень B

int PowerRec (int A, int B){
    if (B==0) return 1;
    else return PowerRec (A,B-1)*A;
}

Console.Write("Введите натуральное число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите натуральное число B: ");
int B = int.Parse(Console.ReadLine() ?? "0");

Console.Write($"Число {A} в степени {B} = ");
Console.WriteLine(PowerRec(A,B));