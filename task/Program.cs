using System;
using static System.Console;
Clear();

string[] GetArrayStringConsole (string inConsolSymbol)
{
    // Создаем массив символов с длиной, равной длине входной строки
    string[] arraySymbol = new string[inConsolSymbol.Length];
    // Разбиваем входную строку по запятой и присваиваем полученные значения элементам массива
    arraySymbol = inConsolSymbol.Split();
    return arraySymbol;
}
string[] GetArrayThreeSymbol (string[] array)
{
    int count = 0;
    // Считаем количество строк, длина которых меньше или равна 3 символам
    for (int i = 0; i < array.Length; i++)
    {
        string Symbol = array[i];
        if (Symbol.Length <= 3)
        {
            count++;
        }
    }
    // Создаем новый массив с количеством элементов, равным count
    string[] arrayThreeSymbol = new string[count];
    // Заполняем новый массив только строками из исходного массива, длина которых меньше или равна 3 символам
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string Symbol = array[i];
        if (Symbol.Length <= 3)
        {
            arrayThreeSymbol[j] = Symbol;
            j++;
        }
    }
    return arrayThreeSymbol;
}
void Print (string[] array)
{
    // Выводим все элементы массива на экран через запятую
    for (int i = 0; i < array.Length; i++)
    {
        Write($"[{String.Join(", ", array)}]");
    }
    WriteLine();
}
// Запрашиваем у пользователя ввод массива строк через запятую
Write("Введите массив строк через запятую: ");
string inStringSymbol = ReadLine();
// Создаем массив символов, полученных от пользователя
string[] arraySymbol = GetArrayStringConsole(inStringSymbol);
WriteLine();
Write("Введенные символы: ");
Print(arraySymbol);
Write("Введенные символы длинной меньше либо равны 3: ");
// Выводим только строки из исходного массива, длина которых меньше или равна 3 символам
Print(GetArrayThreeSymbol(arraySymbol));
WriteLine();