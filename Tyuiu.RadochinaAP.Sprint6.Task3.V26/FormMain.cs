using Tyuiu.RadochinaAP.Sprint6.Task3.V26.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task3.V26
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5]
        {
            { 16, 19, 17, 2, 8 },
            { -17, 8, -17, -8, 1 },
            { -7, 17, -2, 1, -3 },
            { -12, 0, -17, 15, 6 },
            { 17, -6, -17, 18, -19 }
        };
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows; 

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] resultMatrix = ds.Calculate(mtrx);

            int rows = resultMatrix.GetUpperBound(0) + 1;
            int columns = resultMatrix.Length / rows;

            dataGridViewMatrix.Rows.Clear();
            dataGridViewMatrix.Columns.Clear();

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(resultMatrix[i, j]);
                }
            }

            buttonDone.Text = "Выполнено!";
            buttonDone.BackColor = Color.LightGreen;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание: Дан массив 5x5 элементов. Заменить четные значения в третьей строке на 0.\n\n" +
                          "Исходная матрица:\n" +
                          "16   19   17    2    8\n" +
                          "-17   8   -17   -8   1\n" +
                          "-7   17   -2    1   -3  ← третья строка\n" +
                          "-12  0    -17   15   6\n" +
                          "17   -6   -17   18   -19\n\n" +
                          "В третьей строке четное число: -2 → заменяется на 0\n\n" +
                          "Задание выполнила: Радочина Арина Павловна, ПИНб-25-1\n" +
                          "Вариант 26",
                          "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.FromArgb(0, 200, 0);
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            if (buttonDone.Text != "Выполнено!")
            {
                buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.FromArgb(0, 150, 0);
        }
    }
}
