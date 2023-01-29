/* Задача: Собрать строку с числами от A до B, A <= B */

/* Решение задачи без рекурсии:
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for(int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor(1, 10)); //Результат: 1 2 3 4 5 6 7 8 9 10 */

// Решение задачи с рекурсией:
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    //if (a <= b) return NumbersRec(a + 1, b) + $"{a} " ; //Если нужно собрать от большего к меньшему
    else return string.Empty; //Условие выхода из рекурсии
}

Console.WriteLine(NumbersRec(1, 10)); //Результат: 1 2 3 4 5 6 7 8 9 10 
