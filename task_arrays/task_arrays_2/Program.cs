namespace task_arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();

            Console.WriteLine("введите количество строк двумерного массива: ");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine("введите количество столбцов двумерного массива: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] arrayA = new int[lines, columns];
            int[,] arrayB = new int[lines, columns];
            int[,] arrayC = new int[lines, columns];

            Console.WriteLine("матрица А: ");

            for(int i = 0; i < lines; i++) 
            {
                for(int j = 0; j < columns; j++)
                {
                    arrayA[i, j] = rndm.Next(0, 10);
                    Console.Write($"{arrayA[i, j]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("матрица B: ");

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arrayB[i, j] = rndm.Next(0, 10);
                    Console.Write($"{arrayB[i, j]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("сумма матриц А и В: ");

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
                    Console.Write($"{arrayC[i, j]}  ");
                }
                Console.WriteLine();
            }


        }
    }
}