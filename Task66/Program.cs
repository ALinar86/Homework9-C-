int ShowSumOfDigits(int n, int m)
{
    if (n < m)
    {
        return n + ShowSumOfDigits(n + 1, m);
    }
    else return n;
}

Console.Write("Input a natural number 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a natural number 2: ");

int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"The sum of digits is {ShowSumOfDigits(n, m)}");
Console.WriteLine(ShowSumOfDigits(n, m));