void Q1()
{
    List<string> stack = new List<string>();

    do
    {
        Console.WriteLine("enter a string or press q to print the strings in reverse");
        string input = Console.ReadLine();
        if (input != "q")
        {
            stack.Add(input);
        }
        else
        {
            break;
        }
    }
    while (true);


}

//Q1();

void Q2()
{
    Console.WriteLine("enter a number to get its binary representation");
    string num = Console.ReadLine();
    int n = Convert.ToInt32(num);
    int remainder = 0;
    int quotient = 0;
    List<int> stack = new List<int>();
    do
    {
        remainder = n % 2;
        n = n / 2;
        stack.Add(remainder);
    }
    while (n != 1 && n!= 0);
    stack.Add(1);
    

    while (stack.Count != 0)
    {
        Console.WriteLine(stack[0]);
        stack.RemoveAt(0);
    }
}

//Q2();



void Q3()
{
    List<char> output = new List<char>();
    List<char> letters = new List<char>
{
    'E', 'A', 'S', '*', 'Y', '*', 'Q', 'U', 'E', '*', '*', '*', 'S', 'T', '*', '*', '*', 'I', 'O', '*', 'N', '*', '*', '*'
};

    foreach (char i in letters)
    {
        if (i != '*')
        {
            output.Add(i);
        }
        else if (output.Count() != 0)
        {
            Console.WriteLine(output[output.Count-1]);            
            output.RemoveAt(output.Count() - 1);
        }
        else
        {
            Console.WriteLine("cannot pop and empty list");
            break;
        }
    }

}

void Q5()
{
    List<char> output = new List<char>();
    List<char> letters = new List<char>
{
    'E', 'A', 'S', '*', 'Y', '*', 'Q', 'U', 'E', '*', '*', '*', 'S', 'T', '*', '*', '*', 'I', 'O', '*', 'N', '*', '*', '*'
};

    foreach (char i in letters)
    {
        if (i != '*')
        {
            output.Add(i);
        }
        else if (output.Count() != 0)
        {
            Console.WriteLine(output[0]);
            output.RemoveAt(0);
            
        }
        else
        {
            Console.WriteLine("cannot pop and empty list");
            break;
        }
    }

}

Q3();

//4 6 8 7 5 3 2 9 0 1
