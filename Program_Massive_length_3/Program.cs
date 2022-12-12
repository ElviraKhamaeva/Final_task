// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        arr[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    Console.Write(String.Join(", ", arr));
    Console.WriteLine("]");
}

string[] FindArrayElementsLess3(string[] arr)
{
    string[] arr2 = new string[0];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            j++;
            Array.Resize(ref arr2, j);
            arr2[j - 1] = arr[i];
        }
    }
    return arr2;
}

Console.Clear();
Console.WriteLine("Если хотите задать массив вручную, то введите 1. Если нет, то введите 0.");
int manuallyOrNot = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string[] array = new string[] { };

if (manuallyOrNot == 0)
{
    array = new string[] { "Geekbrains", "Hello", "world", "123", "-2", "var" };
}
else
{
    Console.WriteLine("Сколько строк хотите ввести?");
    int size = Convert.ToInt32(Console.ReadLine());
    array = new string[size];
    FillArray(array);
}

Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Элементы, длина которых меньше, либо равна 3 символам: ");
PrintArray(FindArrayElementsLess3(array));