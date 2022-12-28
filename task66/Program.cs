Console.WriteLine("введите меньшее число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите большее число");
int N = Convert.ToInt32(Console.ReadLine());
int RecSum(int a, int b)
{
if (a==b) 
    return b;
else
    return a + RecSum(a-1, b);
}
if (N>M)
Console.Write(RecSum(N,M));
else
Console.WriteLine("вы неправильно ввели числа");