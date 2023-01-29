/* Задача: Сумма чисел от 1 до N */

/* Решение задачи без рекурсии:
int SumFor(int n)
{
    int result = 0;
    for(int i = 1; i <= n; i++) result += i;
    return result;
}
Console.WriteLine(DumFor(10)); //Ответ: 55 */

// Решение задачи c рекурсией:
int SumRec(int n)
{
    if(n == 0) return 0; //Условие выхода из рекурсии
    else return n + SumRec(n-1);
}
Console.WriteLine(SumRec(10)); //Ответ: 55