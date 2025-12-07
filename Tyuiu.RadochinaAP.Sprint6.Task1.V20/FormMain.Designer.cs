namespace Tyuiu.RadochinaAP.Sprint6.Task1.V20
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.TextBox textBoxStopStep;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelStop;

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
            this.labelTask = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelStop = new System.Windows.Forms.Label();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelTask - Спринт 6 | Таск 1 | Вариант 20 | Радочина А. П.
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(12, 9);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(350, 25);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Спринт 6 | Таск 1 | Вариант 20";

            // labelStart - Старт шага:
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(12, 50);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(100, 20);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Старт шага:";

            // textBoxStartStep
            this.textBoxStartStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartStep.Location = new System.Drawing.Point(120, 47);
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(100, 26);
            this.textBoxStartStep.TabIndex = 2;
            this.textBoxStartStep.Text = "-5";

            // labelStop - Конец шага:
            this.labelStop.AutoSize = true;
            this.labelStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStop.Location = new System.Drawing.Point(12, 85);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(103, 20);
            this.labelStop.TabIndex = 3;
            this.labelStop.Text = "Конец шага:";

            // textBoxStopStep
            this.textBoxStopStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStopStep.Location = new System.Drawing.Point(120, 82);
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(100, 26);
            this.textBoxStopStep.TabIndex = 4;
            this.textBoxStopStep.Text = "5";

            // buttonResult - ВЫПОЛНИТЬ (зеленый)
            this.buttonResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.ForeColor = System.Drawing.Color.White;
            this.buttonResult.Location = new System.Drawing.Point(250, 47);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(150, 60);
            this.buttonResult.TabIndex = 5;
            this.buttonResult.Text = "ВЫПОЛНИТЬ";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);

            // buttonHelp - СПРАВКА (синий)
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(420, 47);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 60);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "СПРАВКА";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // textBoxResult - Результат:
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 130);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(510, 250);
            this.textBoxResult.TabIndex = 7;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 400);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxStopStep);
            this.Controls.Add(this.textBoxStartStep);
            this.Controls.Add(this.labelStop);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelTask);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 20 | Радочина А. П.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}