// перевернутый массив
// void PrintArray(int[] arr)
// {
//   System.Console.WriteLine("Вывод массива");
//   foreach (int el in arr)
//   {
//     System.Console.WriteLine(el + " ");
//   }
//   System.Console.WriteLine();
// }

// void FillArray(int[] array)
// {
//   int length = array.Length;
//   for (int i = 0; i < length; i++)
//   {
//     array[i] = new Random().Next(-20,21);
//   }
// }

// void Reverse(int[] array)
// {
//   int size = array.Length;
//   int temp;
//   for (int i = 0; i < size/2; i++)
//   {
//     temp = array[i];
//     array[i] = array[size - 1 - i];
//     array[size - 1 - i] = temp;
//   }
// }

// int[] array = new int[5];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine("Перевернутый массив");
// Reverse(array);
// PrintArray(array);







// Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.




// void CheckNums(int num1, int num2, int num3)
// {
// if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
// {
// Console.WriteLine("Треугольник с такими сторонами существует");
// }
// else Console.WriteLine("Такого треугольника не существует");
// }

// try
// {
// Console.WriteLine("Введите значение 1 стороны треугольника: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение 2 стороны треугольника: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение 3 стороны треугольника: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// CheckNums(num1, num2, num3);
// }

// catch
// {
// Console.WriteLine("Ошибка ввода! Введите числовые значения");
// }









// Задача 42: Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string res = "";

//  while (num>0) {
//   res = Convert.ToString(num%2) + res;
//   num = num / 2;
//  }

//  System.Console.WriteLine(res);
















// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

System.Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 1;

int count = 0;
 System.Console.WriteLine($"0, ");
for (int i = 2; i <= N; i++)
{
  count = num1 + num2;
  num2 = num1;
  num1 = count;
  System.Console.WriteLine($"{count}, ");
}
