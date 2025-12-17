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
            Assert.AreEqual(15, matrix.GetLength(0)); 
            Assert.AreEqual(12, matrix.GetLength(1)); 

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
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMinibusCount()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            int result = ds.GetMinibusCount(matrix);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestChargerCount()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            int result = ds.GetRoutesWithChargerCount(matrix);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMinTravelTime()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            int result = ds.GetMinTravelTime(matrix);
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void TestMaxTravelTime()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            int result = ds.GetMaxTravelTime(matrix);
            Assert.AreEqual(182, result);
        }

        [TestMethod]
        public void TestAverageTravelTime()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            double result = ds.GetAverageTravelTime(matrix);
            double wait = 84.07;
            Assert.AreEqual(wait, result);

        }
        public void TestGetTotalDailyTravelTime()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            double result = ds.GetTotalDailyTravelTime(matrix);
            double wait = 76.33;
            Assert.AreEqual(wait, result);

        }
        [TestMethod]
        public void TestTotalPassengersPerDay()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            int result = ds.GetTotalPassengersPerDay(matrix);
            int expected = 28507;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAveragePassengersPerDay()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);

            double result = ds.GetAveragePassengersPerDay(matrix);
            double expected = 2036.21;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestGetRoutesWithChargerCount()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            int result = ds.GetRoutesWithChargerCount(matrix);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void TestGetRoutesWithLargeClassBus()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            int result = ds.GetRoutesWithLargeClassBus(matrix);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestGetRoutesWorkssOnWeekends()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            int result = ds.GetRoutesWorkssOnWeekends(matrix);
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void TestGetRoutesWithWheelchairRamps()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            int result = ds.GetRoutesWithWheelchairRamp(matrix);
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void TestGetRoutesWithPaymentForSBPSystem()
        {
            DataService ds = new DataService();
            string[,] matrix = ds.LoadFromDataFile(testFilePath);
            int result = ds.GetRoutesWithPaymentForSBPSystem(matrix);
            Assert.AreEqual(7, result);
        }


    }
}