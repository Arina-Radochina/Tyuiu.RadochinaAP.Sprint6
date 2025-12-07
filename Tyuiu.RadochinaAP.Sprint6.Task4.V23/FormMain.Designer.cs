namespace Tyuiu.RadochinaAP.Sprint6.Task4.V23
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.TextBox textBoxStopStep;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelStop = new System.Windows.Forms.Label();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();

            // labelTask
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(12, 9);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(350, 25);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Спринт 6 | Таск 4 | Вариант 23";

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
            this.textBoxCondition.Text = "Табулировать функцию: F(x) = 4 - 2x + (2+cos(x))/(2x-2) на диапазоне [-5; 5] с шагом 1. Проверить деление на ноль. Результат вывести в textBox, построить график и сохранить в файл.";

            // labelStart
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(12, 120);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(100, 20);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "Старт шага:";

            // labelStop
            this.labelStop.AutoSize = true;
            this.labelStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStop.Location = new System.Drawing.Point(12, 155);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(103, 20);
            this.labelStop.TabIndex = 4;
            this.labelStop.Text = "Конец шага:";

            // textBoxStartStep
            this.textBoxStartStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartStep.Location = new System.Drawing.Point(120, 117);
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(100, 26);
            this.textBoxStartStep.TabIndex = 5;
            this.textBoxStartStep.Text = "-5";

            // textBoxStopStep
            this.textBoxStopStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStopStep.Location = new System.Drawing.Point(120, 152);
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(100, 26);
            this.textBoxStopStep.TabIndex = 6;
            this.textBoxStopStep.Text = "5";

            // buttonDone - ВЫПОЛНИТЬ (зеленый)
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(250, 117);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(120, 60);
            this.buttonDone.TabIndex = 7;
            this.buttonDone.Text = "ВЫПОЛНИТЬ";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);

            // buttonSave - СОХРАНИТЬ (синий)
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(390, 117);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 60);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "СОХРАНИТЬ";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonSave_MouseEnter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.buttonSave_MouseLeave);

            // buttonHelp - СПРАВКА (голубой)
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp.Location = new System.Drawing.Point(530, 117);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 60);
            this.buttonHelp.TabIndex = 9;
            this.buttonHelp.Text = "СПРАВКА";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp.MouseEnter += new System.EventHandler(this.buttonHelp_MouseEnter);
            this.buttonHelp.MouseLeave += new System.EventHandler(this.buttonHelp_MouseLeave);

            // textBoxResult
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 190);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(300, 250);
            this.textBoxResult.TabIndex = 10;

            // chartFunction
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(330, 190);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(450, 250);
            this.chartFunction.TabIndex = 11;
            this.chartFunction.Text = "График функции";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxStopStep);
            this.Controls.Add(this.textBoxStartStep);
            this.Controls.Add(this.labelStop);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.textBoxCondition);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelTask);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 23 | Радочина А. П.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}