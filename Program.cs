namespace c__dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };          
            for(int i = arr.GetLength(0) - 1; i >= 0; i--)
            {
                for(int j = arr.GetLength(1) - 1;  j >= 0; j--)
                {
                    int maxI = i;
                    int maxJ = j;
                    for(int x = 0; x <= i; x++)
                    {                        
                        for(int y = 0;  y < arr.GetLength(1); y++)
                        {
                            if(x == i && y > j)
                                break;
                            if (arr[x,y] > arr[maxI, maxJ])
                            {
                                maxI = x;
                                maxJ = y;
                            }
                        }
                    }
                    if(maxI != i || maxJ != j)
                    {
                        int temp = arr[maxI,maxJ];
                        arr[maxI, maxJ] = arr[i, j];
                        arr[i,j] = temp;
                    }
                }
            }
            for(int i = 0;  i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}