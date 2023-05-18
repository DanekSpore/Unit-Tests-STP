using System;
using System.Collections.Generic;
using System.Text;

namespace STPSECOND
{

        public class NewMainClass
        {


            private Hotel H = new Hotel();
            private Room R = new Room();

            public void Init(int S, float P, int S1, int S2, float P1, float P2, int SD, float L, float L1, float L2)
            {
                R.Init(S, P, L);
                H.Init(S1, S2, P1, P2, SD, L1, L2);
            }
            public void Display()
            {
                Console.WriteLine("Класс \"Гостиница\": ");
                H.Display();
                Console.WriteLine("Класс \"Номер\": ");
                R.Display();
            }
        }
}
