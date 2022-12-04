
// // Задача 31: Задайте массив из N элементов, заполненный случайными числами из промежутка [-9, 9]. 
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(-9, 10);
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)
//         Console.Write($"{el} ");
//     Console.WriteLine();
// }

// void FindSums(int[] array)
// {
//     int sum_p = 0;
//     int sum_n = 0;
//     //цикл проходящийся по всем значениям array, то есть el принимает по очереди все значеиня массива
//     //применяется только для просмотра
//     foreach (int el in array)
//     {
//         if (el > 0) sum_p += el;
//         else sum_n += el;
//     }

//     Console.WriteLine($"Сумма положительных чисел равна {sum_p}");
//     Console.WriteLine($"Сумма отрицательных чисел равна {sum_n}");
// }

// int[] FindSums2(int[] array)
// {
//     int[] results = new int[2];
//     //цикл проходящийся по всем значениям array, то есть el принимает по очереди все значеиня массива
//     //применяется только для просмотра
//     foreach (int el in array)
//     {
//         if (el > 0) results[0] += el;
//         else results[1] += el;
//     }
//     return results;
// }

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// PrintArray(array);
// FindSums(array);
// int[] results = FindSums2(array);
// Console.WriteLine($"Сумма положительных чисел равна {results[0]}");
// Console.WriteLine($"Сумма отрицательных чисел равна {results[1]}");




//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(-9, 10);
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)
//         Console.Write($"{el} ");
//     Console.WriteLine();
// }

// void Zamena(int[] array)
// {
    
//     for (int i = 0; i < array.Length; i++ )
//     {
//         array[i] *= -1; 
                
//     }
    
// }   

// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// PrintArray(array);
// Console.WriteLine("Вот измененный массив");
// //Zamena(array);
// //Console.WriteLine($"{Zamena(array)}");
// Zamena(array);
// PrintArray(array);




/// Задача 33: Задайте массив. Напишите программу, которая определяет,  
// присутствует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет 
// -3; массив [6, 7, 19, 345, 3] -> да 
 
// int[] CreateArray(int size) 
// { 
//     int[] array = new int[size]; 
//     for (int i = 0; i < size; i++) 
//         array[i] = new Random().Next(-9, 10); 
//     return array; 
// } 
 
// void PrintArray(int[] array) 
// { 
//     foreach (int el in array) 
//         Console.Write($"{el} "); 
//     Console.WriteLine(); 
// } 
 
 
// bool FindNum(int[] array, int num) 
// { 
//     bool res = false; 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         if (array[i] == num) 
//         { 
//             res = true; 
//             break; 
//         } 
//     } 
//     return res; 
// } 
 
// Console.WriteLine("Введите размерность массива"); 
// int size = Convert.ToInt32(Console.ReadLine()); 
 
// Console.WriteLine("Введите искомое число: "); 
// int num = Convert.ToInt32(Console.ReadLine()); 
 
// int[] array = CreateArray(size); 
// PrintArray(array); 
// if (FindNum(array, num)) Console.WriteLine("ДА, Число присутствует в массиве!"); 
// else Console.WriteLine("НЕТ! Искомого числа");







/// Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] FillPrintArray()
{
    {
        int[] array = new int[15];
        for (int i = 0; i < 15; i++)
        {
            array[i] = new Random().Next(-100, 101);
            Console.Write(array[i] + " ");
        }
        return array;
    }
}

int Elements(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el >= 10 && el <=99) count++;
    }
    return count;
}

int[] array = FillPrintArray();
Console.WriteLine();
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {Elements(array)}");
