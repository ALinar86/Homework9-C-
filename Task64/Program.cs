int NumOfDigit(int n)
{
    if (n >= 10)
    {
        return 1 + NumOfDigit(n / 10);
    }
    else if (n == 0)
    {
        return 1;
    }

    else return n / n;
}

Console.Write("Input a natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"The number of digits is {NumOfDigit(n)}");