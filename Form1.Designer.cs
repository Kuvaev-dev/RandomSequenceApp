namespace RandomSequenceApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstOriginalData = new System.Windows.Forms.ListBox();
            this.lstSortedData = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDistribution = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCumulativeFrequency = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstRelativeFrequency = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(6, 19);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(315, 20);
            this.txtStudentNumber.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.Location = new System.Drawing.Point(340, 16);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(143, 24);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Згенерувати";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вихідні дані";
            // 
            // lstOriginalData
            // 
            this.lstOriginalData.FormattingEnabled = true;
            this.lstOriginalData.Location = new System.Drawing.Point(22, 39);
            this.lstOriginalData.Name = "lstOriginalData";
            this.lstOriginalData.Size = new System.Drawing.Size(120, 134);
            this.lstOriginalData.TabIndex = 4;
            // 
            // lstSortedData
            // 
            this.lstSortedData.FormattingEnabled = true;
            this.lstSortedData.Location = new System.Drawing.Point(181, 39);
            this.lstSortedData.Name = "lstSortedData";
            this.lstSortedData.Size = new System.Drawing.Size(120, 134);
            this.lstSortedData.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Варіаційний ряд";
            // 
            // lstDistribution
            // 
            this.lstDistribution.FormattingEnabled = true;
            this.lstDistribution.Location = new System.Drawing.Point(341, 39);
            this.lstDistribution.Name = "lstDistribution";
            this.lstDistribution.Size = new System.Drawing.Size(120, 134);
            this.lstDistribution.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Статистичний розподіл";
            // 
            // lstCumulativeFrequency
            // 
            this.lstCumulativeFrequency.FormattingEnabled = true;
            this.lstCumulativeFrequency.Location = new System.Drawing.Point(22, 217);
            this.lstCumulativeFrequency.Name = "lstCumulativeFrequency";
            this.lstCumulativeFrequency.Size = new System.Drawing.Size(202, 134);
            this.lstCumulativeFrequency.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Інтегральна частота";
            // 
            // lstRelativeFrequency
            // 
            this.lstRelativeFrequency.FormattingEnabled = true;
            this.lstRelativeFrequency.Location = new System.Drawing.Point(261, 217);
            this.lstRelativeFrequency.Name = "lstRelativeFrequency";
            this.lstRelativeFrequency.Size = new System.Drawing.Size(200, 134);
            this.lstRelativeFrequency.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Частота";
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveResults.Location = new System.Drawing.Point(171, 564);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(136, 23);
            this.btnSaveResults.TabIndex = 13;
            this.btnSaveResults.Text = "Зберегти";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStudentNumber);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 48);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введіть номер студента";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chartDistribution);
            this.groupBox2.Controls.Add(this.lstOriginalData);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSaveResults);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lstRelativeFrequency);
            this.groupBox2.Controls.Add(this.lstSortedData);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lstCumulativeFrequency);
            this.groupBox2.Controls.Add(this.lstDistribution);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(32, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 603);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результати";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Полігон розподілу на відносної частоти";
            // 
            // chartDistribution
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDistribution.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDistribution.Legends.Add(legend1);
            this.chartDistribution.Location = new System.Drawing.Point(22, 381);
            this.chartDistribution.Name = "chartDistribution";
            this.chartDistribution.Size = new System.Drawing.Size(439, 168);
            this.chartDistribution.TabIndex = 16;
            this.chartDistribution.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(554, 716);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 755);
            this.MinimumSize = new System.Drawing.Size(570, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Sequence App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstOriginalData;
        private System.Windows.Forms.ListBox lstSortedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDistribution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCumulativeFrequency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstRelativeFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistribution;
        private System.Windows.Forms.Label label1;
    }
}

