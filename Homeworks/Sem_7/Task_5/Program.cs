Console.Clear();

Console.WriteLine("Миша и негатив");

void InputPhoto(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        string pixels = Console.ReadLine();
        for (int j = 0; j < pixels.Length; j++)
            matrix[i, j] = pixels[j];
    }
}

void Compare(int[,] photo, int[,] negativ)
{
    int count = 0;
    for (int i = 0; i < photo.GetLength(0); i++)
    {
        for (int j = 0; j < photo.GetLength(1); j++)
        {
            if (photo[i, j] == negativ[i, j])
                count++;
        }
    }
    Console.WriteLine($"Количество ошибок: {count}");
}

Console.Write("Введите размер фото: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] photo = new int[size[0], size[1]];
int[,] negativ = new int[size[0], size[1]];
InputPhoto(photo);
InputPhoto(negativ);
Compare(photo, negativ);