// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число m: ");
ulong m = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine("Введите число n: ");
ulong n = Convert.ToUInt64(Console.ReadLine());
ulong Acc(ulong M, ulong N) {
    if (M == 0) {
        return N + 1;
    }
    else if (N == 0 && M > 0) {
        return Acc(M - 1, 1);
    }
    else {
        return Acc(M - 1, Acc(M, N - 1));
    }
}
Console.WriteLine(Acc(m, n));
