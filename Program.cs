Console.WriteLine("--- Tabuada ---");

int n = 1;
int x; // Altere para 

x = Convert.ToInt32(Console.ReadLine());
n = Convert.ToInt32(Console.ReadLine());

while (n <= 10)
{
    Console.WriteLine($"{x} x {n} = {x * n}");

    n = n + 1;
}
