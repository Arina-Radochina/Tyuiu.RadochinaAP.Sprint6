namespace Tyuiu.RadochinaAP.Sprint6.Task0.V3
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxVarX;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelVarX;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonHelp;

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
            this.labelVarX = new System.Windows.Forms.Label();
            this.textBoxVarX = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelVarX
            this.labelVarX.AutoSize = true;
            this.labelVarX.Location = new System.Drawing.Point(30, 30);
            this.labelVarX.Name = "labelVarX";
            this.labelVarX.Size = new System.Drawing.Size(16, 16);
            this.labelVarX.TabIndex = 0;
            this.labelVarX.Text = "x:";

            // textBoxVarX
            this.textBoxVarX.Location = new System.Drawing.Point(60, 27);
            this.textBoxVarX.Name = "textBoxVarX";
            this.textBoxVarX.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX.TabIndex = 1;
            this.textBoxVarX.Text = "3";
            this.textBoxVarX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);

            // buttonCalculate
            this.buttonCalculate.Location = new System.Drawing.Point(30, 70);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(130, 35);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(30, 130);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(80, 16);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Результат:";

            // textBoxResult
            this.textBoxResult.Location = new System.Drawing.Point(120, 127);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult.TabIndex = 4;

            // buttonHelp
            this.buttonHelp.Location = new System.Drawing.Point(170, 70);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(35, 35);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 200);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxVarX);
            this.Controls.Add(this.labelVarX);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6. Задание 0. Вариант 3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
