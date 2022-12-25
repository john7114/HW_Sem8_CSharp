// Задача 3: Задайте две квадратные матрицы одинакового размера. 
//           Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица:
// 18 20
// 15 18

// 1. Создать метод, заполняющий массив.
// 2. Создать метод, выводящий массив на экран.
// 3. Создать метод, находящий произведение двух матриц.
// 4. Создать два двумерных массива размером 2х2.
// 5. Применить методы в пунктах 1 и 2 к двум двумерным массивам. 
//           Массивы на вывода на экран отделить пустой строкой.
// 6. Применить метод в пункте 2, аргументом которому будет результат работы 
//              метода в пункте 3(аргументами которого будут две двумерные массивы).

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

int[,] GetMatrixC(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            int sum = 0;
            if (j == 0)
            {
                for (int k = 0; k < matr1.GetLength(0); k++)
                {
                    sum += matr1[i, k] * matr2[k, j];
                }
                matr3[i, j] = sum;
            }
            else
            {
                for (int l = 0; l < matr1.GetLength(0); l++)
                {
                    sum += matr1[i, l] * matr2[l, j];
                }
                matr3[i, j] = sum;
            }
        }
    }
    return matr3;
}

// 4.
int[,] matrA = new int[2, 2];
int[,] matrB = new int[2, 2];

// 5.
FillArray2(matrA);
FillArray2(matrB);
PrintArray2(matrA);
Console.WriteLine();
PrintArray2(matrB);
Console.WriteLine();

// 6.
PrintArray2(GetMatrixC(matrA, matrB));
