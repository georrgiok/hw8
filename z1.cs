/*Задача 1: Задайте двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
int min = 0;
double minSum = double.PositiveInfinity;
 int [,] arr = new int [5,5];
 for (int x = 0; x < 5; x++ )
 {
    int sum = 0;
    Console.Write(x + ": ");
    for (int y = 0; y < 5; y++ )
    {
        
        arr[x,y]=new Random().Next(1,100);
        Console.Write(arr[x,y]+"        ");    
        sum += arr[x,y];
    }
    Console.WriteLine();

    if (minSum > sum) {
        min = x;
        minSum = sum;
    }
    
 }

Console.WriteLine("Строка с минимальной суммой элементов  "+min);
