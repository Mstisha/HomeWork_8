int GetCorrectNumber(string message)
{
    int correctNumber = 0;
    while (true)
    {
        Console.Write($"{message}: ");
        if (int.TryParse(Console.ReadLine(), out correctNumber) && correctNumber > 0)
        {
            return correctNumber;
        }
        else
        {
            Console.WriteLine("Введенные данные не корректны!");
        }
    }
}

int[,,] InitMatrix(int dimentionX, int dimentionY, int dimentionZ)
{
    int[,,] matrix = new int[dimentionZ, dimentionX, dimentionY];
    Random random = new Random();
    for (int z = 0; z < dimentionZ; z++)
    {
        for (int x = 0; x < dimentionX; x++)
        {
            for (int y = 0; y < dimentionY; y++)
            {
                matrix[z, x, y] = random.Next(10, 100);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int z = 0; z < matrix.GetLength(0); z++)
    {
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            for (int y = 0; y < matrix.GetLength(2); y++)
            {
                Console.Write($"{matrix[z, x, y]}({z},{x},{y}) ");
            }
            Console.WriteLine();
        }
    }
}

int y = GetCorrectNumber("Введите количество строк массива");
int x = GetCorrectNumber("Введите количество столбцов массива");
int z = GetCorrectNumber("Введите количество этажей массива");
int[,,] matrix = InitMatrix(x, y, z);
PrintMatrix(matrix);