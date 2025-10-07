using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;

void wave(string w)
{
    for (int i = 0; i < w.Length; i++)
    {
        if (w[i] == ' ')
        {
            continue;
        }
        string word = "";
        for (int k = 0; k < w.Length; k++)
        {
            if (k == i)
            {
                word += char.ToUpper(w[i]);
            }
            else
            {
                word += w[k];
            }
        }
        Console.WriteLine(word);
    }
}

void hello()
{
    foreach (char i in "hello")
    {
        Console.WriteLine((int)i);
    }

    foreach (char i in "你好")
    {
        Console.WriteLine((int)i);
    }

    byte[] bytelist = Encoding.Default.GetBytes("hello");

    foreach (byte i in bytelist)
    {
        Console.WriteLine(i);
    }

    byte[] bytelistc = Encoding.Default.GetBytes("你好");

    foreach (byte i in bytelistc)
    {
        Console.WriteLine(i);
    }
}

void charactercodes(List<int> list)
{
    StringBuilder build = new StringBuilder();
    foreach (int i in list)
    {
        char c = (char)i;
        build.Append(c);
    }
    Console.WriteLine(build);
}

int Anagram(string main, List<string> list)
{
    int total = 0;
    int counter = 0;
    foreach (string i in list)
    {
        counter = 0;
        List<char> charlist = i.ToCharArray().ToList();
        foreach (char k in main)
        {
            if (charlist.Contains(k))
            {
                charlist.Remove(k);
                counter += 1;
            }
            else
            {
                break;
            }
            if (counter == main.Length)
            {
                total += 1;
            }
        }
    }
    return total;
}

string Case(string str, string case1)
{
    string final = "";
    string[] words = str.Split(' ');
    if (case1 == "camelCase")
    {
        int counter = 0;
        foreach (string i in words)
        {
            if (counter == 0)
            {
                final += i.ToLower();
                counter += 1;
            }
            else
            {
                if (i.Length == 1)
                {
                    final += i.ToUpper();
                    continue;
                }
                final += char.ToUpper(i[0]) + i.Substring(1);

            }

        }
    }
    else if (case1 == "PascalCase")
    {
        foreach (string i in words)
        {
            if (i.Length == 1)
            {
                final += i.ToUpper();
                continue;
            }
            final += char.ToUpper(i[0]) + i.Substring(1);
        }
    }
    else
    {
        foreach (string i in words)
        {
            final += i + '_';
        }
        final = final.Substring(0, final.Length - 1);
    }
    return final;
}

void PigLatin(string s)
{
    string final = "";
    string[] words = s.Split(' ');
    foreach (string i in words)
    {
        if (i[0] == '"')
        {
            final += '"' + i.Substring(2, i.Length - 2) + i[1] + "ay" + " ";
        }
        final += i.Substring(1,i.Length - 1) + i[0] + "ay" + " ";
    }
    Console.WriteLine(final.Substring(0, final.Length - 1));
}
