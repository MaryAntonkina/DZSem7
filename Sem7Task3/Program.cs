// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.



void Main()
{
int arraySize = ReadInt("Введите размер массива: ");
int[] array = GenerateArray(arraySize, 10, 100);
System.Console.WriteLine(string.Join(" ", array)); // вывод на печать рандомного массива
PrintArray(array, array.Length - 1); // обратный рекурсивный вывод массива
}


void PrintArray(int[] array, int index)
{       
    if(index < 0) return;
    System.Console.Write(array[index] + " ");
    PrintArray(array, index - 1);
}


int[] GenerateArray(int size, int minValue, int maxValue)
{
int[] tempArray = new int[size];
Random rand = new Random();

for (int i = 0; i < tempArray.Length; i++)
tempArray[i] = rand.Next(minValue, maxValue);

return tempArray;
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine()); 
}

Main();
