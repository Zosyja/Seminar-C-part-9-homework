// Написать программу вычисления функции Аккермана
// Эта функция растёт очень быстро, например, число A(4,4) настолько велико, 
// что количество цифр в порядке этого числа многократно превосходит количество атомов в наблюдаемой части Вселенной.


int AckermannFunc(int A, int B){
    if (A == 0)
        return B+1;
    else if (B == 0)
        return AckermannFunc(A-1,1);
    return AckermannFunc(A-1, AckermannFunc(A,B-1));
}

Console.Write("Введите натуральное число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

if (M > 6 || N > 6 || M < 0 || N < 0) Console.WriteLine("Число велико, количество цифр в порядке этого числа...");
else Console.WriteLine($"AckermannFunc ({M}, {N}) =  {AckermannFunc(M,N)}");
