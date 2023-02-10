// 62 заполнение по спирали
void InputMatrix(int[,] matrix)
{
    int x = 0, y = 0, currentCount = 1;
    int size = matrix.GetLength(0);

    while (size > 0)
    {
        for (int i = y; i <= y + size - 1; i++)
        {
            matrix[x, i] = currentCount++;
        }

        for (int j = x + 1; j <= x + size - 1; j++)
        {
            matrix[j, y + size - 1] = currentCount++;
        }

        for (int i = y + size - 2; i >= y; i--)
        {
            matrix[x + size - 1, i] = currentCount++;
        }

        for (int i = x + size - 2; i >= x + 1; i--)
        {
            matrix[i, y] = currentCount++;
        }

        x = x + 1;
        y = y + 1;
        size = size - 2;
    }
}
void PrintMatrix(int[,] matrix)
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

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);