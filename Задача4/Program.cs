// Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
//            Напишите программу, которая будет построчно выводить массив. 
//            Обратите внимание, что максимальный размер такого массива ограничен. 
//            Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.

// Например,
// 11 22 78
// 12 47 96
// 25 87 88

// 1. Создать метод, проверяющий число на наличие в двумерном массиве.
// 2. Создать метод, заполняющий массив неповторяющимися случайными двухзначными числами.
// 3. Создать метод, выводящий массив на экран построчно.
// 4. Задать двумерный массив размером 7х8.
// 5. Применить метод в пункте 3, аргументом которого будет результат метода в пункте 2.

// 1.
bool FindNumInMatr(int[,] matr, int num)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == num)
            {
                return true;
            }
        }
    }
    return false;
}

// 2.
int[,] FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int rnd = new Random().Next(10, 100);
            if (FindNumInMatr(matr, rnd) == false)
            {
                matr[i, j] = rnd;
            }
            else j--;
        }
    }
    return matr;
}

// 3.
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

// 4.
int[,] matrix = new int[7, 8];

// 5.
PrintArray2(FillMatrix(matrix));
