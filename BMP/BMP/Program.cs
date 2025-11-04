using System.Reflection.Metadata;
byte[] bytes = File.ReadAllBytes("sps.bmp");


if (bytes[0].ToString("X2") == "42" && bytes[1].ToString("X2") == "4D")
{
    Console.WriteLine("bitmap image");

}
else
{
    Console.WriteLine("not bitmap image");
}

byte b18 = bytes[18];
byte b19 = bytes[19];
byte b20 = bytes[20];
byte b21 = bytes[21];
byte b22 = bytes[22];
byte b23 = bytes[23];
byte b24 = bytes[24];
byte b25 = bytes[25];

int width = b18 | b19 << 8 | b20 << 16 | b21 << 24;
int height = b22 | b23 << 8 | b24 << 16 | b25 << 24;

Console.WriteLine($"dimensions are {width} x {height}");
string blue;
string green;
string red;
string hex;
Dictionary<string, int> colourcount = new Dictionary<string, int>();
for (int i = 54; i < bytes.Length-2; i += 3) //bgr
{
    blue = bytes[i].ToString("X2");
    green = bytes[i + 1].ToString("X2");
    red = bytes[i + 2].ToString("X2");
    hex = blue + green + red;

    if (colourcount.ContainsKey(hex))
    {
        colourcount[hex] += 1;
    }
    else
    {
        colourcount.Add(hex, 1);
    }
}

int mostcommon = colourcount.Values.Max();

Console.WriteLine($"there are {colourcount.Count()} colours");

foreach (string i in colourcount.Keys)
{
    if (colourcount[i] == mostcommon)
    {
        Console.WriteLine($"most common colour is {i}");
    }
}