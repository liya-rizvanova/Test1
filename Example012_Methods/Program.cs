Console.Clear();

// Type 1 - ничего не принимают, ничего не возвращают

void Method1()
{
    System.Console.WriteLine("Author ...");
}
//Method1();

// Type 2 - что-то принимают, ничего не возвращают

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2(msg: "Text ...");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
//Method21("Text ", 4); 
//Method21(msg: "Text ", count: 4);
//Method21(count: 4, msg: "New text ");

// Type 3 - ничего не принимают, что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

// Type 4 - что-то принимают, что-то возвращают

/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // или string result = "",
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "qwerty ");
System.Console.WriteLine(res);
*/

/*
string Method4(int count, string text)
{
    string result = String.Empty; // или string result = "",
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "qwerty ");
System.Console.WriteLine(res);
*/


// Таблица умножения
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i*j}");
    }
    System.Console.WriteLine();
}
*/

// Работа с текстом
/*
Дан текст. В тексте нужно все пробелы заменить черточками, 
маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
маленькими “с”.
*/

/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "q w e r t y'
//             0 1 2 3 4 5
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue ) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);
*/

// Сортировка массива от min до max

/*
int[] arr = { 1, 5, 6, 3, 7, 4, 2, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/

// Сортировка массива от max до min

/*
int[] arr = { 1, 5, 6, 3, 7, 4, 2, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/