
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// int [,] Creat2dmn(int rows, int cols, int min, int max){
//     int [,] array = new int [rows,cols];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < cols; j++){
//             array[i,j] = new Random().Next(min, max+1);
//         }    
//     }
//     return array;
// }


// void Show2dArray(int [,] array) {
//       for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }    
//         System.Console.WriteLine();
//     }
// }


// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int [,] NewArray(int [,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0){
//                 array[i,j] *= array[i,j];
//             }   
//         }
//     }
//     return array;
// }

// System.Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите мин значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите макс значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array =  Creat2dmn(rows, cols, min, max);
// Show2dArray(array);
//  System.Console.WriteLine();
// int [,] newArray = NewArray(array);
// Show2dArray(newArray);

// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


// int NewArray(int [,] array){
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j){
//                 count += array[i,j];
//             }   
//         }
//     }
//     return count;
// }
// System.Console.Write("Матрица приветсвтует Вас!");
// System.Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите мин значение: ");
//     while (rows != cols || rows < 1 || cols < 1){
//         Console.ForegroundColor = ConsoleColor.Red;
//         System.Console.WriteLine("Error!");
//         Console.ForegroundColor = ConsoleColor.White;
//         System.Console.Write("Введите количество строк: ");
//         rows = Convert.ToInt32(Console.ReadLine());
//         System.Console.Write("Введите количество столбцов: ");
//         cols = Convert.ToInt32(Console.ReadLine());
//         System.Console.Write("Введите мин значение: "); 
//     }
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите макс значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array =  Creat2dmn(rows, cols, min, max);
// Show2dArray(array);
// int count = NewArray(array);
// System.Console.Write($"Cумму элементов, находящихся на главной диагонали: {count}");

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12








// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double [,] Creat2dArray(int rows, int cols, int min, int max){
//     double [,] array = new double [rows,cols];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < cols; j++){
//             array[i,j] = Convert.ToDouble(new Random().Next(min*100, max*100)/100.0);
//         }    
//     }
//     return array;
// }


// void Show2dArray(double [,] array) {
//       for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }    
//         System.Console.WriteLine();
//     }
// }

// System.Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите мин значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите макс значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double [,] newArray = Creat2dArray(rows, cols, min, max);
// Show2dArray(newArray);


// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] Creat2dArray(int rows, int cols, int min, int max){
    int [,] array = new int [rows,cols];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < cols; j++){
            array[i,j] = Convert.ToInt32(new Random().Next(min, max));
        }    
    }
    return array;
}

void Show2dArray(int [,] array) {
      for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]}  ");  
        }    
        System.Console.WriteLine();
    }
}

void ShowIndex(int x, int y, int [,] array){
    Console.Write($"На позиции: {x},{y} находится число: {array[x,y]} ");
}

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите мин значение: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите макс значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Creat2dArray(rows, cols, min, max);
Show2dArray(newArray);

System.Console.Write("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine()) - 1;
System.Console.Write("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine()) - 1;
    while (x > newArray.GetLength(0)+1 || y > newArray.GetLength(1)+1){
        Console.Write($"Максимальная кол-во столбцов: {newArray.GetLength(0)}, колонн: {newArray.GetLength(1)}");    
        Console.WriteLine($"Повторите ввод");  
        System.Console.Write("Введите номер строки: ");
        x = Convert.ToInt32(Console.ReadLine()) - 1;
        System.Console.Write("Введите номер столбца: ");
        y = Convert.ToInt32(Console.ReadLine()) - 1;
    }
ShowIndex(x, y, newArray);

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.