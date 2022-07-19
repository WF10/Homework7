    // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
    // округлёнными до одного знака.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9

    void Homework7_47()
{
    int line = 3;
    int column = 3;
    double[,] array = new double [line,column];
    CreatArray(array);
    PrintArray(array);
}

  void CreatArray(double[,] currentArray)
   {
        Random rand = new Random();
        for (int i = 0; i < currentArray.GetLength(0); i++)
        {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
                currentArray[i,j] = rand.NextDouble() * 10 - 5;
            }
        }
   }

   void PrintArray(double[,] currentArray)
   {
        Console.WriteLine();
        Console.WriteLine("Вывод массива на экран:");
        for(int i = 0; i < currentArray.GetLength(0); i++)
        {
            for(int j = 0; j < currentArray.GetLength(1); j++)
            {
                Console.Write($"{currentArray[i, j]:N2} \t");
            }
            Console.WriteLine();
        }
   }
    
   
   // Homework7_47();

//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//[1, 3] -> 3

void Homework7_50()
{
    int line = 5;
    int column = 5;
    double[,] array = new double [line,column];
    CreatArray(array);
    PrintArray(array);

    Console.WriteLine("Введите номер строки элемента:");
    line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Введите номер столбца элемента:");
    column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (line < array.GetLength(0) && column < array.GetLength(1))
    {
        Console.WriteLine($"Элемент массива, который вы ищите: {array[line,column]:N2}");
    }
    else
    {
       Console.WriteLine("В массиве нет элемента по заданным вами параметрам");
    }
}

// Homework7_50();

//Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 5 3
//8 4 6 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.

void Homework7_52()
{
    int line = 5;
    int column = 5;
    int [,] array = new int [line,column];
    
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(1,10);
        }
    }

    Console.WriteLine();
    Console.WriteLine("Вывод массива на экран:");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }

    for(int j = 0; j < array.GetLength(0); j++)
    {   
        int sum = 0;
        for(int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[i,j];
        }
        sum /= array.GetLength(1);

        Console.WriteLine($"Среднее арифметическое для {j} столбца равно: {sum} ");
        Console.WriteLine();
        }
}

Homework7_52();
