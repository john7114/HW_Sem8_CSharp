// Задача 1: Задайте двумерный массив. 
//           Напишите программу, 
//           которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// 1. Создать метод, заполняющий двумерный массив.
// 2. Создать метод, выводящий двумерный массив на экран.
// 3. Создать метод, упорядочивающий двумерный массив по убыванию значения элементов
// 4. Задать двумернй массив размером 4x5.
// 5. Применить метод в пункте 1 и 2 для заполнения и вывода массива на экран, а затем
//              снова метод в пункте 2, аргументом которому будет метод в пункте 3.
// В итоге на экране должен появиться старый  массив и, через пустую строку, новый массив.

// 1.
void FillArray2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

// 2.
void PrintArray2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// 3.
int[,] OrderedArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = j; k < arr.GetLength(1); k++)
            {
                int temp = 0; 
                if(arr[i, j] < arr[i, k]) 
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
    return arr;
}

// 4.
int[,] array = new int [4, 5];

// 5.
FillArray2(array);
PrintArray2(array);
Console.WriteLine();
PrintArray2(OrderedArray(array));