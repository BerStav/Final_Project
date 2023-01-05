// Задача написать программу, которая из имеющегося массива строк, 
// длина которых меньше либо равна 3м символам. 
// Первоначальный массив задается на старте выполнения алгоритма. 
// При решении задачи используются только массивы, без использования коллекций.

string[] arrayOrig = new string[5] { "hi", "Russia", "135", "1", "hello" };
string[] arrayFinal = new string[arrayOrig.Length];

void SelectionArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = arrayOrig[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

SelectionArray(arrayOrig, arrayFinal);
PrintArray(arrayFinal);