/* Задача:
Задать массив из N положительных чисел и найти в нём сумму двузначных элементов */

int [] elements = new int [10];

int lenght = elements.Length;
int index = 0;
int sum = 0;

while (index < lenght)
{
    int current = Random.Shared.Next(30); // Полставляет любое число от 0 до 29
    elements[index] = current;
    Console.WriteLine(elements[index]);

    if (current >= 10 && current <= 99)
    {
        sum = sum + current;
    }
    index++; //index = index + 1;
}
Console.WriteLine("---");
Console.WriteLine(sum);