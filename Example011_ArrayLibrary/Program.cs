// для того, чтобы заполнить массив случайными цифрами, необходимо воспользоваться методом:
//void метод - метод, который ничего не возвращает, соответственно в данном коде оператор return не используется
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); /* обратиться к аргументу collection на позицию index
                                        и положить туда новое случайное целое числоиз диапазона от 1 до 10 */
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int [] array = new int [10]; // создай новый массив, в котором будет 10 элементов

FillArray(array);
PrintArray(array);