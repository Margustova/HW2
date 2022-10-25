/*Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
1. запрашиваем номер четверти int 1    

void ShowQuart(int quartNum) //void запрашивает, но ничего не выдает
{
    if(quartNum >= 1 && quartNum <=4)
    {
        if (quartNum == 1) Console.WriteLine("x < 0 and y > 0");
        else if (quartNum == 2) Console.WriteLine("x < 0 and y > 0");
        else if (quartNum == 3) Console.WriteLine("x < 0 and y < 0"); 
        else 
            Console.WriteLine("x > 0 and y < 0"); //Для метода Void не используется команда Return 
    }
    else
        Console.WriteLine("Wrong number!");
}
Console.Write("Input a number of qart: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowQuart(num); //  Если метод Void , то возвращать его никуда не нужно, он только запрашивает данные у пользователя.*/

/*Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
void QuartNum(double x, double y)
{
    if (x > 0 && y > 0) Console.WriteLine("Quart is 1");
    else if (x < 0 && y > 0) Console.WriteLine("Quart is 2");
    else if (x < 0 && y < 0) Console.WriteLine("Quart is 3");
    else 
        Console.WriteLine("Quart is 4");

}
Console.Write("Input x : ");
double x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y : ");
double y = Convert.ToInt32(Console.ReadLine());
QuartNum(x, y); */

/* решение без Void : 

int QuartNum(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    else 
        return 0;
}
Console.Write("Input x : ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y : ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(QuartNum(x, y)); */

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*double Distance(double x1, double y1, double x2, double y2)
{
    double AC = x2 - x1;
    double BC = y2 - y1;
    double result = Math.Sqrt((Math.Pow(AC, 2) + Math.Pow(BC, 2)));
    return result;
}
Console.Write("Input coordinats x1 : ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinats y1 : ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinats x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinats y2 : ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Distance(x1, y1, x2, y2));*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. */
void Quadrat(int N)
{
    int index =1; // переменная, на которую мы будем увеличивать шаг
    while (index <= N)
        {
            double result = Math.Pow(index,2); //индекс и степень в которую мы его возводим
            index++;
            Console.Write($"{result} ");
        }
}
Console.Write("Input N : ");
int N = Convert.ToInt32(Console.ReadLine());
Quadrat(N); 