

int SumNumbers(int num)
{
  int sum = 0;
  for (int i = 1; i <= num; i++)

    sum += i; //sum=sum+i
  return sum;
}

System.Console.WriteLine("Введите цлеое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {SumNumbers(num)}");
