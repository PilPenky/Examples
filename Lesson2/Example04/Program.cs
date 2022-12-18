//Создаем два метода заполнения массива случайными значениями


//void - метод, который не возвращает значения. Оператор return не используется.
void FillArray(int[] collection) //Создаем метод void с именем "FillArray" и создаем массив с именем "collection"
{
    int length = collection.Length; //Длина массива
    int index = 0;

    while(index < length)
    {
        collection[index] = new Random().Next(1, 10); //На позицию индекса добавить рандомное число от 1-10
        index++; //index = index+1
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++; //position = position+1
    }
}

int [] array = new int [10]; //Указываем, что в наших массивах будет по 10 элементов
/*new int [10] - команда, дословно "Создай новый массив, в котором будет 10 элементов". 
Но будет заполнен нулями.*/

FillArray(array);
PrintArray(array);