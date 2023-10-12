namespace ConsoleApp3
{
    internal class ArrayInvert
    {
        static void Main()
        {
            int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            Console.WriteLine("Исходный двумерный массив:");
            PrintArray(array);

            ConvertArrayToLinear(array);

            Console.WriteLine("Отсортированный двумерный массив:");
            PrintArray(array);
        }


        static void ConvertArrayToLinear(int[,] array)
        {
            // Convert array to 2D
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int[] flatArray = new int[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flatArray[index] = array[i, j];
                    index++;
                }
            }

            // Sort Array
            int n = flatArray.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (flatArray[j] > flatArray[j + 1])
                    {
                        int temp = flatArray[j];
                        flatArray[j] = flatArray[j + 1];
                        flatArray[j + 1] = temp;
                    }
                }
            }

            // Convert array to 3D
            index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = flatArray[index];
                    index++;
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
     