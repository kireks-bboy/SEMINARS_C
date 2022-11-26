// int num = new Random().Next(10,100);
// Console.WriteLine($"Sgenerirovannoe sluch chislo {num}");
// int x1 = num/10;
// int x2 = num % 10;
// if (x1>x2) Console.WriteLine($"Naivolshaya cifra etogo chisla eto {x1}");
// else if (x1<x2) Console.WriteLine($"Naibolshaya cifra etogo chisla eto {x2}");
// else Console.WriteLine("cifri odinakovie");

// for (int i = 0; i<=num; i=i+2) Console.Write($"{i} ");


// int Number = new Random().Next(100, 1000);
// int NewNumber = 0;

// int NumberWithoutSecDig()
// {
//     NewNumber = Number / 100 * 10 + Number % 10;
//     return NewNumber;
// }

// NumberWithoutSecDig();

// Console.WriteLine();
// Console.WriteLine($"Esli iz chisla {Number} udalit' vtoryi cifry, polychitsa chislo {NewNumber}");
// Console.WriteLine();



// 2 zadacha

// int Number1 = new Random().Next(11, 101);
// int Number2 = new Random().Next(1, 11);
// int result = 0;

// int MultipleNumber()
// {
//     result = Number1 % Number2;
//     return result;
// }

// MultipleNumber();

// System.Console.WriteLine();
// if (result == 0) System.Console.WriteLine($"Число {Number1} кратно числу {Number2}");
// else
// {
//     Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток от деления равен {Number1 % Number2}");
// }
// System.Console.WriteLine();



// // first zadacha
// int num = new Random().Next(100, 1000);
// Console.WriteLine($"Сгенерировано случайное число {num}");
// int x1 = num % 10;
// num = num / 100;
// num = num * 10;
// num = num + x1;
// Console.WriteLine(num);
// Console.WriteLine("${num}");

// // alternativa
// int num = new Random().Next(100,1000);
// Console.WriteLine($"Сгенерировано случайное число {num}");
// int x1 = num / 100;
// int x3 = num % 10;
// Console.WriteLine($"Число {x1}{x3}");



// // second zadacha
// Console.WriteLine("Введите два числа");
// Console.WriteLine("введите число 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int div = num2 % num1;
// if (div !=0)
// {
//     Console.WriteLine($"Число 2 не кратно числу 1. Остаток равен = {div}");
// }
// else
// Console.WriteLine("Число 2  кратно числу 1.");

// // alternativa
// Console.WriteLine("введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = num1 % num2;
// if (num1 % num2 ==0)
// Console.WriteLine("кратное число ");
// else Console.WriteLine($"некратное число, остаток{num3}");







// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

//     {

//         if(num%7==0 && num%23==0)
//         {
//             System.Console.WriteLine("Кратно одновременно 7 и 23");
//         }
//         else{
//             Console.WriteLine("Не кратно одновременно 7 и 23"); 
//         }
//     }



// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// Console.WriteLine("введите число 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int quadro1 = Quadro(num1);
// int quadro2 = Quadro(num2);

// if (quadro1 == num2 || quadro2 == num1)
// {
// Console.Write("Да");
// }
// else 
// {
//   Console.Write("Нет");  
// }

// int Quadro (int a)
// {
//     return a * a;
// }






// пользователь задает с клавиатуры 6 целых чисел. Надо проверить присутствуют ли там квадраты чисел друг друга. То есть каждое число надо попарно проверять с остальными.


int size = 6;
int[] numbs = new int[size];
for (int i=0; i<size; i++)
{
    Console.WriteLine($"Vvedite {1+i} chislo:");
    numbs[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i=0; i<size; i++)
{
    for (int j=0; j<size; j++)
    {
        if(numbs[i]==numbs[j]*numbs[j]) Console.WriteLine($"Chislo {i+1} yavlyaetsa chisla kvadrata {j+1}");
    }

}











