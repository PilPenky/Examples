// Группы методов:

// 1 вид: Ничего не принимает и ничего не возвращает:
void Method1() //В скобках нет аргументов на прием
{
    Console.WriteLine("Автор...");
}
Method1(); //Команда вызова метода


// 2 вид: Принимает и ничего не возвращает:
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");


void Method21(string msg, int count) //Говорим, что методу нужно вывести сообщение N количество раз
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст сообщения", count: 4); //Указываем сколько раз нужно выводить сообщение
Method21(count: 4, msg: "Новый текст");


// 3 вид: Ничего не принимает, но возвращает:
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// 4 вид:Принимает и возвращает:
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //String.Empty - это пуская строка, тоже самое, что указать: string result = ""

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Какой-то текст\n");
Console.WriteLine(res);