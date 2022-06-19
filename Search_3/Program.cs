void FillArray (int [] collection) // collection - название элемента //
{
    int length = collection.Length; // длина массива
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random ().Next (1,10); //обращаемся к аргументу collection - положить туда новое целое число от 1 до 10
        index++; // index = index + 1
    }
}

void PrintArray (int [] col) // для печати массива, аргумент col
{
    int count = col.Length; // количество элементов
    int position = 0; // обозначание текущей позиции
    while (position < count) 
    {
        Console.WriteLine (col [position]);
        position++;
    }
}

int IndexOf (int [] collection, int find) // ищем элемент
{
    int count = collection.Length; //кол-во элекментов определяем
    int index = 0;
    int position = -1; //если элемента в массиве нет, то будет возвращать -1
    while (index < count)
    {
        if (collection [index] == find) // если совпал с find надо сохранить в position
        {
            position = index;
            break;
        }
        index ++;
    }
    return position;
}

int [] array = new int [10]; // в массиве по умолчанию 10 элементов, по умолчанию будет наполнен нулями

FillArray (array); //данный метод заполнил массив
array [4] = 4; //принудительно добавили 4 на 4 индекс
array [6] = 4; //принудительно добавили 4 на 6 индекс

PrintArray (array); // метод, распечатал
Console.WriteLine(); // пустая строчка

int pos = IndexOf (array, 44); //будем искать индекс четверки
Console.WriteLine (pos);