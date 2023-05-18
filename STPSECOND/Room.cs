using System;
using System.Collections.Generic;
using System.Text;

namespace STPSECOND
{
    public class Room
    {

        private float Luxury;
        private int Square; // Площадь
        private float Price; // Стоимость проживания в сутки

        public void Init(int S, float P, float L) // инициализация площади и стоимости
        {
            Square = S;
            Price = P;
            Luxury = L;
            if (Square <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Square));
            }
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Price));
            }
            if ((Luxury != 0) && (Luxury != 1))
            {
                throw new ArgumentOutOfRangeException(nameof(Luxury));
            }
        }

        public void Read()
        {
            Console.WriteLine("Введите площадь: ");
            Square = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость проживания за сутки: ");
            Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите 0 или 1 (Люкс): ");
            Luxury = float.Parse(Console.ReadLine());
        }

        public void Display()
        { // Вывод значений площади и стоимости проживания за сутки

            Console.WriteLine("Площадь номера: " + Square + "; " + "Стоимость проживания: " + Price);
            if (Luxury == 1)
            {
                Console.WriteLine("Вид номера: Люкс");
            }
            else Console.WriteLine("Вид номера: обычный");
        }

        public float Attraction()
        { // Привлекательность номера для экономных туристов (отношение цены к площади)
            return Price / Square; // Цена за 1 м² - чем больше число, тем дороже
        }

        public float GetPrice()
        {
            if (Luxury == 1)
            {
                return Price * 2;
            }
            return Price;
        }
    }
}
