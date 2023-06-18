Console.Clear();
        int[,,] array = GenerateArray();

        PrintArray(array);

    static int[,,] GenerateArray()
    {
        int[,,] array = new int[2, 2, 2];
        int number = 10;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = number++;
                }
            }
        }

        return array;
    }

    static void PrintArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
