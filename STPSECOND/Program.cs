using System;

namespace STPSECOND
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel a = new Hotel();
            NewMainClass c = new NewMainClass();
            Console.WriteLine("Гостиница: ");
            a.Init(6, 10, (float)4500, (float)5590, 31, (float)0.1, (float)1);
            a.Display();
            Console.WriteLine("Ожидаемый доход гостиницы за сезон: " + a.TotalExpectedHotelIncomeForTheSeason());
            Console.WriteLine();
            c.Init(18, 11000, 16, 20, 15500, 21490, 22, (float)0.1, 1, (float)0.1);
            c.Display();
        }
    }
}
