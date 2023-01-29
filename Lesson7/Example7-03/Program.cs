// Факториал числа - произведение числа от 1 до n

// Решение задачи без рекурсии:
int FactorialFor(int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++) result *= i;
    return result;
}
Console.WriteLine(FactorialFor(5));

// Решение задачи c рекурсией:
int FactorialRec(int n)
{
    if(n == 1) return 1; //Условие выхода из рекурсии
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(5));