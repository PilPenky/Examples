/* Нахождение максимального числа в массиве с использованием метода
Задача: Найти элемент в массиве равный "find" */

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



int IndexOff(int [] collection, int find) // Создаем метод с названием IndexOff, который возвращает значение (int возвращает значение)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // В случае, когда искомый элемент будет выхлдить за рамки элементов массива, будет писаться "-1"

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; //Указываем, что в наших массивах будет по 10 элементов
/*new int [10] - команда, дословно "Создай новый массив, в котором будет 10 элементов". 
Но будет заполнен нулями.*/

FillArray(array);
array[4] = 1; // Можем указать значение в необходимом индексе
array[6] = 4;
PrintArray(array);
Console.WriteLine();

/*Console.WriteLine("Введите значение от 1 до 10, индекс которого необходимо найти в массиве: ");
int numberUser = Convert.ToInt32(Console.ReadLine());*/

int pos = IndexOff(array, 4); //Цифра указывает - элемент какого значания необходимо найти. Цифру можно заменить переменной "numberUser", чтобы пользователь мог вписать значение.
Console.WriteLine($"Искомый элемент в массиве равен индексу: {pos}");