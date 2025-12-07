using Tyuiu.RadochinaAP.Sprint6.Task1.V20.Lib;

namespace Tyuiu.RadochinaAP.Sprint6.Task1.V20
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService(); 

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);

                int len = stopStep - startStep + 1;
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                int currentX = startStep;
                for (int i = 0; i < len; i++)
                {
                    string strLine = String.Format("| {0,5:d}     | {1, 7:f2}   |",
                        currentX, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    currentX++;
                }

                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                // Кнопка становится зеленой после выполнения
                buttonResult.BackColor = System.Drawing.Color.LimeGreen;
                buttonResult.Text = "Выполнено!";
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции:\r\n" +
                  "F(x) = (2x-3)/(cos(x)-2x) + 5x - sin(x)\r\n" +
                  "X вводится в радианах (как в математической формуле)\r\n" +
                  "Результат округлен до 2 знаков после запятой\r\n" +
                  "При делении на ноль возвращается 0\r\n" +
                  "\r\nЗадание выполнила: Радочина Арина Павловна, ПИНб-25-1\r\n" +
                  "Вариант 20",
                  "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}