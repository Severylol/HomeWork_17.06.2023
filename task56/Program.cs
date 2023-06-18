int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };
        static void PrintMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        static int FindRowWithMinSum(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            int minRow = 0;
            int minSum = int.MaxValue;

            for (int i = 0; i < rowCount; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < colCount; j++)
                {
                    rowSum += matrix[i, j];
                }

                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minRow = i;
                }
            }

            return minRow;
        }
                    Console.Clear();
            Console.WriteLine("Исходный массив:");
            PrintMatrix(array);
            Console.WriteLine("\n\n\n");
            int minRow = FindRowWithMinSum(array);
            Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1} строка");