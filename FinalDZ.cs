Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
string[,] arr = new string[n, m];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
// RebuildArray(arr);
// PrintArray(arr);


void FillArray(string[,] array0)
{
    int number = 1;
    for (int i = 0; i < array0.GetLength(0); i++)
    {
        for (int j = 0; j < array0.GetLength(1); j++)
        {
            Console.Write($"Задачйте переменную {number}:  ");
            number++;
            array0[i, j] = Convert.ToString(Console.ReadLine() ?? "0");;
            Console.WriteLine();
        }
    }
}

void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// void RebuildArray(string[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             if (n == m)
//             {
//                 int tmp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = tmp;
//             }
//         }
//     }
//     if (n != m)
//     {
//         Console.WriteLine("Matrix imposible rebuilding");
//         Console.WriteLine();
//     }
// }