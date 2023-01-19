// Пример рекурсии в факториале:

double Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1); //метод вызывает сам себя
}

for(int i = 0; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
//Console.WriteLine(Factorial(3)); // 3*2*1 = 6