// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Задай размер массива M на N: ");
var num = Console.ReadLine().Split(", ");
int m = Convert.ToInt32(num[0]);
int n = Convert.ToInt32(num[1]);
Random rand = new Random();
double[,] a = new double [m, n];
for (int i = 0; i < m; i++)
{
    for (int d = 0; d < n; d++)
    {
      a [i, d] = rand.Next(-100, 100)/10.0;
      Console.Write(String.Format("{0,5:f1}", a[i, d]));
    }
    Console.WriteLine();
}