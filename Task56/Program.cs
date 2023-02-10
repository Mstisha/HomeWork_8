int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число!");
        }
    }

    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int sumOfElements;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumOfElements = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfElements += matrix[i, j];
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.Write($"=> {sumOfElements}");
        Console.WriteLine();
    }
}

int GetMinSumRowElementsNumber(int[,] matrix)
{
    int sumOfElements = 0;
    int minSumOfElements = 0;
    int minSumElementsRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumOfElements = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfElements += matrix[i, j];
        }
        if (i == 0)
        {
            minSumOfElements = sumOfElements;
            minSumElementsRow = i;
        }
        else if (sumOfElements < minSumOfElements)
        {
            minSumElementsRow = i;
            minSumOfElements = sumOfElements;
        }
    }
    return minSumElementsRow;
}

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {GetMinSumRowElementsNumber(matrix) + 1}");