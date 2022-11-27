// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


void checkKoord(int x, int y)
{
  if (x > 0 && y > 0) System.Console.WriteLine("Eto chetvert' #1");
  else if (x > 0 && y < 0) System.Console.WriteLine("Eto chetvert' #2");
  else if (x < 0 && y > 0) System.Console.WriteLine("Eto chetvert' #3");
  else if (x < 0 && y < 0) System.Console.WriteLine("Eto chetvert' #4");
  else System.Console.WriteLine("Tochka nahoditsya na koordinatnoi osi");
}

try
{
  System.Console.WriteLine("Vvedite koordinaty X");
  int x = Convert.ToInt32(Console.ReadLine());
  System.Console.WriteLine("Vvedite koordinaty Y");
  int y = Convert.ToInt32(Console.ReadLine());
  checkKoord(x, y);
}
catch
{
  System.Console.WriteLine("Nado bilo vvodit' celie chisla!");
}

