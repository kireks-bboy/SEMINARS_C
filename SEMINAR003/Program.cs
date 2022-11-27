// // Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void CheckKoord(int x, int y)
// {
//     if (x > 0 && y > 0) Console.WriteLine("eto chetvert' # 1");
//     else if (x > 0 && y < 0) Console.WriteLine("eto chetvert' # 4");
//     else if (x < 0 && y > 0) Console.WriteLine("eto chetvert' # 2");
//     else if (x < 0 && y < 0) Console.WriteLine("eto chetvert' # 3");
//     else Console.WriteLine("tochka nahodistsa na koordinatnoy osi");
// }

// string CheckKoord2(int x, int y)
// {
//     string res;
//     if (x > 0 && y > 0) res = "eto chetvert' # 1";
//     else if (x > 0 && y < 0) res = "eto chetvert' # 2";
//     else if (x < 0 && y > 0) res = "eto chetvert' # 3";
//     else if (x < 0 && y < 0) res = "eto chetvert' # 4";
//     else res = "tochka nahodistsa na koordinatnoy osi";
//     return res;
// }

// try
// {
//     Console.WriteLine("Vvedite koordinaty X");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Vvedite koordinaty Y");
//     int y = Convert.ToInt32(Console.ReadLine());
//     CheckKoord(x, y);
//     Console.WriteLine(CheckKoord2(x,y));
// }
// catch
// {
//     Console.WriteLine("Nyzno bilo vvodit' celie chisla");
// }


// Zadacha2
// Console.Write("Введите кол-во чисел для вывода:");
//             int N = int.Parse(Console.ReadLine());
 
//             Console.WriteLine("Число" + "\t" + "Квадрат");
//             for(int i = 1; i <= N; i++)
//                 Console.WriteLine(i + "\t" + i*i);
 
//             Console.ReadLine();
  



// Zadacha1
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// l = √ (x 2 - x 1) 2+ (y 2 - y 1) 2

double Rast(double  x1, double  x2, double y1, double y2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    return distance;
}

try
{
    Console.Write("Введите координаты x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    
    Console.WriteLine(Rast(x1, x2, y1, y2));
}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
}
