using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

/*

//-------------------------------------------------------

Q1

Console.WriteLine("Enter minutes");
string minutes = Console.ReadLine();
Console.WriteLine("Enter seconds");
string seconds = Console.ReadLine();

//https://stackoverflow.com/questions/15294878/how-the-int-tryparse-actually-works

if (double.TryParse(minutes, out double min))
{
    min *= 60;
}
else 
{
    Console.WriteLine("invalid");
}

double total = min + int.Parse(seconds);

double hours = total / 3600;

//6.2 miles


double temp1 = 10000 / total;

double temp2 = 6.2 / hours;

string ms = Convert.ToString(temp1);

string mph = Convert.ToString(temp2);

Console.WriteLine("The runner's speed in m/s is " + ms);

Console.WriteLine("The runner's speed in mph is " + mph);*/

//------------------------------------------------------------------

/*

Q2

Console.WriteLine("Enter number to multiply");
string multiply = Console.ReadLine();
Console.WriteLine("Enter number of rows");
string temp = Console.ReadLine();

int num = int.Parse(multiply);
int row = int.Parse(temp);

// used w3 schools for for loops

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
} */

//--------------------------------------------------------------

/*

Q3

Console.WriteLine("Enter a, r or c");
string arc = Console.ReadLine();
Console.WriteLine("Enter value of " + arc);
string value = Console.ReadLine();

double radius;

if (arc == "a")
{
    radius = Math.Sqrt(double.Parse(value) / Math.PI);
}
else if (arc == "r")
{
    radius = double.Parse(value);
}
else
{
    radius = double.Parse(value) / (2 * Math.PI);
}

double area = Math.Round(Math.PI * (Math.Pow(radius, 2)), 2);

double circumference = Math.Round(2 * Math.PI * radius, 2);

Console.WriteLine($"area is {Math.Round(area)}, circumference is {circumference} and radius is {radius}");*/
Console.WriteLine($"{24 / 16}");
ConvertToInt.32(2.5);