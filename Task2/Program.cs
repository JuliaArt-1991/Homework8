// 56 строка с наименьшей суммой элементов
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int MinSumRow(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i} строки = {sum}");
        if (i == 0)
            minsum = sum;
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    return index;
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
while (size[0] == size[1])
{
    Console.Write("Вы ошиблись!\nВведите размер прямоугольного двумерного массива: ");
    size = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine($"Результат: {MinSumRow(matrix)}");