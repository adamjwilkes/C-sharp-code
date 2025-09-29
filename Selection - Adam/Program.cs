static void Q1(int a, int b)
{
    if (a == b)
    {
        Console.WriteLine("equal");
    }
    else
    {
        Console.WriteLine("Not equal");
    }
}

static void Q2(int year)
{
    if (year % 400 == 0)
    {
        Console.WriteLine("leap year");
    }
    else if (year % 100 == 0)
    {
        Console.WriteLine("not leap yar");
    }
    else if (year % 4 == 0)
    {
        Console.WriteLine("Leap year");
    }
    else
    {
        Console.WriteLine("not leap year");
    }
}

static void Q13(int a, int b, int c)
{
    if (a == b && b == c)
    {
        Console.WriteLine("equilateral");
    }
    else if (a >= b + c || b >= a + c || c >= b + a)
    {
        Console.WriteLine("impossible");
    }
    else if (a == b || b == c || a == c)
    {
        Console.WriteLine("isosceles");
    }
    else
    {
        Console.WriteLine("scalene");
    }
}

Q13(12, 13, 5);