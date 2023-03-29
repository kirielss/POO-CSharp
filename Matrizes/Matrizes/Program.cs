namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N,N];
            int[] mainD = new int[N];
            int negative = 0;

            for (int i = 0; i < N; i++)
            {
                string[] row = Console.ReadLine().Split(' ');

                for (int j = 0; j < row.Length; j++)
                {
                    mat[j,i] = int.Parse(row[j]);

                    if (j == i)
                    {
                        mainD[j] = int.Parse(row[j]);
                    }

                    if (mat[j,i] < 0)
                    {
                        negative++;
                    }
                }
            }

            Console.WriteLine("Main Diagonal:");
            foreach (int num in mainD)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Negative numbers = " + negative);

        }
    }
}