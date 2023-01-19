// Двумерные массивы:
//        индексы элементов: 0, 0
string[,] table = new string[2, 5];

/* Обращение к элементам двумерного массива осуществляется по индексам
Пустые строки:
table[0,0]   table[0,1]  table[0,2] ... table[0,4] - 0,4 максимальный элемент
table[0,0]   table[1,1]  - 1,0 максимальный элемент */

//Строковой двумерный массив:
table[1, 2] = "слово"; // Обращение к какой-либо ячейке двумерного массива
for(int rows = 0; rows < 2; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}

//Числовой двумерный массив:
int[,] matrix = new int[3, 4];
for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

//Обращение к длине массива в числововом двумерном массиве:
int[,] matrix1 = new int[3, 4];
for(int i = 0; i < matrix1.GetLength(0); i++) // .GetLength - в скобках указывается номер элемента для вывода с 0
{
    for(int j = 0; j < matrix1.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}