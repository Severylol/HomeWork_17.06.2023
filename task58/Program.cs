        int[,] matrix1 = {
            { 5, 4 },
            { 3, 7 }
        };

        int[,] matrix2 = {
            { 9, 6 },
            { 1, 2 }
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

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rowCount1 = matrix1.GetLength(0);
        int colCount1 = matrix1.GetLength(1);
        int rowCount2 = matrix2.GetLength(0);
        int colCount2 = matrix2.GetLength(1);

        if (colCount1 != rowCount2)
        {
            throw new ArgumentException("Неправильные размеры матриц для умножения");
        }

        int[,] resultMatrix = new int[rowCount1, colCount2];

        for (int i = 0; i < rowCount1; i++)
        {
            for (int j = 0; j < colCount2; j++)
            {
                int sum = 0;
                for (int k = 0; k < colCount1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        return resultMatrix;
    }
        Console.Clear();
        Console.WriteLine("Матрица 1:");
        PrintMatrix(matrix1);
        Console.WriteLine("\nМатрица 2:");
        PrintMatrix(matrix2);
        Console.WriteLine("\n\nРезультирующая матрица:");
        int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
        PrintMatrix(resultMatrix);
