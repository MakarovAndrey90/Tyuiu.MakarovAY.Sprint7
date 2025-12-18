using Tyuiu.MakarovAY.Sprint7.V14.Lib;

namespace Tyuiu.MakarovAY.Sprint7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        public string path;
        public string[,] matrix;

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAbout forminfo = new FormAbout();
            forminfo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormStatistic formstat = new FormStatistic();
            formstat.ShowDialog();
        }

        private void textBoxStop_MAY_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_MAY.ShowDialog();
                path = openFileDialog_MAY.FileName;
                matrix = ds.LoadFromDataFile(path);
                comboBoxShowNum_MAY.Items.Clear();
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    comboBoxShowNum_MAY.Items.Add(matrix[i, 1]);
                }
                buttonDone_MAY.Enabled = true;
                MessageBox.Show($"Файл загружен!\nНайдено маршрутов: {matrix.GetLength(0) - 1}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Файл не выбран или произошла ошибка при загрузке",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }


        private void buttonDone_MAY_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранный номер маршрута
                string selectedRoute = comboBoxShowNum_MAY.SelectedItem.ToString();

                // Ищем выбранный маршрут в матрице
                bool found = false;
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    // Сравниваем номера маршрутов (столбец 1)
                    if (matrix[i, 1].Trim() == selectedRoute)
                    {
                        textBoxModeOfTheTransport_MAY.Text = matrix[i, 0];
                        textBoxLargeClassBus_MAY.Text = matrix[i, 8];
                        textBoxCharger_MAY.Text = matrix[i, 6];
                        textBoxWorksOnWeekends_MAY.Text = matrix[i, 9];
                        textBoxWheelchairRamp_MAY.Text = matrix[i, 10];
                        textBoxPaymentForSBPSystem_MAY.Text = matrix[i, 11];
                        textBoxStart_MAY.Text = matrix[i, 3];
                        textBoxStop_MAY.Text = matrix[i, 4];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxShowNum_MAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoute = comboBoxShowNum_MAY.SelectedItem.ToString();
            textBoxRoutesNumber_MAY.Text = selectedRoute;
        }

        private void textBoxLargeClassBus_MAY_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPaymentForSBPSystem_MAY_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRedact formRedact = new FormRedact();
            formRedact.ShowDialog();
        }

        private void textBoxModeOfTheTransport_MAY_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
