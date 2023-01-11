// 4 вид метода в цикле for:Принимает и возвращает:
string Method4(int count, string text)
{
    string result = String.Empty; //String.Empty - это пуская строка, тоже самое, что указать: string result = ""
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "Какой-то текст\n");
Console.WriteLine(res); 