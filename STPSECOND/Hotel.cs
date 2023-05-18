using System;
using System.Collections.Generic;
using System.Text;

namespace STPSECOND
{
    public class Hotel
    {

        private Room R1 = new Room(), R2 = new Room(), R3 = new Room(); // 3 Номера
        private int Season;

        public void Init(int S1, int S2, float P1, float P2, int SD, float L1, float L2)
        {
            R1.Init(S1, P1, L1);
            R2.Init(S2, P2, L2);
            Season = SD;

            if (Season < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(Season));
            }
        }

        public void Read()
        {
            Console.WriteLine("Номер 1: ");
            R1.Read();
            Console.WriteLine("Номер 2: ");
            R2.Read();
            Console.WriteLine("Введите длительность сезона: ");
            Season = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Номер 1: ");
            R1.Display();
            Console.WriteLine("Номер 2: ");
            R2.Display();
            Console.WriteLine("Длительность сезона: " + Season);
        }

        public float TotalExpectedHotelIncomeForTheSeason()
        {
            // общий ожидаемый доход гостиницы за сезон
            // произведение стоимости в сутки на длительность сезона
       
            return (R1.GetPrice() + R2.GetPrice()) * Season;
        }

        public Room TheMostAttractive()
        {
            float Att1 = R1.Attraction(), Att2 = R2.Attraction();
            if (Att1 < Att2)
            {
                return R1;
            }
            return R2;

        }
    }
}
