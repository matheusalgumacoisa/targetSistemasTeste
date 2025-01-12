Console.WriteLine("Entre com um numero");
int n = Int32.Parse(Console.ReadLine()); 
int[] prev = new int[2];

int f = 0;
int i = 0;
while(f<n)
{
    if (i <= 1) f = i; 
    else f = prev[0] + prev[1];
    prev[i % 2] = f;
    Console.WriteLine(f);

    if(f == n)
    {
        f = -1;
        break;
    }
    i++;
}

if (f == -1) Console.WriteLine(n +" faz parte da sequencia de fibonacci");
else Console.WriteLine(n + " NÃO faz parte da sequencia de fibonacci");