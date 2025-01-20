// Дана целочисленная матрица А (5, 7). Вывести в текстовое окно все строки, в которых чередуются четные и нечетные элементы.

namespace Task3;

class Matrix
{
    public static void Initialize()
    {
        int[,] matrixA = new int[5, 7];

        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                matrixA[i, j] = random.Next(1, 100);
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write("{0,4}", matrixA[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nСтроки с чередованием четных и нечетных элементов:");
        for (int i = 0; i < 5; i++)
        {
            bool isAlternating = true;

            for (int j = 0; j < 7; j++)
            {
                if (matrixA[i, j] % 2 == 0)
                {
                    if (j % 2 == 1)
                    {
                        isAlternating = false;
                        break;
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        isAlternating = false;
                        break;
                    }
                }
            }

            if (isAlternating)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("{0,4}", matrixA[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
