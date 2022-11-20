Console.WriteLine("Vvedite celoe chislo");
int num = Convert.ToInt32(Console.ReadLine());
int square = num*num;
//Console.WriteLine("Квадрат введенного числа равен "+square);
Console.WriteLine($"Kvadrat vedennogo chisla {square}");

if (num>9 && num<100)   // проверка на двузначное число
{
    Console.WriteLine("vi vveli dvuhznachnoe chislo");
}

while (num<=25)  // вывод всех чисел от введенного до 25
{
    Console.Write($"{num} ");
    num++;
}
Console.WriteLine();
