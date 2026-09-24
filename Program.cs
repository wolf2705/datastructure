Console.WriteLine("Hello, World!");
Console.WriteLine(CountDigits(2));


static int CountDigits(int numbers)
{
    if (numbers < 10)
    {
        // Console.WriteLine("1");
        return 1;
    }
    else
    {
        var xl = 1 + CountDigits(numbers / 10);
        //Console.WriteLine(xl);
        return xl;
    }
}

