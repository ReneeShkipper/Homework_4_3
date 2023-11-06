Console.WriteLine("Write the size of the array");
int N = int.Parse(Console.ReadLine());
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Fill the array");
int[,] array = new int[N, A];
int sum;
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < A; j++) array[i, j] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < A; j++) Console.Write($" {array[i, j]}");
    Console.WriteLine();
}
int sum_max = 0;
int i_max = 0;
for (int s = 0; s < A; s++)
{
    sum_max += array[0, s];  
}
    
for (int i = 0; i < N; i++)
{
    sum = 0;
    for (int j = 0; j < A; j++) sum += array[i, j];
    i_max = sum > sum_max ? i : i_max;
}
 
Console.WriteLine($"sum = {i_max}");
Console.ReadLine();