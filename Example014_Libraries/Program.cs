// Выводятся числа в консоль
/*
void Method(int maximum)
{
    int minimum;
    minimum = -maximum;
    while (minimum <= maximum)
    {
        System.Console.Write(minimum + " ");
    minimum++;
    }
}
*/
// Метод, который заполняет массив
/*
int[] CreateArray(int N)
{
    int[] arrayA = new int[N * 2 + 1];
    for (int i = -N; i < N; i++)
    {
        arrayA[i + N] = i;
    }
    return arrayA;
}
*/

// Ar принимает одно число и возвращает другое. В 
//теле метода производится перебор элементов от x, 
//который в этом случае равен -N, до самого числа N, 
//и затем что-то выводится в консоль. Дальше 
//возвращается число x. 
/*
int Ar (int N)   // задаем метод
{
    int x = -N;   // первая цифра -N (задаем цикл)
    while (x <= N)   // до тех пор пока x меньше или равен N
    {
        System.Console.WriteLine(x);   // выводим в консоль x 
        x++;   // инкремент
    }
    return x;
}
*/
/*
int af = -5;
int uf = 5;
System.Console.WriteLine($"{af} .. {uf}");
*/

// Варианты написания одного и того же кода разными способами
/*
bool Metodi(int chislo)
{
    bool resultati = false;
    if (chislo % 2 == 0) { resultati = true; }
    else { resultati = false; }
    if (resultati == false) { return false; }
    else { return true; }
}
*/
/*
// =
bool Metodi(int chislo)
{
    bool resultati = false;
    if (chislo % 2 == 0) { resultati = true; }
    else { resultati = false; }
    return resultati;
}
*/
/*
// =
bool Metodi(int chislo)
{  
    if (chislo % 2 == 0) { return true; }
    else { return false; }
}
*/
// =
/*
bool Metodi(int chislo)
{  
    return chislo % 2 == 0;    
}
*/
// Теперь задаем нормальное имя методу и нормальное название аргументу
/*
bool IsEven(int value)
{  
    return value % 2 == 0;    
}
*/
// =
/*
bool IsEven(int value) => value % 2 == 0;
*/
// =
/*
var IsEven(int v) => v % 2 == 0;
*/

// Собрать строку с числами от a до b, a <= b
/*
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}" + " ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a}" + " " + NumbersRec(a + 1, b);
    else return String.Empty;
}
System.Console.WriteLine(NumbersFor(1, 10));   // 1 2 3 4 5 6 7 8 9 10
System.Console.WriteLine(NumbersRec(1, 10));   // 1 2 3 4 5 6 7 8 9 10
*/

// Собрать строку с числами от a до b, a >= b
/*
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i}" + " ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a}" + " ";
    else return String.Empty;
}
System.Console.WriteLine(NumbersFor(10, 1));   // 10 9 8 7 6 5 4 3 2 1 
System.Console.WriteLine(NumbersRec(1, 10));   // 10 9 8 7 6 5 4 3 2 1  
*/

// Сумма чисел от 1 до n
/*
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
int SumRec(int n)
{
    if (n == 1) return 1;
    //if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
System.Console.WriteLine(SumFor(10));   // 55
System.Console.WriteLine(SumRec(10));   // 55
*/

// Факториал числа n — это произведение всех натуральных чисел от 1 до n включительно.
/*
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
System.Console.WriteLine(FactorialFor(10));   // 3628800
System.Console.WriteLine(FactorialRec(10));   // 3628800
*/

// Вычислить a в степени n
/*
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
int PowerRec(int a, int n)
{
    // return n == 0 ? 1 : PowerRec(a, n -1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRec(a, n - 1) * a;
}
System.Console.WriteLine(PowerFor(2, 10)); // 1024
System.Console.WriteLine(PowerRec(2, 10)); // 1024
System.Console.WriteLine(PowerRecMath(2, 10)); // 1024
*/

// Перебор слов
//В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова,
//состоящие из T букв, которые можно построить из букв этого алфавита.
/*
int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{
 if (length == word.Length)
 {
 Console.WriteLine($"{n++} {new String(word)}"); return;
 }
 for (int i = 0; i < alphabet.Length; i++)
 {
 word[length] = alphabet[i];
 FindWords(alphabet, word, length + 1);
 }
}
FindWords("аисв", new char[5]); // можно менять значение [5] на другое
*/
/*
char[] s = {'а', 'и', 'с','в'};
System.Console.WriteLine(s);
*/
/*
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
 Console.WriteLine($"{n++,-5}{s[i]}");
}
*/
/*
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
 for (int j = 0; j < count; j++)
 {
 Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
 }
}
*/
/*
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
 for (int j = 0; j < count; j++)
 {
 for (int k = 0; k < count; k++)
 {
 Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}");
 }
 }
}
*/
/*
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
 for (int j = 0; j < count; j++)
 {
 for (int k = 0; k < count; k++)
 {
 for (int l = 0; l < count; l++)
 {
 Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
 }
 }
 }
}
*/
/*
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
 for (int j = 0; j < count; j++)
 {
 for (int k = 0; k < count; k++)
 {
 for (int l = 0; l < count; l++)
 {
 for (int m = 0; m < count; m++)
 {
 Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
 }
 }
 }
 }
}
*/

//Как посмотреть содержимое папки?
/*
string path = "/Users/User/Desktop/Examples/Examle001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/
/*
void CatalogInfo(string path, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(path);
 foreach (var currentCatalog in catalogs.GetDirectories())
 {
 Console.WriteLine($"{indent}{currentCatalog.Name}");
 CatalogInfo(currentCatalog.FullName, indent + " ");
 }
 foreach (var item in catalogs.GetFiles())
 {
 Console.WriteLine($"{indent}{item.Name}");
 }
}
string path = @"C:\Users\User\Desktop\Examples";
CatalogInfo(path);
*/
/*
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"C:\Users\User\Desktop\Examples";
CatalogInfo(path);
*/

// Игра в пирамидки
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 4) // count = количество блинчиков на пирамидке (может меняться)
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}
Towers();
*/

// ((4 - 2) * (1 + 3)) / 10   можно разбить на отдельные уравнения, представив в виде пирамиды
//                        /  (1)
//             *  (2)       10  (3)
//        -  (4)   +  (5)       (если бы под 10 было бы еще одно действие, то оно было бы 6 и 7)
// 4  (8)  2 (9)  1  (10)  3(11)
// записав уравнение таким образом:
/*
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1)
{
 if (pos < tree.Length)
 {
 int left = 2 * pos;
 int right = 2 * pos + 1;
 if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
 Console.WriteLine(tree[pos]);
 if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
 }
}
InOrderTraversal();
*/

// НЕ РАБОТАЕТ
/*
decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}
//# 1 2 3 4 5 6
//V 1 1 2 3 5 8
Console.ReadLine();
//DateTime dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
//System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
System.Console.WriteLine();

Console.ReadLine();
//dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
//System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.ReadLine();
*/

int[,] pic = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 9] = 1;
    pic[9, i] = 1;
}
PrintImage(pic);
FillImage(1, 1);
System.Console.WriteLine();
PrintImage(pic);

void PrintImage(int[,] image)
{
for (int i = 0; i < image.GetLength(0); i++)
{
    for (int j = 0; j < image.GetLength(1); j++)
    {
        //System.Console.WriteLine(($"{image[i, j]}"));
        if (image[i, j] == 0) System.Console.Write($" ");
        else System.Console.Write($"+");
    }
    System.Console.WriteLine();
}
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col +1);
    }
}