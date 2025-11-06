using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

int Nextonathursday()
{
    for (int i = 2026; i > 0; i++) //i is the year
    {
        int today = (int)(new DateTime(i, 11, 6).DayOfWeek);
        if (today == 4) //checking if the day of 6th nov is thursdayfor each year
        {
            return i;
        }
    }
    return 0;
}

Console.WriteLine(Nextonathursday());

int CuttingChocolate(int cuts)
{
    if (cuts % 2 == 0)
    {
        return (cuts / 2)*(cuts/2);   
    }
    else
    {
        return ((cuts - 1) / 2) * ((cuts + 1) / 2);
    }
}



bool Validatepassword(string candidate)
{
    bool upper = false;
    bool lower = false;
    bool digit = false;
    int repeat = 0;
    int ascii_sum = 0;

    if (candidate.Length < 8 || candidate.Length > 32)
    {
        return false;
    }

    foreach (char i in candidate)
    {
        repeat = 0; 
        if (i.ToString().ToUpper() != i.ToString()) //checking for lowercase
        {
            lower = true;
        }
        if (i.ToString().ToLower() != i.ToString()) //checking for uppercase
        {
            upper = true;
        }
        if (char.IsDigit(i) == true) //checking for digits
        {
            digit = true;
        }
        ascii_sum += (int)i; //adding the ASCII for each char
        foreach (char k in candidate) // checking for repeated characters
        {
            if (i == k)
            {
                repeat += 1;
            }
        }
        if (repeat >= 2)
        {
            return false;
        }
    }
    if (ascii_sum % 11 != 0) //checking if the ascii sum is a multiple of 11
    {
        return false;
    }

    if (upper == true && lower == true & digit == true) //checking all condiions remaining have been met
    {
        return true;
    }
    return false;
}

int EatingSweets(List<int> pileSizes, int numhours)
{
    int hours_needed = 0;
    for (int sph = 1; sph >= 0; sph++) //checking each sph untl one works
    {
        foreach (int n in pileSizes)
        {
            if (n % sph == 0)
            {
                hours_needed += (int)(n / sph);
            }
            else
            {
                hours_needed += (int)(n / sph) + 1;
            }
        }
        if (hours_needed <= numhours)
        {
            return sph;
        }
    }
    return 0;
}




