// Вычислить A в степени N

// Решение задачи без рекурсии:
int PowerFor(int a, int n)
{ 
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
Console.WriteLine(PowerFor(2, 10)); // 1024

// Решение задачи c рекурсией:
int PowerRec(int a, int n)
{ 
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a; //Сокращение нижеописанного кода
    if (n == 0) return 1; //Условие выхода из рекурсии
    else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(2, 10)); // 1024