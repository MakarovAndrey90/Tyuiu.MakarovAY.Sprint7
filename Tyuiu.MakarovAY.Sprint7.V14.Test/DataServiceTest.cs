using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakarovAY.Sprint7.V14.Lib;

namespace Tyuiu.MakarovAY.Sprint7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private readonly string testFilePath = @"C:\Users\Makar\source\repos\Tyuiu.MakarovAY.Sprint7\Data\Sprint7.Task7.V14.MAY.csv";

        [TestMethod]
        public void TestFileLoad()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            // Проверяем размер
            Assert.AreEqual(10, matrix.GetLength(0)); // 1 заголовок + 9 данных
            Assert.AreEqual(8, matrix.GetLength(1));  // 8 столбцов

            // Проверяем заголовки
            Assert.AreEqual("mode of the transport", matrix[0, 0]);
            Assert.AreEqual("passenger per day", matrix[0, 7]);
        }

        [TestMethod]
        public void TestBusCount()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            int result = ds.GetBusCount(matrix);

            // В файле: строки 2,3,5,8,10 - это автобусы
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMinibusCount()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            int result = ds.GetMinibusCount(matrix);

            // В файле: строки 4,6,7,9 - это маршрутки
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestChargerCount()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            int result = ds.GetRoutesWithChargerCount(matrix);

            // Все автобусы (5 шт) имеют "есть"
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMinTravelTime()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            int result = ds.GetMinTravelTime(matrix);

            // Минимальное время: 40 минут (маршрут 62)
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void TestMaxTravelTime()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            int result = ds.GetMaxTravelTime(matrix);

            // Максимальное время: 124 минуты (маршрутка 45)
            Assert.AreEqual(124, result);
        }

        [TestMethod]
        public void TestAverageTravelTime()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            double result = ds.GetAverageTravelTime(matrix);

            // Среднее: (73+85+124+40+56+89+44+82+94)/9 = 76.33
            double wait = 76.33;
            Assert.AreEqual(wait, result);

        }
        public void TestGetTotalDailyTravelTime()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            double result = ds.GetTotalDailyTravelTime(matrix);

            // Среднее: (73+85+124+40+56+89+44+82+94)/9 = 76.33
            double wait = 76.33;
            Assert.AreEqual(wait, result);

        }
        [TestMethod]
        public void TestTotalPassengersPerDay()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            int result = ds.GetTotalPassengersPerDay(matrix);

            // Сумма пассажиров: 2343+1765+1032+2607+967+1143+1967+1478+2058 = 15360
            int expected = 15360;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAveragePassengersPerDay()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            double result = ds.GetAveragePassengersPerDay(matrix);

            // Среднее пассажиров: 15360/9 = 1706.67
            double expected = 1706.67;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestGetRoutesWithChargerCount()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            int result = ds.GetRoutesWithChargerCount(matrix);

            // Все автобусы (5 шт) имеют "есть"
            Assert.AreEqual(5, result);
        }

    }
}