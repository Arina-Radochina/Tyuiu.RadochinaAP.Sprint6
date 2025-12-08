namespace Tyuiu.RadochinaAP.Sprint6.Task7.V11
{
    partial class FormMain
    {
        System.ComponentModel.IContainer components = null;

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
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            this.groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.SuspendLayout();

            // groupBoxIn
            this.groupBoxIn.Controls.Add(this.dataGridViewIn);
            this.groupBoxIn.Location = new System.Drawing.Point(12, 80);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(400, 300);
            this.groupBoxIn.TabIndex = 0;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "Ввод данных";

            // dataGridViewIn
            this.dataGridViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewIn.Name = "dataGridViewIn";
            this.dataGridViewIn.ReadOnly = true;
            this.dataGridViewIn.Size = new System.Drawing.Size(388, 273);
            this.dataGridViewIn.TabIndex = 0;

            // groupBoxOut
            this.groupBoxOut.Controls.Add(this.dataGridViewOut);
            this.groupBoxOut.Location = new System.Drawing.Point(418, 80);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(400, 300);
            this.groupBoxOut.TabIndex = 1;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Вывод данных";

            // dataGridViewOut
            this.dataGridViewOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewOut.Name = "dataGridViewOut";
            this.dataGridViewOut.ReadOnly = true;
            this.dataGridViewOut.Size = new System.Drawing.Size(388, 273);
            this.dataGridViewOut.TabIndex = 0;

            // buttonOpenFile
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 386);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(100, 40);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);

            // buttonDone
            this.buttonDone.Enabled = false;
            this.buttonDone.Location = new System.Drawing.Point(358, 386);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(100, 40);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);

            // buttonSave
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(718, 386);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 40);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // buttonHelp
            this.buttonHelp.Location = new System.Drawing.Point(718, 432);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 40);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(350, 20);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Спринт 6 | Таск 7 | Вариант 11";

            // textBoxCondition
            this.textBoxCondition.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition.Location = new System.Drawing.Point(12, 40);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(806, 30);
            this.textBoxCondition.TabIndex = 7;
            this.textBoxCondition.Text = "Загрузить CSV. В столбце 2 заменить 0 на 1.";

            // openFileDialogTask
            this.openFileDialogTask.FileName = "openFileDialogTask";

            // saveFileDialogTask
            this.saveFileDialogTask.FileName = "saveFileDialogTask";

            // FormMain
            this.ClientSize = new System.Drawing.Size(830, 484);
            this.Controls.Add(this.textBoxCondition);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.groupBoxOut);
            this.Controls.Add(this.groupBoxIn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 11 | Радочина А.П.";
            this.groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            this.groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.GroupBox groupBoxOut;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask;
    }
}