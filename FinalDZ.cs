Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
string[,] arr = new string[n, m];
List<string> arr2 = new List<string>();
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
RebuildArray(arr, arr2);


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

void RebuildArray(string[,] array, List<string> array2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int length = array[i, j].Length;
            if (length <= 3) array2.Add(new String(array[i, j]));
            
        }
    }
    string[] arrayS = array2.ToArray();
    foreach (string i in arrayS)
    {
        Console.Write($"{i} ");
    }
}