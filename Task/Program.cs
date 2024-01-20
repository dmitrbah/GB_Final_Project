void CreateInputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

string[] ModifyArray(string[] array)
{
    int modifiedArraySize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            modifiedArraySize++;
        }
    }
    string[] resultArray = new string[modifiedArraySize];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"\"{array[i]}\"");
        }
        else
        {
            Console.Write($"\"{array[i]}\", ");
        }
    }
    Console.WriteLine("]");
}

Console.Write("Введите размер первоначального массива: ");
int inputArraySize = Convert.ToInt32(Console.ReadLine());
string[] inputArray = new string[inputArraySize];
CreateInputArray(inputArray);
PrintArray(inputArray);
string[] resultArray = ModifyArray(inputArray);
PrintArray(resultArray);