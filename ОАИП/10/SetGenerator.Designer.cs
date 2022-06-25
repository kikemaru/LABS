namespace viborSortQuickSort
{
    partial class SetGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBoxCountElements = new System.Windows.Forms.TextBox();
            this.buttonCreateArray = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите количество элементов \r\nв генерируемом наборе:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Location = new System.Drawing.Point(12, 62);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(256, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBoxCountElements
            // 
            this.textBoxCountElements.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCountElements.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCountElements.Location = new System.Drawing.Point(11, 107);
            this.textBoxCountElements.Name = "textBoxCountElements";
            this.textBoxCountElements.Size = new System.Drawing.Size(124, 20);
            this.textBoxCountElements.TabIndex = 2;
            this.textBoxCountElements.TextChanged += new System.EventHandler(this.textBoxCountElements_TextChanged);
            // 
            // buttonCreateArray
            // 
            this.buttonCreateArray.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateArray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateArray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateArray.Location = new System.Drawing.Point(153, 102);
            this.buttonCreateArray.Name = "buttonCreateArray";
            this.buttonCreateArray.Size = new System.Drawing.Size(124, 28);
            this.buttonCreateArray.TabIndex = 3;
            this.buttonCreateArray.Text = "Создать";
            this.buttonCreateArray.UseVisualStyleBackColor = false;
            this.buttonCreateArray.Click += new System.EventHandler(this.buttonCreateArray_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // SetGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(291, 139);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreateArray);
            this.Controls.Add(this.textBoxCountElements);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetGenerator";
            this.Text = "Генератор массива";
            this.Load += new System.EventHandler(this.SetGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBoxCountElements;
        private System.Windows.Forms.Button buttonCreateArray;
        private System.Windows.Forms.Label label2;
    }
}