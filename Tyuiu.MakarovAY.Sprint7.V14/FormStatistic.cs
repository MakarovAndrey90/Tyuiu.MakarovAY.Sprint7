using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.MakarovAY.Sprint7.V14.Lib;

namespace Tyuiu.MakarovAY.Sprint7.V14
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        public string path;
        public string[,] matrix;

        private void buttonAddFile_MAY_Click(object sender, EventArgs e)
        {
            try
            {
                // Открываем диалог выбора файла
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;

                    // Загружаем данные
                    matrix = ds.LoadFromDataFile(path);

                    // Показываем успех
                    MessageBox.Show($"Файл загружен! Маршрутов: {matrix.GetLength(0) - 1}",
                                  "Успех",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    // АВТОМАТИЧЕСКИ выполняем после загрузки:
                    // 1. Заполняем статистику
                    FillStatistics();

                    // 2. Строим график
                    BuildPassengersChart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillStatistics()
        {
            int maxTime = ds.GetMaxTravelTime(matrix);
            textBoxMaxTimeTravel_MAY.Text = maxTime.ToString() + " мин";
            int minTime = ds.GetMinTravelTime(matrix);
            textBoxMinTimeTravel_MAY.Text = minTime.ToString() + " мин";
            double avgTime = ds.GetAverageTravelTime(matrix);
            textBoxCrTimeTravel_MAY.Text = avgTime.ToString() + " мин";
            int totalPassengers = ds.GetTotalPassengersPerDay(matrix);
            textBoxSumpassenger_MAY.Text = totalPassengers.ToString() + " чел/день";
            int totalTransport = ds.GetTotalRoutesCount(matrix);
            textBoxSumtransport_MAY.Text = totalTransport.ToString() + " ед.";
            int busCount = ds.GetBusCount(matrix);
            textBoxSumBus_MAY.Text = busCount.ToString();
            int minibusCount = ds.GetMinibusCount(matrix);
            textBoxSumminiBus_MAY.Text = minibusCount.ToString();
        }
        private void BuildPassengersChart()
        {
            if (matrix == null || matrix.GetLength(0) <= 1)
                return;

            chartNumberOFPassengers_MAY.Series.Clear();

            Series series = new Series("Пассажиры");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.IsXValueIndexed = true;

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                string route = matrix[i, 1].Trim();

                if (int.TryParse(matrix[i, 7], out int passengers))
                {
                    series.Points.AddXY(route, passengers);
                }
            }

            chartNumberOFPassengers_MAY.Series.Add(series);

            chartNumberOFPassengers_MAY.ChartAreas[0].AxisX.Title = "Номер маршрута";
            chartNumberOFPassengers_MAY.ChartAreas[0].AxisY.Title = "Пассажиры";
            chartNumberOFPassengers_MAY.ChartAreas[0].AxisX.Interval = 1;
        }
    }
}
