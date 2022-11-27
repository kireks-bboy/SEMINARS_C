// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void CheckKoord(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("eto chetvert' # 1");
    else if (x > 0 && y < 0) Console.WriteLine("eto chetvert' # 4");
    else if (x < 0 && y > 0) Console.WriteLine("eto chetvert' # 2");
    else if (x < 0 && y < 0) Console.WriteLine("eto chetvert' # 3");
    else Console.WriteLine("tochka nahodistsa na koordinatnoy osi");
}

string CheckKoord2(int x, int y)
{
    string res;
    if (x > 0 && y > 0) res = "eto chetvert' # 1";
    else if (x > 0 && y < 0) res = "eto chetvert' # 2";
    else if (x < 0 && y > 0) res = "eto chetvert' # 3";
    else if (x < 0 && y < 0) res = "eto chetvert' # 4";
    else res = "tochka nahodistsa na koordinatnoy osi";
    return res;
}

try
{
    Console.WriteLine("Vvedite koordinaty X");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Vvedite koordinaty Y");
    int y = Convert.ToInt32(Console.ReadLine());
    CheckKoord(x, y);
    Console.WriteLine(CheckKoord2(x,y));
}
catch
{
    Console.WriteLine("Nyzno bilo vvodit' celie chisla");
}

