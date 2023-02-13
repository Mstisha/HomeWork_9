int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число!");
        }
    }

    return result;
}

int Rekursion(int a, int b)
{
    int sum = 0;
    if(a < b)
    {
        sum = (b + a) * (b - a + 1) / 2;
    }
    return sum;
}

Console.WriteLine();

int number1 = GetNumber("Введите число: ");
int number2 = GetNumber("Введите число: ");
Console.WriteLine(Rekursion(number1, number2));