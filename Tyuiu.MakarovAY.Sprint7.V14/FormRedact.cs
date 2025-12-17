using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MakarovAY.Sprint7.V14.Lib;

namespace Tyuiu.MakarovAY.Sprint7.V14
{
    public partial class FormRedact : Form
    {
        public FormRedact()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static string path;
        static string[,] matrix;
        static int rows;
        static int columns;
        int sortColumnIndex;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddFile_MAY_Click_1(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_MAY.ShowDialog();
                path = openFileDialog_MAY.FileName;

                matrix = ds.LoadFromDataFile(path);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewTransport_MAY.Rows.Clear();
                dataGridViewTransport_MAY.ColumnCount = columns;
                dataGridViewTransport_MAY.RowCount = rows;

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                        dataGridViewTransport_MAY.Rows[i].Cells[j].Value = matrix[i, j];

                // заголовки для сортировки
                comboBoxSortСriterion_MAY.Items.Clear();
                for (int j = 0; j < columns; j++)
                    comboBoxSortСriterion_MAY.Items.Add(matrix[0, j]);

                comboBoxSortСriterion_MAY.Enabled = true;
                buttonAddValue_MAY.Enabled = true;
                buttonDeleteValue_MAY.Enabled = true;
                buttonDoneSaveToFile_MAY.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки файла");
            }
        }

        private void buttonAddValue_MAY_Click_1(object sender, EventArgs e)
        {
            dataGridViewTransport_MAY.Rows.Add();
        }

        private void buttonDeleteValue_MAY_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTransport_MAY.CurrentCell != null)
            {
                dataGridViewTransport_MAY.Rows.RemoveAt(dataGridViewTransport_MAY.CurrentCell.RowIndex);
            }
        }

        private void comboBoxSortСriterion_MAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxSortValue_MAY.Items.Clear();

                for (int j = 0; j < columns; j++)
                    if (comboBoxSortСriterion_MAY.Text == matrix[0, j])
                        sortColumnIndex = j;

                for (int i = 1; i < rows; i++)
                {
                    if (!comboBoxSortValue_MAY.Items.Contains(matrix[i, sortColumnIndex]))
                    {
                        comboBoxSortValue_MAY.Items.Add(matrix[i, sortColumnIndex]);
                    }
                }

                comboBoxSortValue_MAY.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка выбора критерия");
            }
        }

        private void comboBoxSortValue_MAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewTransport_MAY.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                if (i == 0 || matrix[i, sortColumnIndex] == comboBoxSortValue_MAY.Text)
                {
                    int rowIndex = dataGridViewTransport_MAY.Rows.Add();
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewTransport_MAY.Rows[rowIndex].Cells[j].Value = matrix[i, j];
                    }
                }
            }
        }

        private void buttonDoneSaveToFile_MAY_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_MAY.FileName = ".csv";

                if (saveFileDialog_MAY.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < dataGridViewTransport_MAY.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridViewTransport_MAY.ColumnCount; j++)
                        {
                            sb.Append(dataGridViewTransport_MAY.Rows[i].Cells[j].Value);
                            if (j != dataGridViewTransport_MAY.ColumnCount - 1)
                                sb.Append(";");
                        }
                        sb.AppendLine();
                    }

                    File.WriteAllText(saveFileDialog_MAY.FileName, sb.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл сохранен");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }
    }
}
