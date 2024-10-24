class Lab
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Введите размеры массива");
       int g = int.Parse(Console.ReadLine());
       int h = int.Parse(Console.ReadLine());
       int[,] arr = new int[g, h];
       Console.WriteLine("Введите элементы массива");
       for (int i = 0; i < g; i++)
       {
           for (int j = 0; j < g; j++)
           {
               arr[i, j] = int.Parse(Console.ReadLine());
           }
       }


       for (int n = 0; n < arr.GetLength(1); n++)
       {
           for (int j = 1; j < arr.GetLength(1); j++)
           {
               int sumPrevColum = 0;
               for (int i = 0; i < arr.GetLength(0); i++)
               {
                   sumPrevColum += arr[i, j - 1];
               }

               int sumCurrentColum = 0;
               for (int i = 0; i < arr.GetLength(0); i++)
               {
                   sumCurrentColum += arr[i, j];
               }

               if (sumPrevColum > sumCurrentColum)
               {
                   for (int c = 0; c < arr.GetLength(0); c++)
                   {
                       int temp = arr[c, j];
                       arr[c, j] = arr[c, j - 1];
                       arr[c, j - 1] = temp;

                   }
               }
           }
       }

       for (int i = 0; i < arr.GetLength(0); i++)
       {
           for (int j = 0; j < arr.GetLength(1); j++)
           {
               Console.Write("{0}\t", arr[i, j]);
           }
           Console.WriteLine();
       }


       Console.ReadLine();

    }
    
}