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

void Rekursion(int n, int i)
{
    if(i <= n)
    {
        Console.WriteLine($"{n}");
        n = n - 1;
        Rekursion(n, i);
    }
}

Console.WriteLine();
int i = 1;
int numbers = GetNumber("Введите натуральное число: ");
Rekursion(numbers, i);