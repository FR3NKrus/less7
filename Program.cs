
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

int [,] Creat2dmn(int rows, int cols, int min, int max){
    int [,] array = new int [rows,cols];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < cols; j++){
            array[i,j] = new Random().Next(min, max+1);
        }    
    }
    return array;
}


void Show2dArray(int [,] array) {
      for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }    
        System.Console.WriteLine();
    }
}


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


int NewArray(int [,] array){
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j){
                count += array[i,j];
            }   
        }
    }
    return count;
}

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите мин значение: ");
    // while (rows != cols){
    //     System.Console.WriteLine("Error! Введите квадратную марицу!");
    //     System.Console.Write("Введите количество строк: ");
    //     rows = Convert.ToInt32(Console.ReadLine());
    //     System.Console.Write("Введите количество столбцов: ");
    //     cols = Convert.ToInt32(Console.ReadLine());
    //     System.Console.Write("Введите мин значение: "); 
    // }
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите макс значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int [,] array =  Creat2dmn(rows, cols, min, max);
Show2dArray(array);
int count = NewArray(array);
System.Console.Write($"Cумму элементов, находящихся на главной диагонали: {count}");



// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12