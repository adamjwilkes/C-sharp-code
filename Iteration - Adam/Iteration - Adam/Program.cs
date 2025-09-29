using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

void Q1(int n)
{
    for (int i = n; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Blast-off!");
}

void Q2(int n)
{
    for (int i = 1; i <= n; i++)
    {
        string s = "";
        for (int k = 1; k <= i; k++)
        {
            s = s + "*";
        }
        Console.WriteLine(s);
    }
}

void Q3(int x, int y)
{
    string s1 = "";
    string s2 = "";
    for (int i = x; i > 0; i--)
    {
        s1 = s1 + "+---";
        s2 = s2 + "|   ";
    }
    s1 = s1 + "+";
    s2 = s2 + "|";
    for (int k = 0; k < y; k++)
    {
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
    Console.WriteLine(s1);
}



void Q6(int n)
{
    int total = 0;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("enter a number");
        total += Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine(total);
    Console.WriteLine(total / n);
}

bool IsPrime(double n)
{
    for (double i = 2; i <= Math.Sqrt(n); i++)
    {
        if ((n / i) % 1.0 == 0)
        {
            return false;
        }
    }
    return true;
}

bool IsPerfect(double n)
{
    double total = 0;
    for (double i = 1; i < n; i++)
    {
        if ((n / i) % 1 == 0)
        {
            total += i;
        }
    }
    if (total == n)
    {
        return true;
    }
    return false;
}


bool IsAbundant(double n)
{
    double total = 0;
    for (double i = 1; i < n; i++)
    {
        if ((n / i) % 1 == 0)
        {
            total += i;
        }
    }
    if (total > n)
    {
        return true;
    }
    return false;
}


bool IsFriendly(double n, double p)
{
    double totaln = 0;
    double totalp = 0;
    for (double i = 1; i < n; i++)
    {
        if ((n / i) % 1.0 == 0)
        {
            totaln += i;
            Console.WriteLine(i);
        }
    }
    for (double i = 1; i < p; i++)
    {
        if ((p / i) % 1.0 == 0)
        {
            totalp += i;
            Console.WriteLine(i);
        }
    }
    if (n / totaln == p / totalp)
    {
        return true;
    }
    return false;
}

Console.WriteLine(IsFriendly(6, 28));

void Binarysearch(int n)//between one and a hundred
{
    int upper = 100;
    int lower = 1;
    while (true)
    {
        int guess = (upper + lower) / 2;
        Console.WriteLine(guess);
        if (guess == n)
        {
            break;
        }
        if (n > guess)
        {
            lower = (upper + lower) / 2;
        }
        else
        {
            upper = (upper + lower) / 2;
        }
    }
}


string Reverse(string s)
{
    string[] splitted = s.Split(' ');
    string reversed = "";
    for (int i = splitted.Length - 1; i <= 0; i--)
    {
        reversed = reversed + splitted[i] + " ";
    }
    return reversed;
}

void Q12()
{
    long num = 105263157894736800; 
    while (true)
    {
        string final = num.ToString()[^1].ToString();
        long temp = num / 10;//1
        string s = num.ToString();
        s = final + temp;
        if (Convert.ToInt64(s) == 2 * num)
        {
            Console.WriteLine(num);
            break;
        }
        num++;
    }
} //i think the number is too big
Q12();

void BIO2003(string n)
{
    int total = 0;
    int index = 0;
    for (int i = 0; i <= 9; i++)
    {
        Console.WriteLine(total);
        if (n[i] == '?')
        {
            index += 10 - i;
            continue;
        }
        else if (n[i] == 'X')
        {
            total += 10;
        }
        else
        {
            total += (10 - i) * int.Parse(n[i].ToString());
        }
    }
    Console.WriteLine(total);
    for (int k = 0; k <= 10; k++)
    {
        if ((total + (k * index)) % 11 == 0)
        {
            Console.WriteLine(k);
        }
    }
}
