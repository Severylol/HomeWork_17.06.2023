Console.Clear();
        int N = 18; 
        int[][] pascalTriangle = GeneratePascalTriangle(N);

        PrintPascalTriangle(pascalTriangle);

    static int[][] GeneratePascalTriangle(int N)
    {
        int[][] triangle = new int[N][];

        for (int i = 0; i < N; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;
            triangle[i][i] = 1;

            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        return triangle;
    }

    static void PrintPascalTriangle(int[][] triangle)
    {
        int N = triangle.Length;

        int maxDigits = triangle[N - 1][N / 2].ToString().Length;

        for (int i = 0; i < N; i++)
        {
            int numSpaces = (N - i - 1) * (maxDigits + 1) / 2;

            for (int j = 0; j < numSpaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                string number = triangle[i][j].ToString().PadLeft(maxDigits);

                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }