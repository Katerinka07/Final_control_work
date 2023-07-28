int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
string EnterString(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] CreateArray(int size)
{
    return new string[size];
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = EnterString($"Введите {i + 1}-й элемент: ");  // заполнили массив с клавитуры
}

string[] NewStringArray(string[] array)
{
    int count = 0;  // считаем количество элементов, удовлетворяющих условию, чтобы определить длину нового массива
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    string[] newArr = new string[count]; 
    int j = 0;
    for (int i = 0; i < array.Length; i++)  // заполняем новый массив
    {
        if (array[i].Length <= 3)
        {
            newArr[j] = array[i];
            j++;
        }
    }
    return newArr;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine();
}
int size = InputNum("Введите количество элементов массива: ");
string[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
string[] newSortedArray = NewStringArray(myArray);
PrintArray(newSortedArray);

