// ONE

// int SumNumbers(int num)
// {
//   int sum = 0;
//   for (int i = 1; i <= num; i++)

//     sum += i; //sum=sum+i
//   return sum;
// }

// System.Console.WriteLine("Введите цлеое число: ");
// int num = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {SumNumbers(num)}");



// TWO
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
//89126 -> 5
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int X = Acount(num);
// Console.WriteLine($"Количестов цифр в числе равно {X}");

// int Acount(int num)
// {
// int count = 0;

// while (num != 0)
// {
// num = num / 10;
// count = count + 1;
// }
// return count;
// }







// three
//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int X = Factorial(num);
Console.WriteLine($"Произведение чисел от 1 до N равно = {X}");

int Factorial(int num)
{
  int fact = 1;
  for (int i = 1; i <= num; i++)
  {
    fact = fact*i;
  }
  return fact;
}




//four
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]




// int[] rendr(int len)
// {
// int[] array = new int[len];
// Random rnd = new Random();
// for (int i = 0; i < len; i++)
// {
// array[i] = rnd.Next(0, 2);
// }
// return array;
// }
// int len = 8;
// int[] array = rendr(len);

// // Array.ForEach(array, Console.WriteLine);
// for (int i = 0; i < len; i++)
// {
// Console.Write($"{array[i]} ");
// }


