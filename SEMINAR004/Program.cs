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
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int X = Acount(num);
Console.WriteLine($"Количестов цифр в числе равно {X}");

int Acount(int num)
{
int count = 0;

while (num != 0)
{
num = num / 10;
count = count + 1;
}
return count;
}







