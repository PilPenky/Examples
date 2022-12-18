//Нахождение максимального числа в массиве

//   Индексы:   0  1  2  3  4  5  6  7  8
int [] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};

int max = Max(
            Max(array[0], array[1], array[2]),
            Max(array[3], array[4], array[5]),
            Max(array[6], array[7], array[8]));

Console.WriteLine(max);