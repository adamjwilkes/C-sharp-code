Console.WriteLine("enter number:");

string num = Console.ReadLine();

int input_num = int.Parse(num);

//Console.WriteLine((input_num / 2) * (1 + input_num));


int var = 0;

for (int i = 1; i <= input_num; i++)
{
    var = var + i;
}
Console.WriteLine(var);
