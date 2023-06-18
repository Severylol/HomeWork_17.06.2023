Console.Clear();
int[,] array = FillSpiralArray(4);

        PrintArray(array);

    static int[,] FillSpiralArray(int size)
    {
        int[,] array = new int[size, size];

        int value = 1;
        int minRow = 0, maxRow = size - 1;
        int minCol = 0, maxCol = size - 1;

        while (value <= size * size)
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                array[minRow, i] = value++;
            }
            minRow++;

            for (int i = minRow; i <= maxRow; i++)
            {
                array[i, maxCol] = value++;
            }
            maxCol--;

            if (minRow <= maxRow)
            {
                for (int i = maxCol; i >= minCol; i--)
                {
                    array[maxRow, i] = value++;
                }
                maxRow--;
            }

            if (minCol <= maxCol)
            {
                for (int i = maxRow; i >= minRow; i--)
                {
                    array[i, minCol] = value++;
                }
                minCol++;
            }
        }

        return array;
    }

    static void PrintArray(int[,] array)
    {
        int size = array.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{array[i, j]:D2} ");
            }
            Console.WriteLine();
        }
    }