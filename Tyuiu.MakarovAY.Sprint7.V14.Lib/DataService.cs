using System;
using System.IO;
using System.Text;

namespace Tyuiu.MakarovAY.Sprint7.V14.Lib
{
    public class DataService
    {
        // Эта строка регистрирует поддержку Windows-1251
        static DataService()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public string[,] LoadFromDataFile(string path)
        {
            // Читаем с UTF-8 кодировкой
            string[] lines = File.ReadAllLines(path, Encoding.GetEncoding(1251));

            if (lines.Length == 0)
                return new string[0, 0];

            char separator = lines[0].Contains(';') ? ';' : ',';

            int columns = lines[0].Split(separator).Length;
            int rows = lines.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(separator);

                for (int j = 0; j < columns; j++)
                {
                    // Триммируем и декодируем если нужно
                    string value = j < parts.Length ? parts[j].Trim() : string.Empty;
                    matrix[i, j] = value;
                }
            }

            return matrix;
        }

        public int GetTotalRoutesCount(string[,] matrix)
        {
            int count = 0;
            for (int i = 1; i < matrix.GetLength(0); i++) { count = count + 1; }
            return count;
        }

        public int GetBusCount(string[,] matrix)
        {
            int count = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0].ToLower() == "автобус") { count = count + 1; }
            }
            return count;
        }

        public int GetMinibusCount(string[,] matrix)
        {
            int count = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0].Trim().ToLower() == "маршрутка") { count = count + 1; }
            }
            return count;
        }

        public int GetMinTravelTime(string[,] matrix)
        {
            if (matrix.GetLength(0) <= 1) return 0;
            int min = int.Parse(matrix[1, 5]);
            for (int i = 2; i < matrix.GetLength(0); i++)
            {
                int current = int.Parse(matrix[i, 5]);
                if (current < min) { min = current; }
            }
            return min;
        }

        public int GetMaxTravelTime(string[,] matrix)
        {
            if (matrix.GetLength(0) <= 1) return 0;
            int max = int.Parse(matrix[1, 5]);
            for (int i = 2; i < matrix.GetLength(0); i++)
            {
                int current = int.Parse(matrix[i, 5]);
                if (current > max) { max = current; }
            }
            return max;
        }

        public double GetAverageTravelTime(string[,] matrix)
        {
            if (matrix.GetLength(0) <= 1) return 0;
            int sum = 0;
            int count = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                sum = sum + int.Parse(matrix[i, 5]);
                count = count + 1;
            }
            double avg = (double)sum / count;
            return Math.Round(avg, 2);
        }

        public int GetTotalDailyTravelTime(string[,] matrix)
        {
            int total = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                int time = int.Parse(matrix[i, 5]);
                total = total + (time * 10);
            }
            return total;
        }

        public int GetTotalPassengersPerDay(string[,] matrix)
        {
            int total = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                total = total + int.Parse(matrix[i, 7]);
            }
            return total;
        }

        public double GetAveragePassengersPerDay(string[,] matrix)
        {
            if (matrix.GetLength(0) <= 1) return 0;
            int sum = 0;
            int count = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                sum = sum + int.Parse(matrix[i, 7]);
                count = count + 1;
            }
            double avg = (double)sum / count;
            return Math.Round(avg, 2);
        }

        public int GetRoutesWithChargerCount(string[,] matrix)
        {
            int count = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 6].ToLower() == "есть") { count = count + 1; }
            }
            return count;
        }

    }
}