using System;
using Xunit;
using STPSECOND;

namespace XUnitTestSTPSEC
{
    public class UnitTest1
    {
        [Fact]
        public void Test01() // �������� ������ ��� �������� ���� ���������� ������
        {
            Hotel Everest = new Hotel();
            Everest.Init(12,9,5000,6000,30,0,1);
            /*(�������, �������, ����, ����, ������������ ������, ������� ����, ������� ����)*/
            /*
             6000 * 2 = 12�000 (�. �. ������ ����� ����)
             12000 + 5000 = 17 000 (������� ����� �� ����)
             17 000 * 30 = 510�000 (��������� ����� �� ���� �����)
             */
            Assert.Equal(510000, Everest.TotalExpectedHotelIncomeForTheSeason());
        }

        [Fact]
        public void Test02() // ������� ������ ���� ������ 0, �������� ����������, ���� ��� ������ 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(-10, 9, 5000, 6000, 30, 0, 1));
        }

        [Fact]
        public void Test03() // ������� ������ ���� ������ 0, �������� ����������, ���� ��� ����� 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(0, 9, 5000, 6000, 30, 0, 1));
        }

        [Fact]
        public void Test04() // ���� ������ ���� ������ ��� ����� 0, �������� ����������, ���� ������ 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, -1000, 6000, 30, 0, 1));
        }

        [Fact]
        public void Test05() // ���� ������ ���� ������ ��� ����� 0, ��������, ���� ����� 0
        {
            Hotel Everest = new Hotel();
            Everest.Init(12, 9, 0, 0, 30, 0, 1);
            Assert.Equal(0, Everest.TotalExpectedHotelIncomeForTheSeason());

        }

        [Fact]
        public void Test06() // ������������ ������ ������ ���� ������ 0, �������� ����������, ���� ������ 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, 5000, 6000, -99, 0, 1));
        }

        [Fact]
        public void Test07() // ������������ ������ ������ ���� ������ 0, �������� ����������, ���� ����� 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, 5000, 6000, 0, 0, 1));
        }

        [Fact]
        public void Test08() // �������� �� ���� ������ ���� ����� ���� 0, ���� 1, ��������, ���� �������� ������ 0
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, 5000, 6000, 0, 0, -9));
        }

        [Fact]
        public void Test09() // �������� �� ���� ������ ���� ����� ���� 0, ���� 1, ��������, ���� �������� ������ 1
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, 5000, 6000, 0, 0, 5));
        }

        [Fact]
        public void Test10() // �������� �� ���� ������ ���� ����� ���� 0, ���� 1, ��������, ���� �������� ����� 0 � 1
        {
            Hotel Everest = new Hotel();
            Assert.Throws<ArgumentOutOfRangeException>(() => Everest.Init(12, 9, 5000, 6000, 0, 0, (float)0.5));
        }
    }
}
