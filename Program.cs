int[] InputSomeNums()
{
    Console.Write("Введите количество чисел: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
        else
            Console.Write(".");
    }
}

int[] myArray = InputSomeNums();
PrintArray(myArray);
