Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
int RecNum(int n)
{
if (n==1) 
return 1;
else
{ 
    Console.Write(n + " ");
    return RecNum(n-1);
}
}
Console.WriteLine(RecNum(N));