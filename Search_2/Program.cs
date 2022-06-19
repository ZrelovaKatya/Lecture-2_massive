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

int [] array = new int [10]; // в массиве по умолчанию 10 элементов, по умолчанию будет наполнен нулями

FillArray (array); //данный метод заполнил массив
PrintArray (array); // метод, распечатал