﻿/* Нахождение максимального числа в массиве через функцию.
Задача: Найти элемент в массиве равный "find" */

//   Индексы:   0  1  2  3  4  5  6  7  8
int [] array = {1, 2, 9, 4, 5, 6, 7, 8, 9};

int n = array.Length;
int find = 9; //Задали искомое значение
int index = 0;

while(index < n)
{
    if(array[index] == find)
        {
            Console.WriteLine($"Искомый элемент в массиве равен индексу: {index}");
            break; //Чтобы приложение остановилась, при совпадении с "find"
        }
    index++; //index = index+1
}