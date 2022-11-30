//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void FillingResultArray(string[] array, string[] result)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        result[count] = array[i];
        count++;
        }
    }
}
void PrintResultArray(string[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"{result[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();
string[] array = new string[16] {"Hi", "hello", "news", "world", "us", "er", "good", "Tha","33254", "nk", "you", "100", "time", "tim", "12029487", "es"};
string[] result = new string[array.Length];
FillingResultArray(array, result);
PrintResultArray(result);