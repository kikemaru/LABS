namespace viborSortQuickSort
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьНаборToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.выводСтатистикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButtonVibor = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelNumberOfPermutations = new System.Windows.Forms.Label();
            this.labelTimeSort = new System.Windows.Forms.Label();
            this.labelCountComparison = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1261, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.сгенерироватьНаборToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.DimGray;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(104, 33);
            this.toolStripDropDownButton1.Text = "Данные";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.открытьФайлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(313, 34);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // сгенерироватьНаборToolStripMenuItem
            // 
            this.сгенерироватьНаборToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.сгенерироватьНаборToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.сгенерироватьНаборToolStripMenuItem.Name = "сгенерироватьНаборToolStripMenuItem";
            this.сгенерироватьНаборToolStripMenuItem.Size = new System.Drawing.Size(313, 34);
            this.сгенерироватьНаборToolStripMenuItem.Text = "Сгенерировать набор";
            this.сгенерироватьНаборToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьНаборToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выводСтатистикиToolStripMenuItem});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(98, 33);
            this.toolStripDropDownButton2.Text = "Анализ";
            // 
            // выводСтатистикиToolStripMenuItem
            // 
            this.выводСтатистикиToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.выводСтатистикиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.выводСтатистикиToolStripMenuItem.Name = "выводСтатистикиToolStripMenuItem";
            this.выводСтатистикиToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.выводСтатистикиToolStripMenuItem.Text = "Вывод статистики";
            this.выводСтатистикиToolStripMenuItem.Click += new System.EventHandler(this.выводСтатистикиToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(278, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(955, 524);
            this.listBox1.TabIndex = 1;
            // 
            // radioButtonVibor
            // 
            this.radioButtonVibor.AutoSize = true;
            this.radioButtonVibor.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonVibor.Checked = true;
            this.radioButtonVibor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVibor.ForeColor = System.Drawing.Color.Black;
            this.radioButtonVibor.Location = new System.Drawing.Point(9, 19);
            this.radioButtonVibor.Name = "radioButtonVibor";
            this.radioButtonVibor.Size = new System.Drawing.Size(160, 24);
            this.radioButtonVibor.TabIndex = 2;
            this.radioButtonVibor.TabStop = true;
            this.radioButtonVibor.Text = "Метод Обмена";
            this.radioButtonVibor.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(9, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(236, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Метод б-ый сортировки";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.buttonSort);
            this.groupBox1.Controls.Add(this.radioButtonVibor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выерите метод сортировки";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSort.Location = new System.Drawing.Point(9, 72);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(204, 40);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Начать сортировку";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Controls.Add(this.labelNumberOfPermutations);
            this.groupBox2.Controls.Add(this.labelTimeSort);
            this.groupBox2.Controls.Add(this.labelCountComparison);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 151);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о сортировке:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Время сортировки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество сравнений:";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClear.Location = new System.Drawing.Point(0, 104);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(180, 40);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelNumberOfPermutations
            // 
            this.labelNumberOfPermutations.AutoSize = true;
            this.labelNumberOfPermutations.BackColor = System.Drawing.SystemColors.Control;
            this.labelNumberOfPermutations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNumberOfPermutations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfPermutations.ForeColor = System.Drawing.Color.Black;
            this.labelNumberOfPermutations.Location = new System.Drawing.Point(155, 56);
            this.labelNumberOfPermutations.Name = "labelNumberOfPermutations";
            this.labelNumberOfPermutations.Size = new System.Drawing.Size(20, 22);
            this.labelNumberOfPermutations.TabIndex = 8;
            this.labelNumberOfPermutations.Text = "0";
            // 
            // labelTimeSort
            // 
            this.labelTimeSort.AutoSize = true;
            this.labelTimeSort.BackColor = System.Drawing.SystemColors.Control;
            this.labelTimeSort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTimeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeSort.ForeColor = System.Drawing.Color.Black;
            this.labelTimeSort.Location = new System.Drawing.Point(116, 86);
            this.labelTimeSort.Name = "labelTimeSort";
            this.labelTimeSort.Size = new System.Drawing.Size(20, 22);
            this.labelTimeSort.TabIndex = 6;
            this.labelTimeSort.Text = "0";
            // 
            // labelCountComparison
            // 
            this.labelCountComparison.AutoSize = true;
            this.labelCountComparison.BackColor = System.Drawing.SystemColors.Control;
            this.labelCountComparison.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCountComparison.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountComparison.ForeColor = System.Drawing.Color.Black;
            this.labelCountComparison.Location = new System.Drawing.Point(137, 28);
            this.labelCountComparison.Name = "labelCountComparison";
            this.labelCountComparison.Size = new System.Drawing.Size(20, 22);
            this.labelCountComparison.TabIndex = 2;
            this.labelCountComparison.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество перестановок:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1261, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лабораторная работа №4";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьНаборToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonVibor;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.Label labelCountComparison;
        public System.Windows.Forms.Label labelTimeSort;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem выводСтатистикиToolStripMenuItem;
        public System.Windows.Forms.Label labelNumberOfPermutations;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

