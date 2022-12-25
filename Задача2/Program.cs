// Задача 2: Задайте прямоугольный двумерный массив. 
//           Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
//           выдаёт номер строки с наименьшей суммой элементов: 1 строка

// 1. Создать метод заполняющий двумерный массив.
// 2. Создать метод, выводящий на экран двумерный массив.
// 3. Создать метод, находящий строку с наименьшей суммой элементов в двумерном массиве.
// 4. Задать двумерный массив 4х4.
// 5. Применить метод в пункте 1 и 2 для заполнения и вывода массива на экран, затем
//              вывести сообщение " {результат работы метода в п. 3}-ая строка c наименьшей суммой".

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
int GetMinSumRow(int[,] matr)
{
    int result = 1;
    int sumMin = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        if (sumMin == 0)
        {
            sumMin = sum;
        }
        if (sumMin > sum)
        {
            sumMin = sum;
            result = i + 1;
        }
    }
    return result;
}

// 4.
int[,] array = new int[4, 4];

// 5.
FillArray2(array);
PrintArray2(array);
Console.WriteLine($"{GetMinSumRow(array)}-ая строка с наименьшей суммой");

