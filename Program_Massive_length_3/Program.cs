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

Console.WriteLine("Если хотите задать массив вручную, то введите 1. Если нет, то введите 0.");
int manuallyOrNot = Convert.ToInt32(Console.ReadLine());

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

PrintArray(array);