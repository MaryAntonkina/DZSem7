// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int number1 = ReadInt("Введите значение M: ");
    int number2 = ReadInt("Введите значение N: ");
    PrintNumber(number1, number2);
}

void PrintNumber(int N, int M)
{
    if (N < M - 1)
    {
        M--;
        PrintNumber(N, M);  
        System.Console.Write(M + " ");
    }
    else if (N - 1 > M) 
    {
        N--;
        PrintNumber(N, M);
        System.Console.Write(N + " ");
    }
    else return;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
