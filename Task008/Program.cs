// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Metod(int x, int y, int num){
    if (num == 1) return x;
    if (num == 2) return y;
    return Metod (x, y, num - 1) + Metod (x, y, num - 2);
}

int K = ReadInt("Введите количество чисел для показа: ");
int A = ReadInt("Введите первый элемент последовательности: ");
int B = ReadInt("Введите второй элемент последовательности: ");

for (int i=1; i<=K; i++){
    Console.Write(Metod (A, B, i) + " ");
}