using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Numerics;
using Microsoft.VisualBasic;

int Sum(int[] list)
{
    int total = 0;
    foreach (int i in list)
    {
        total += i;
    }
    return total;
}



int min(int[] list)
{
    int min = list[0];
    foreach (int i in list)
    {
        if (i < min)
        {
            min = i;
        }
    }
    return min;
}

int max(int[] list)
{
    int max = list[0];
    foreach (int i in list)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}

List<int> countnegative(int[] listinput)
{
    List<int> negatives = [];
    foreach (int i in listinput)
    {
        if (i < 0)
        {
            negatives.Add(i);
        }
    }
    return negatives;
}
Console.WriteLine(countnegative([1,4,5,-1,-5]));
bool sameitems(List<int> list1, List<int> list2)
{
    int total = 0;
    foreach (int i in list1)
    {
        foreach (int k in list2)
        {
            if (k == i)
            {
                total += 1;
                break;
            }
        }
    }
    total = 0;
    foreach (int p in list2)
    {
        foreach (int q in list1)
        {
            if (p == q)
            {
                total += 1;
                break;
            }
        }
    }    
    if (total == list2.Count)
    {
        return true;
    }
    return false;
}

bool linearsearch<T>(List<T> n, T k)
{
    foreach (T i in n)
    {
        if (i.ToString() == k.ToString())
        {
            return true;
        }
    }
    return false;
}

bool binarysearch(List<int> list, int n)
{
    int upper = list.Count() - 1;
    int lower = 0;
    int mid = 0;
    while (Math.Abs(upper - lower) != 0)
    {
        mid = (upper + lower) / 2;

        if (n > list[mid])
        {
            lower = (int)Math.Ceiling((upper + lower + 1) / 2.0);
        }
        else if (list[mid] > n)
        {
            upper = (int)Math.Floor((upper + lower - 1) / 2.0);
        }
        else
        {
            return true;
        }
    }
    mid = (upper + lower) / 2;
    
    if (list[mid] == n)
    {
        return true;
    }
    return false;

}

List<int> duplicates(List<int> list, HashSet<int> elements)
{
    list.Sort();
    int previous = list[0];
    for (int i = 1; i <= list.Count() - 1; i++)
    {
        if (i == previous)
        {
            elements.Add(i);
        }
        previous = list[i];
    }
    return elements.ToList();
}

bool subset<T>(List<T> lista, List<T> listb)
{
    int truecount = 0;
    foreach (T i in lista)
    {
        if (listb.Contains(i))
        {
            truecount += 1;
            continue;
        }
        break;

    }
    if (truecount == lista.Count())
    {
        return true;
    }
    truecount = 0;
    foreach (T k in listb)
    {
        if (lista.Contains(k))
        {
            truecount += 1;
            continue;
        }
        break;

    }
    if (truecount == listb.Count())
    {
        return true;
    }
    return false;
}

List<T> Reverse<T>(List<T> list)
{
    list.Reverse();
    return list;
}

List<int> bubblesort(List<int> list)
{
    int tempvar = 0;
    int changes = 0;
    do
    {
        changes = 0;
        for (int i = 0; i < list.Count(); ++i)
        {
            if (list[i] > list[i + 1])
            {
                list[i] = tempvar;
                list[i] = list[i + 1];
                list[i + 1] = tempvar;

                changes += 1;
            }
        }
    }
    while (changes != 0);
    return list;
}

//List<int> mergesort(List<int> list)
{

}