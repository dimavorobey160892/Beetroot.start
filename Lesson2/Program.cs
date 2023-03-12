// See https://aka.ms/new-console-template for more information
/Variables();
Operations();
MathOperations();
Dates();
void Variables()
{
    byte a = 4;
    Console.WriteLine("a="+a);
short b = -21;
    Console.WriteLine("b=" + b);
int c = 786;
    Console.WriteLine("c=" + c);
long d = 76;
    Console.WriteLine("d=" + d);
bool e = true;
    Console.WriteLine("e=" + e);
char f = '2';
    Console.WriteLine("f=" + f);
float g =24;
    Console.WriteLine("g=" + g);
double h = 15.5;
    Console.WriteLine("h=" + h);
decimal j = 543;
    Console.WriteLine("j=" + j);
string k = "beetroot";
    Console.WriteLine("k=" + k);
    Console.WriteLine("          ");
} 
    void Operations()
    {
        var sumAB = a + b;
        Console.WriteLine("a+b=" + sumAB);

        var aditCD = c - d;
        Console.WriteLine("c-d=" + aditCD);

        var subCJ = c * j;
        Console.WriteLine("c*j=" + subCJ);

        var divCA = c / a;
        Console.WriteLine("c/a=" + divCA);
        Console.WriteLine("          ");
    }
    void MathOperations()

{
    var x = 25;
    var y = 15;
    Console.WriteLine("x = " + x);
    Console.WriteLine("y = " + y);
    var result1 = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
    Console.WriteLine("-6*x^3+5*x^2-10*x+15=" + result1);
    var result2 = Math.Abs(x)*Math.Asin(x);
    Console.WriteLine("abs(x)*sin(x) =" + result2);
    var result3 = 2*Math.PI*x;
    Console.WriteLine("2*pi*x="+ result3);
    var result4 = Math.Max(x, y);
    Console.WriteLine("Max(x,y)=" + result4);
}
void Dates()
{
    DateTime dt1 = new DateTime(2023, 01, 01); //Дата початку поточного року
    DateTime dt2 = new DateTime(2024, 01, 01); //Дата початку наступного року
    int nowMonth = DateTime.Now.Month;
    int nowDay = DateTime.Now.Day;
    int preMonth = dt1.Month;
    int preDay = dt1.Day;
    int afterMonth = dt2.Month;
    int afterDay = dt2.Day;
    var dd1 = (DateTime.Now - dt1);
    var dd2 = (dt2 - DateTime.Now);
    Console.WriteLine($"Сьогодні {DateTime.Now:m}\nЧас {DateTime.Now:t}");
    Console.Write($"С {dt:m} {m} місяця ");
    Console.WriteLine(isPassed(m) ? "Минуло" : $"Не минуло, залишилося {dd.Days} дней");
    Console.WriteLine(isPassed(m) ? "Минуло" : $"Не минуло, залишилося {dd.Days} дней");

    bool isPassed(int month)
    {
        int r = nowMonth - preMonth;
        if (r > month)
        {
            return true;
        }
        else if (r < month)
        {
            return false;
        }
        else
        {
            if (nowDay > preDay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    bool isPassed2(int month)
    {
        int r =  afterMonth- nowMonth;
        if (r > month)
        {
            return true;
        }
        else if (r < month)
        {
            return false;
        }
        else
        {
            if (afterDay > nowDay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}// не вийшло(
