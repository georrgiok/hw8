/* Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу,
 которая будет находить произведение двух матриц. 
Например, даны 2 матрицы:
 2 4 | 3 4
 3 2 | 3 3
  Результирующая матрица будет: 18 20 15 18*/

int [,] Make2dArr(int x, int y, int maxRnd )
{
    int [,] arr = new int [x,y];

    int n = 0;
    while( n < x){
    Console.Write(n + ": ");
         for ( int m = 0; m < y; m++ )
         {
            arr[n,m] = new Random().Next(1,maxRnd);
            Console.Write(arr[n,m]+"  ");
         }
         Console.WriteLine("|");

        n++;
    }
    Console.WriteLine();
    return arr;
}

int [,] MultiplyCubeMatrix(int[,] first, int[,] secomd)
{
    int x = first.GetLength(0), y = first.GetLength(1);
    int[,] res = new int[x,y];

  for (int i = 0; i < x; i++)
  {
    for (int j = 0; j < y; j++)
    {
      int sum = 0;
      for (int k = 0; k < y; k++)
      {
        sum += first[i,k] * secomd[k,j];
      }
      res[i,j] = sum;
    }
  }
  return res;
}

void Print2dArr(int[,] arr) {
    int x = arr.GetLength(0), y = arr.GetLength(1);
    string text = "Печать массива размером "+x+" на "+y;
    Console.WriteLine(text);
    for (int i = 0; i < x; i++)
    {
        Console.Write(i + " | ");
        for (int j = 0; j < y; j++)
        {
            Console.Write(arr[i,j] + "  ");
        }
        Console.WriteLine("|");
    }
}

int x = 2, rnd = 10;
int [,] arr1 = Make2dArr(x,x,rnd);
int [,] arr2 = Make2dArr(x,x,rnd);

Print2dArr(MultiplyCubeMatrix(arr1, arr2));
