/*Сформируйте двухмерный массив из неповторяющихся двузначных чисел
 (размер массива не более 50 элементов). Напишите программу, которая
  будет построчно выводить массив. Вариант создания функции: Проверить
   число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
    Пример: Массив размером
     3 x 3 10 11 55 33 41 23 17 28 34
*/

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
bool isArrContainsNumber(int[,] arr, int num) {
    int x = arr.GetLength(0), y = arr.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            if (arr[i,j] == num) {
                return true;
            }
        }
    }
    return false;
}

int x = 4, y = 5;
int minRnd = 4*5+10;
int [,] arr = new int [x,y];
int n = 0;
while( n < x){
    for (int m = 0; m < y; m++ )
    {
        int rnd = new Random().Next(1,minRnd);
        while (isArrContainsNumber(arr, rnd)) {
            rnd = new Random().Next(1,minRnd);
        }
        arr[n,m] = rnd;
    }
    n++;
}


Print2dArr(arr);
