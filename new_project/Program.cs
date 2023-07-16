// напишите программу , которая из имеющегося массива строк формирует массив строк, длина которых меньше или равна 3 символа. 
//первоначальный массив можно ввести с клавиатуры , либо задать на старте выполнения алгоритма . при решении не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.["Hello","2","World",":-)"] -> ["2",":-)

string[] GetDataFromUser(string message)
{
        
    Console.WriteLine(message);
    string input = Console.ReadLine();
    string[] inputArray = input.Split(',');
    return inputArray;
}

string[] FilterArray(string[] inputArray)
{
    int count = 0;
    foreach (string item in inputArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    int index = 0;
    foreach (string item in inputArray)
    {
        if (item.Length <= 3)
        {
            resultArray[index] = item;
            index++;
        }
    }

    return resultArray;
}

string[] inputArray = GetDataFromUser("Введите элементы массива, разделяя их запятыми:");
string[] resultArray = FilterArray(inputArray);
Console.Write("Результат: [");
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i]);
    if (i < resultArray.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");
