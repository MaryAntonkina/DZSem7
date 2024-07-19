// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

void Main()
{
int number1 = ReadInt("Введите значение m: ");
int number2 = ReadInt("Введите значение n: ");
System.Console.WriteLine(CalculateAckermann(number1, number2)); 
}

int CalculateAckermann(int m, int n)
{
    if (m == 0)
    {
        return(n + 1);
    }
    else if (m > 0 && n == 0) 
    {
        return(CalculateAckermann(m - 1, 1));
    }
    else if (m > 0 && n > 0)
        return(CalculateAckermann(m - 1, CalculateAckermann(m, n -1)));

    return 0;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    int number;
    do
    {
        number = Convert.ToInt32(Console.ReadLine());
        if (number < 0)
        {
            System.Console.WriteLine("Введите неотрицательное число!\n");
        }
    } while (number < 0);

    return number;
    
}

Main();
