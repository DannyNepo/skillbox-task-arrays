internal class Program
{
    private static void Main(string[] args)
    {
        Random rndm = new Random();

        Console.WriteLine("введите количество строк двумерного массива: ");
        int lines = int.Parse(Console.ReadLine());
        Console.WriteLine("введите количество столбцов двумерного массива: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] array = new int[lines, columns];
        int sum = 0;

        for (int i = 0; i < lines; i++) 
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = rndm.Next(0, 10);
                Console.Write($"{array[i, j]}   ");
                sum += array[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine($"сумма всех элементов массива: {sum}");
    }
}