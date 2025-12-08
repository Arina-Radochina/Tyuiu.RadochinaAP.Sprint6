using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Tyuiu.RadochinaAP.Sprint6.Task7.V11.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace Tyuiu.RadochinaAP.Sprint6.Task7.V11
{
    public partial class FormMain : Form
    {

        public FormMain()

        {
            InitializeComponent();

        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.Filter = "CSV файлы (*.csv)|*.csv";
            openFileDialogTask.FileName = "InPutFileTask7V11.csv";

            if (openFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                DataService ds = new DataService();
                var matrix = ds.GetMatrix(openFileDialogTask.FileName);
                ShowMatrix(dataGridViewIn, matrix);
                buttonDone.Enabled = true;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            var matrix = ds.GetMatrix(openFileDialogTask.FileName);
            var result = ds.ReplaceZerosInSecondColumn(matrix);
            ShowMatrix(dataGridViewOut, result);
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.Filter = "CSV файлы (*.csv)|*.csv";
            saveFileDialogTask.FileName = "OutPutFileTask7.csv";

            if (saveFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                DataService ds = new DataService();
                var matrix = ds.GetMatrix(openFileDialogTask.FileName);
                var result = ds.ReplaceZerosInSecondColumn(matrix);
                ds.SaveMatrixToCsv(result, saveFileDialogTask.FileName);
                MessageBox.Show("Сохранено!");
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Радочина А.П.\nГруппа: ПИНб-25-1\nВариант 11");
        }

        private void ShowMatrix(DataGridView dgv, int[,] mat)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            for (int j = 0; j < mat.GetLength(1); j++)
            {
                dgv.Columns.Add($"col{j}", $"Столбец {j}");
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                dgv.Rows.Add();
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    dgv.Rows[i].Cells[j].Value = mat[i, j];
                }
            }
        }
    }
}