// 2.	Даны два массива A и B, содержащие соответственно m = 6 и n = 14 элементов. Требуется создать класс для объединения этих массивов	так, чтобы получился массив С, состоящий из m + n элементов, в котором элементы из массивов A и B чередуются, т.е. a1 b 1, a 2 b 2 и т.д. Когда элементы из A заканчиваются, то в С засылаются оставшиеся элементы из B.


namespace Task2;

public class Merger()
{
    public static void Initialize()
    {
        int[] A = { 1, 2, 3, 4, 5, 6 };
        int[] B = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };

        int[] C = MergeArrays(A, B);

        Console.WriteLine("Объединенный массив:");
        foreach (int element in C)
        {
            Console.Write(element + " ");
        }
    }

    private static int[] MergeArrays(int[] firstArray, int[] secondArray)
    {
        int[] mergedArray = new int[firstArray.Length + secondArray.Length];

        int firstArrayIndex = 0;
        int secondArrayIndex = 0;
        int mergedArrayIndex = 0;

        while (firstArrayIndex < firstArray.Length && secondArrayIndex < secondArray.Length)
        {
            mergedArray[mergedArrayIndex++] = firstArray[firstArrayIndex++];
            mergedArray[mergedArrayIndex++] = secondArray[secondArrayIndex++];
        }

        while (firstArrayIndex < firstArray.Length)
        {
            mergedArray[mergedArrayIndex++] = firstArray[firstArrayIndex++];
        }

        while (secondArrayIndex < secondArray.Length)
        {
            mergedArray[mergedArrayIndex++] = secondArray[secondArrayIndex++];
        }

        return mergedArray;
    }
}
