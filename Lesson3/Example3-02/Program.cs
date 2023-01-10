﻿static int[] CreateArray(int count)
{
    return new int[count];
}

void Fill(int[] elements)
{
    int lenght = elements.Length;
    int index = 0;

    while (index < lenght)
    {
        int current = Random.Shared.Next(30); // Полставляет любое число от 0 до 29
        elements[index] = current;
        //Console.WriteLine(elements[index]);
        index++; //index = index + 1;
    }
}

int GetSum(int[] array)
{
    int size = array.Length;
    int sum = 0;

    int position = 0;

    while (position < size)
    {
        int current = array[position];
        if (current >= 10 && current <= 99)
        {
            sum = sum + current;
        }
        position = position + 1;
    }
    return sum;
}

string Print(int[] collection)
{
    string output = String.Empty;
    
    int size = collection.Length;
    int index = 0;
    while (index < size)
    {
        int current = collection[index];
        output = output + $"{current}\n";
        index = index + 1;
    }
    return output;
}

int[] arr = CreateArray(5);
Fill(arr);
int sum = GetSum(arr);
Console.WriteLine(Print(arr));
Console.WriteLine($"sum = {sum}");