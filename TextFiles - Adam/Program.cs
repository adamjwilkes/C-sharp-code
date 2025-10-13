using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

void Exercise1()
{
    string input = "";
    string write = "";
    do
    {
        Console.WriteLine("enter a sentence");
        input = Console.ReadLine();
        write += input;

    }
    while (input != "");
    File.WriteAllText("sentences.txt", write);
}




void stations2()
{
    foreach (string line in File.ReadAllLines("stations.txt"))
    {
        string[] stations = line.Split(", ");
        if (stations[0].ToLowerInvariant().Contains("station"))
        {
            Console.WriteLine(line);
        }
    }
}

void stations3()
{
    int counter = 0;
    List<string> fishes = new List<string> { "mackerel", "piranha", "sturgeon", "bacteria" };
    foreach (string trainlines in File.ReadAllLines("stations.txt"))
    {
        string line = trainlines.Split(", ")[0];
        foreach (string fish in fishes)
        {
            counter = 0;
            foreach (char i in fish)
            {

                if (line.ToLower().Contains(i))
                {
                    break;
                }
                counter += 1;
                //Console.WriteLine('a');

                if (counter == fish.Length)
                {
                    Console.WriteLine($"{line} contains no identical letters to {fish}");
                }
            }

        }
    }
}

void stations4()
{
    foreach (string line in File.ReadAllLines("stations.txt"))
    {
        string[] commas = line.Split(',');
        string[] words = commas[0].Split(' ');
        if (words.Count() == 2)
        {
            if (words[0][0] == words[1][0])
            {
                Console.WriteLine(words[0] + ' ' + words[1]);
            }
        }
    }
}

void stations5()
{
    List<string> trainlines = [];
    List<int> nums = [];
    foreach (string line in File.ReadAllLines("stations.txt"))
    {
        string[] commas = line.Split(", ");
        for (int i = 1; i < commas.Count(); i++)
        {
            if (!trainlines.Contains(commas[i]))
            {
                trainlines.Add(commas[i]);
                nums.Add(1);
            }
            else
            {
                nums[trainlines.IndexOf(commas[i])] += 1;
            }
        }
    }
    Console.WriteLine(trainlines[nums.IndexOf(nums.Max())]);
}


void thirtyninesteps1()
{
    string content = File.ReadAllText("thirty-nine-steps.txt");
    Console.WriteLine(content.Reverse().ToArray());
}


void thirtyninesteps2()
{
    List<string> lines = File.ReadAllLines("thirty-nine-steps.txt").ToList();
    for (int i = lines.Count() - 1; i >= 0; i--)
    {
        Console.WriteLine(lines[i]);
    }
}

void thirtyninesteps3()
{
    string content = File.ReadAllText("thirty-nine-steps.txt");
    string[] words = content.Split(' ');
    for (int i = words.Count() - 1; i >= 0; i--)
    {
        Console.WriteLine(words[i]);
    }
}

Dictionary<string, int> wordfrequency(string filename)
{
    string[] words = File.ReadAllText(filename).Split(' ');
    for (int i = 0; i < words.Count(); i++)
    {
        words[i] = Regex.Replace(words[i], @"[^A-Za-z]+", "");
    }
    Dictionary<string, int> freq = new Dictionary<string, int>();
    foreach (string i in words)
    {
        if (freq.ContainsKey(i))
        {
            freq[i] += 1;
        }
        else
        {
            freq.Add(i, 1);
        }
    }
    return freq;
}

void Bytes(string filname)
{
    List<string> hex = new List<string>();
    byte[] content = File.ReadAllBytes(filname);
    foreach (int i in content)
    {
        hex.Add(i.ToString("X2"));
    }
    foreach (string i in hex)
    {
        Console.WriteLine(i);
    }
}

Bytes("thirty-nine-steps.txt");