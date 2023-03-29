namespace NewExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int M = int.Parse(numeros[0]);
            int N = int.Parse(numeros[1]);

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] == X)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Position " + i + "," + j + ":");
                        
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i,j-1]);
                        }

                        if (j+1 < N)
                        {
                            Console.WriteLine("Right: " + matriz[i,j+1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i-1,j]);
                        }

                        if (i+1 < M)
                        {
                            Console.WriteLine("Down: " + matriz[i+1,j]);
                        }
                    }
                }
            }


        }
    }
}