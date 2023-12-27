// 1 var
public class MatrixLibrary
{
    public static int SumOfMaxIndexes(int[,] matrix)
    {
        int maxE = int.MinValue;
        int sumOfIndexes = 0;
        int maxRI = 0;
        int maxCI = 0;

        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (matrix[i, j] > maxE)
                {
                    maxE = matrix[i, j];
                    maxRI = i;
                    maxCI = j;
                }
            }
        }

        sumOfIndexes = maxRI + maxCI;
        return sumOfIndexes;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите кол-во строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите кол-во столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Введите элемент [{0},{1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int sumOfIndexes = MatrixLibrary.SumOfMaxIndexes(matrix);
        Console.WriteLine("Сумма индексов макс-ых элементов матрицы: {0}", sumOfIndexes);
    }
}