using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

int Q2(string num)
{
    int total = 0;
    foreach (char i in num)
    {
        total += Convert.ToInt32(i.ToString());
    }
    return total;
}

//Console.WriteLine(Q2("425"));

bool Q3(double n)
{
    for (double i = 2; i <= Math.Sqrt(n); i++)
    {
        if ((n / i) % 1 == 0)
        {
            Console.WriteLine($"{i} {n} {n/i}");
            return true;
        }
    }
    return false;
}


//Console.WriteLine(Q3(5));

int Q4(string s)
{
    int total = 0;
    foreach (char i in s)
    {
        if (i == ' ')
        {
            total++;
        }
    }
    return total;
}

void Q5(ref int i1, ref int i2)
{
    int temp_var = i1;
    i1 = i2;
    i2 = temp_var;
}

string Q6(int num, int base1)
{
    string s = "";
    double digits = 0;
    double temp = Math.Log(num, base1);
    digits = Math.Ceiling(temp);


    if (base1 == 2)
    {
        for (double i = digits; i >= 0; i--)
        {


            if (Math.Pow(base1, i) <= num)
            {
                num -= (int)Math.Pow(base1, i);
                s = s + "1";
            }
            else
            {
                s = s + "0";
            }
        }
    }
    else
    {
        for (double i = digits; i >= 0; i--)
        {
            if (Math.Pow(base1, i) <= num)
            {
                int result = Convert.ToInt32(Math.Floor(num / (Math.Pow(base1, i))));
                if (result >= 10)
                {
                    s = s + (char)(result + 55);
                    num -= result * (int)(Math.Pow(base1, i));
                }
                else
                {
                    s = s + result.ToString();
                    num -= result * (int)(Math.Pow(base1, i));
                }
            }
            else
            {
                s = s + "0";
            }
        }
    }
    return s;
}

Console.WriteLine(Q6(257, 2));

void Q7(string multiply = "12", string rows = "12")
{
        int num = int.Parse(multiply);
        int row = int.Parse(rows);

        for (int i = 1; i <= row; i++)
        {

            if (num * i > 99)
            {
                Console.WriteLine(num * i);
            }
            else if (num * i > 9)
            {
                Console.WriteLine("0" + num * i);
            }
            else
            {
                Console.WriteLine("00" + num * i);
            }
        }
}