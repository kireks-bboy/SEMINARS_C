int num = new Random().Next(10,100);
Console.WriteLine($"Sgenerirovannoe sluch chislo {num}");
int x1 = num/10;
int x2 = num % 10;
if (x1>x2) Console.WriteLine($"Naivolshaya cifra etogo chisla eto {x1}");
else if (x1<x2) Console.WriteLine($"Naibolshaya cifra etogo chisla eto {x2}");
else Console.WriteLine("cifri odinakovie");

for (int i = 0; i<=num; i=i+2) Console.Write($"{i} ");