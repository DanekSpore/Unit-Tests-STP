using System;
using Xunit;
using STPSECOND;

namespace XUnitTestSTPSEC
{
    public class UnitTest1
    {
        [Fact]
        public void Test01() // Проверка работы при передачи всех корректных данных
        {
            Hotel Everest = new Hotel();
            Everest.Init(12,9,5000,6000,30,0,1);
            /*(Площадь, площадь, цена, цена, длительность сезона, отметка люкс, отметка люкс)*/
            /*
             6000 * 2 = 12 000 (т. к. второй номер Люкс)
             12000 + 5000 = 17 000 (прибыль отеля за день)
             17 000 * 30 = 510 000 (Заработок отеля за весь сезон)
             */
            Assert.Equal(510000, Everest.TotalExpectedHotelIncomeForTheSeason());
        }

        [Fact]
        public void Test02() // Площадь должна быть больше 0, проверка исключения, если она меньше 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(-10, 9, 5000, 6000, 30, 0, 1));
        }

        [Fact]
        public void Test03() // Площадь должна быть больше 0, проверка исключения, если она равна 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(0, 9, 5000, 6000, 30, 0, 1));
        }

        [Fact]
        public void Test04() // Цена должна быть больше или равна 0, проверка исключения, если меньше 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, -1000, 6000, 30, 0, 1));
        }

        [Fact]
        public void Test05() // Цена должна быть больше или равна 0, проверка, если равна 0
        {
            Hotel Everest = new Hotel();
            Everest.Init(12, 9, 0, 0, 30, 0, 1);
            Assert.Equal(0, Everest.TotalExpectedHotelIncomeForTheSeason());

        }

        [Fact]
        public void Test06() // Длительность сезона должна быть больше 0, проверка исключения, если меньше 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, 5000, 6000, -99, 0, 1));
        }

        [Fact]
        public void Test07() // Длительность сезона должна быть больше 0, проверка исключения, если равна 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, 5000, 6000, 0, 0, 1));
        }

        [Fact]
        public void Test08() // Указание на Люкс должно быть равно либо 0, либо 1, проверка, если значение меньше 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, 5000, 6000, 0, 0, -9));
        }

        [Fact]
        public void Test09() // Указание на Люкс должно быть равно либо 0, либо 1, проверка, если значение больше 1
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, 5000, 6000, 0, 0, 5));
        }

        [Fact]
        public void Test10() // Указание на Люкс должно быть равно либо 0, либо 1, проверка, если значение между 0 и 1
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, 5000, 6000, 0, 0, (float)0.5));
        }
    }
}
