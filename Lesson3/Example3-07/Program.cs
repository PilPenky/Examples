/* Задача:
Массив чисел 1, 5, 4, 3, 2, 6, 7, 1, 1 - сформировать по порядку */

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// Метод вывода массива:
void PrintArray (int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Метод сформирования чисел по порядку:
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    Console.WriteLine();
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);