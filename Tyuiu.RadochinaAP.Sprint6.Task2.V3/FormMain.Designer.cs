namespace Tyuiu.RadochinaAP.Sprint6.Task2.V3
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.TextBox textBoxStopStep;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelOutput;

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
            this.panelInput = new System.Windows.Forms.Panel();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelStop = new System.Windows.Forms.Label();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();

            // labelTask
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(12, 9);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(350, 25);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Спринт 6 | Таск 2 | Вариант 3";

            // panelInput
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.textBoxStopStep);
            this.panelInput.Controls.Add(this.textBoxStartStep);
            this.panelInput.Controls.Add(this.labelStop);
            this.panelInput.Controls.Add(this.labelStart);
            this.panelInput.Location = new System.Drawing.Point(12, 40);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(250, 80);
            this.panelInput.TabIndex = 1;

            // labelStart
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(10, 15);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(100, 20);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Старт шага:";

            // labelStop
            this.labelStop.AutoSize = true;
            this.labelStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStop.Location = new System.Drawing.Point(10, 45);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(103, 20);
            this.labelStop.TabIndex = 1;
            this.labelStop.Text = "Конец шага:";

            // textBoxStartStep
            this.textBoxStartStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartStep.Location = new System.Drawing.Point(120, 12);
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(100, 26);
            this.textBoxStartStep.TabIndex = 2;
            this.textBoxStartStep.Text = "-5";

            // textBoxStopStep
            this.textBoxStopStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStopStep.Location = new System.Drawing.Point(120, 42);
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(100, 26);
            this.textBoxStopStep.TabIndex = 3;
            this.textBoxStopStep.Text = "5";

            // buttonDone - ВЫПОЛНИТЬ (зеленый)
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(280, 40);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(150, 60);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "ВЫПОЛНИТЬ";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);

            // buttonHelp - СПРАВКА (синий)
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(450, 40);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 60);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "СПРАВКА";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // panelOutput
            this.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutput.Controls.Add(this.dataGridViewFunction);
            this.panelOutput.Location = new System.Drawing.Point(12, 130);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(300, 350);
            this.panelOutput.TabIndex = 4;

            // dataGridViewFunction
            this.dataGridViewFunction.AllowUserToAddRows = false;
            this.dataGridViewFunction.AllowUserToDeleteRows = false;
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnFx});
            this.dataGridViewFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFunction.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.ReadOnly = true;
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.RowHeadersWidth = 51;
            this.dataGridViewFunction.RowTemplate.Height = 24;
            this.dataGridViewFunction.Size = new System.Drawing.Size(298, 348);
            this.dataGridViewFunction.TabIndex = 0;

            // ColumnX
            this.ColumnX.HeaderText = "X";
            this.ColumnX.MinimumWidth = 6;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 125;

            // ColumnFx
            this.ColumnFx.HeaderText = "F(x)";
            this.ColumnFx.MinimumWidth = 6;
            this.ColumnFx.Name = "ColumnFx";
            this.ColumnFx.ReadOnly = true;
            this.ColumnFx.Width = 125;

            // chartFunction
            this.chartFunction.BorderlineColor = System.Drawing.Color.Black;
            this.chartFunction.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            this.chartFunction.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(325, 130);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(550, 350);
            this.chartFunction.TabIndex = 5;
            this.chartFunction.Text = "chart1";
            this.chartFunction.Click += new System.EventHandler(this.chartFunction_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.labelTask);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Радочина А. П.";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}