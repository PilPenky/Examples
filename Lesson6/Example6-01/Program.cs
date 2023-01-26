/* Задача — увеличить каждую из координат в два раза и показать пользователю ответ. 
string text = "(1,2) (2,3) (4,5) (6,7)" */

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
            .Replace("(", "")
            .Replace(")", "")
            ;
Console.WriteLine(text);

var data = text.Split(" ")  // Split - разбивает код по пустым строчкам
            .Select(item => item.Split(',')) // Символ разделитель - запятая
            .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // Выборка из массива: x будет равняться первому элементу массива
            .Where(e => e.x % 2 == 0)  // Проверка условия
            .Select(point => (point.x * 10, point.y + 10))
            .ToArray();

for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i].Item1*10);
    Console.WriteLine();
}