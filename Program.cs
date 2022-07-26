/*
Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
*/

/*
string[] names = { "grandas", "Abibas", "ss", "After", "adik", "Ssd", "s" };
char[] glasnie = new char[6] { 'a','e','i','o','u','y', };
int kolvo(string[] words, char[] x)
{
    int sum = 0;
    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < x.Length; j++)
        {
            if (words[i].ToLower()[0] == x[j]) sum++;
        }
    }
    return sum;
}

Console.WriteLine(kolvo(names, glasnie));
*/

/*
string[] obedinenie(string[] words, string[] words2)
{
    string[] array = new string[words.Length];
    for (int i = 0; i < words.Length; i++)
    {
        array[i] = words[i]+words2[i];
    }
    return array;
}

void Vivod(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] NewStr(int x, string[] str)
{
    int z = 1;
    string[] array = new string[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        Console.WriteLine("Напишите " + z + "е слово");
        array[i] = Console.ReadLine();
        z++;
    }
    return array;
}


string[] names = { "Прекрасный ", "Ужасный ", "Стремительный ", "Целый "};
string[] names2 = new string[4];
Vivod(obedinenie(names, NewStr(4, names2)));
*/

