namespace Tyuiu.RadochinaAP.Sprint6.Task5.V26
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridViewNums;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridViewNums = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag)).BeginInit();
            this.SuspendLayout();

            // labelTask
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(12, 9);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(350, 25);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Спринт 6 | Таск 5 | Вариант 26";

            // labelCondition
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition.Location = new System.Drawing.Point(12, 45);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(89, 20);
            this.labelCondition.TabIndex = 1;
            this.labelCondition.Text = "Условие:";

            // textBoxCondition
            this.textBoxCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition.Location = new System.Drawing.Point(107, 45);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(500, 60);
            this.textBoxCondition.TabIndex = 2;
            this.textBoxCondition.Text = "Прочитать данные из файла InPutFileTask5V26.txt. Вывести в dataGridView числа кратные 5. Построить диаграмму по этим значениям. Округлить до трех знаков.";

            // labelPath
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.Location = new System.Drawing.Point(12, 120);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(54, 20);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "Путь:";

            // textBoxPath
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPath.Location = new System.Drawing.Point(70, 120);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(537, 23);
            this.textBoxPath.TabIndex = 4;
            this.textBoxPath.Text = @"C:\Users\Кошка\source\repos\Tyuiu.RadochinaAP.Sprint6\Tyuiu.RadochinaAP.Sprint6.Task5.V26\bin\Debug\InPutFileTask5V26.txt";

            // buttonDone
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(12, 155);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(150, 60);
            this.buttonDone.TabIndex = 5;
            this.buttonDone.Text = "ВЫПОЛНИТЬ";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);

            // buttonOpenFile
            this.buttonOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFile.Location = new System.Drawing.Point(180, 155);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(150, 60);
            this.buttonOpenFile.TabIndex = 6;
            this.buttonOpenFile.Text = "ОТКРЫТЬ ФАЙЛ";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            this.buttonOpenFile.MouseEnter += new System.EventHandler(this.buttonOpenFile_MouseEnter);
            this.buttonOpenFile.MouseLeave += new System.EventHandler(this.buttonOpenFile_MouseLeave);

            // buttonHelp
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp.Location = new System.Drawing.Point(350, 155);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 60);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "СПРАВКА";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp.MouseEnter += new System.EventHandler(this.buttonHelp_MouseEnter);
            this.buttonHelp.MouseLeave += new System.EventHandler(this.buttonHelp_MouseLeave);

            // labelInfo
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(470, 175);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(137, 20);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "Найдено чисел: 0";

            // dataGridViewNums - ИСПРАВЛЕНО!
            this.dataGridViewNums.AllowUserToAddRows = false;
            this.dataGridViewNums.AllowUserToDeleteRows = false;
            this.dataGridViewNums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNums.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNums.Location = new System.Drawing.Point(12, 225);
            this.dataGridViewNums.Name = "dataGridViewNums";
            this.dataGridViewNums.ReadOnly = true;
            this.dataGridViewNums.RowHeadersVisible = false;
            this.dataGridViewNums.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewNums.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNums.RowTemplate.Height = 24;
            this.dataGridViewNums.Size = new System.Drawing.Size(300, 200);
            this.dataGridViewNums.TabIndex = 9;

            // Column1
            this.Column1.HeaderText = "Индекс";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;

            // Column2
            this.Column2.HeaderText = "Значение";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;

            // chartDiag
            chartArea1.Name = "ChartArea1";
            this.chartDiag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDiag.Legends.Add(legend1);
            this.chartDiag.Location = new System.Drawing.Point(330, 225);
            this.chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag.Series.Add(series1);
            this.chartDiag.Size = new System.Drawing.Size(450, 200);
            this.chartDiag.TabIndex = 10;
            this.chartDiag.Text = "Диаграмма";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.chartDiag);
            this.Controls.Add(this.dataGridViewNums);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxCondition);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelTask);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 26 | Радочина А. П.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ДОБАВЬТЕ ЭТИ СТРОКИ В КЛАСС
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}