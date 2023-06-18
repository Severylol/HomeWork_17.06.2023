internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        static void ReverseMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                SortRowDescending(matrix, i);
            }

            Console.WriteLine("Упорядоченный массив:");
            PrintMatrix(matrix);
        }

        static void SortRowDescending(int[,] matrix, int rowIndex)
        {
            int rowLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength - 1; i++)
            {
                for (int j = 0; j < rowLength - i - 1; j++)
                {
                    if (matrix[rowIndex, j] < matrix[rowIndex, j + 1])
                    {
                        int temp = matrix[rowIndex, j];
                        matrix[rowIndex, j] = matrix[rowIndex, j + 1];
                        matrix[rowIndex, j + 1] = temp;
                    }
                }
            }
        }
        Console.Clear();
        Console.WriteLine("Исходный массив:");
        PrintMatrix(array);
        Console.WriteLine("\n\n\n");
        ReverseMatrix(array);
    }
}