// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


Console.WriteLine("Введите размер массива");
int sizeArr = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArr];
var rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    int stringSize = rand.Next(1, 5);
    for (int j = 0; j < stringSize; j++)
    {
        array[i] += (char)rand.Next('a', 'z');
    }
}
Console.WriteLine("Исходный массив");
Console.WriteLine("[" + string.Join(", ", array) + "]");
int sizeSecondArr = 0;
string[] arrThreeSize = new string[sizeSecondArr];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        sizeSecondArr++;
        Array.Resize(ref arrThreeSize, sizeSecondArr);
        arrThreeSize[sizeSecondArr - 1] = array[i];
    }
}
Console.WriteLine();
Console.WriteLine("Массив на выходе");
Console.WriteLine("[" + string.Join(", ", arrThreeSize) + "]");
