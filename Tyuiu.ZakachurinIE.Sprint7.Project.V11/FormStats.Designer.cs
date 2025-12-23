namespace Tyuiu.ZakachurinIE.Sprint7.Project.V11
{
    partial class FormStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxStats_ZIE = new GroupBox();
            textBoxAvgAgeOut_ZIE = new TextBox();
            labelAvgAge_ZIE = new Label();
            textBoxMaxExpOut_ZIE = new TextBox();
            labelMaxExp_ZIE = new Label();
            textBoxMinExpOut_ZIE = new TextBox();
            labelMinExp_ZIE = new Label();
            textBoxAvgExpOut_ZIE = new TextBox();
            labelAvgExp_ZIE = new Label();
            textBoxCountOut_ZIE = new TextBox();
            labelCount_ZIE = new Label();
            groupBoxChart_ZIE = new GroupBox();
            chartExp_ZIE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartPosition_ZIE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxStats_ZIE.SuspendLayout();
            groupBoxChart_ZIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartExp_ZIE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPosition_ZIE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxStats_ZIE
            // 
            groupBoxStats_ZIE.AutoSize = true;
            groupBoxStats_ZIE.Controls.Add(textBoxAvgAgeOut_ZIE);
            groupBoxStats_ZIE.Controls.Add(labelAvgAge_ZIE);
            groupBoxStats_ZIE.Controls.Add(textBoxMaxExpOut_ZIE);
            groupBoxStats_ZIE.Controls.Add(labelMaxExp_ZIE);
            groupBoxStats_ZIE.Controls.Add(textBoxMinExpOut_ZIE);
            groupBoxStats_ZIE.Controls.Add(labelMinExp_ZIE);
            groupBoxStats_ZIE.Controls.Add(textBoxAvgExpOut_ZIE);
            groupBoxStats_ZIE.Controls.Add(labelAvgExp_ZIE);
            groupBoxStats_ZIE.Controls.Add(textBoxCountOut_ZIE);
            groupBoxStats_ZIE.Controls.Add(labelCount_ZIE);
            groupBoxStats_ZIE.Dock = DockStyle.Left;
            groupBoxStats_ZIE.Location = new Point(0, 0);
            groupBoxStats_ZIE.Name = "groupBoxStats_ZIE";
            groupBoxStats_ZIE.Size = new Size(266, 450);
            groupBoxStats_ZIE.TabIndex = 0;
            groupBoxStats_ZIE.TabStop = false;
            groupBoxStats_ZIE.Text = "Числовая статистика";
            // 
            // textBoxAvgAgeOut_ZIE
            // 
            textBoxAvgAgeOut_ZIE.Location = new Point(160, 138);
            textBoxAvgAgeOut_ZIE.Name = "textBoxAvgAgeOut_ZIE";
            textBoxAvgAgeOut_ZIE.ReadOnly = true;
            textBoxAvgAgeOut_ZIE.Size = new Size(100, 23);
            textBoxAvgAgeOut_ZIE.TabIndex = 1;
            // 
            // labelAvgAge_ZIE
            // 
            labelAvgAge_ZIE.AutoSize = true;
            labelAvgAge_ZIE.Location = new Point(9, 141);
            labelAvgAge_ZIE.Name = "labelAvgAge_ZIE";
            labelAvgAge_ZIE.Size = new Size(103, 15);
            labelAvgAge_ZIE.TabIndex = 0;
            labelAvgAge_ZIE.Text = "Средний возраст:";
            // 
            // textBoxMaxExpOut_ZIE
            // 
            textBoxMaxExpOut_ZIE.Location = new Point(160, 109);
            textBoxMaxExpOut_ZIE.Name = "textBoxMaxExpOut_ZIE";
            textBoxMaxExpOut_ZIE.ReadOnly = true;
            textBoxMaxExpOut_ZIE.Size = new Size(100, 23);
            textBoxMaxExpOut_ZIE.TabIndex = 1;
            // 
            // labelMaxExp_ZIE
            // 
            labelMaxExp_ZIE.AutoSize = true;
            labelMaxExp_ZIE.Location = new Point(9, 112);
            labelMaxExp_ZIE.Name = "labelMaxExp_ZIE";
            labelMaxExp_ZIE.Size = new Size(126, 15);
            labelMaxExp_ZIE.TabIndex = 0;
            labelMaxExp_ZIE.Text = "Максимальный стаж:";
            // 
            // textBoxMinExpOut_ZIE
            // 
            textBoxMinExpOut_ZIE.Location = new Point(160, 80);
            textBoxMinExpOut_ZIE.Name = "textBoxMinExpOut_ZIE";
            textBoxMinExpOut_ZIE.ReadOnly = true;
            textBoxMinExpOut_ZIE.Size = new Size(100, 23);
            textBoxMinExpOut_ZIE.TabIndex = 1;
            // 
            // labelMinExp_ZIE
            // 
            labelMinExp_ZIE.AutoSize = true;
            labelMinExp_ZIE.Location = new Point(9, 83);
            labelMinExp_ZIE.Name = "labelMinExp_ZIE";
            labelMinExp_ZIE.Size = new Size(122, 30);
            labelMinExp_ZIE.TabIndex = 0;
            labelMinExp_ZIE.Text = "Минимальный стаж:\r\n\r\n";
            // 
            // textBoxAvgExpOut_ZIE
            // 
            textBoxAvgExpOut_ZIE.Location = new Point(160, 51);
            textBoxAvgExpOut_ZIE.Name = "textBoxAvgExpOut_ZIE";
            textBoxAvgExpOut_ZIE.ReadOnly = true;
            textBoxAvgExpOut_ZIE.Size = new Size(100, 23);
            textBoxAvgExpOut_ZIE.TabIndex = 1;
            // 
            // labelAvgExp_ZIE
            // 
            labelAvgExp_ZIE.AutoSize = true;
            labelAvgExp_ZIE.Location = new Point(9, 54);
            labelAvgExp_ZIE.Name = "labelAvgExp_ZIE";
            labelAvgExp_ZIE.Size = new Size(87, 15);
            labelAvgExp_ZIE.TabIndex = 0;
            labelAvgExp_ZIE.Text = "Средний стаж:";
            // 
            // textBoxCountOut_ZIE
            // 
            textBoxCountOut_ZIE.Location = new Point(160, 22);
            textBoxCountOut_ZIE.Name = "textBoxCountOut_ZIE";
            textBoxCountOut_ZIE.ReadOnly = true;
            textBoxCountOut_ZIE.Size = new Size(100, 23);
            textBoxCountOut_ZIE.TabIndex = 1;
            // 
            // labelCount_ZIE
            // 
            labelCount_ZIE.AutoSize = true;
            labelCount_ZIE.Location = new Point(9, 25);
            labelCount_ZIE.Name = "labelCount_ZIE";
            labelCount_ZIE.Size = new Size(148, 15);
            labelCount_ZIE.TabIndex = 0;
            labelCount_ZIE.Text = "Количество сотрудников:";
            // 
            // groupBoxChart_ZIE
            // 
            groupBoxChart_ZIE.AutoSize = true;
            groupBoxChart_ZIE.Controls.Add(chartExp_ZIE);
            groupBoxChart_ZIE.Controls.Add(chartPosition_ZIE);
            groupBoxChart_ZIE.Dock = DockStyle.Fill;
            groupBoxChart_ZIE.Location = new Point(266, 0);
            groupBoxChart_ZIE.Name = "groupBoxChart_ZIE";
            groupBoxChart_ZIE.Size = new Size(534, 450);
            groupBoxChart_ZIE.TabIndex = 1;
            groupBoxChart_ZIE.TabStop = false;
            groupBoxChart_ZIE.Text = "Диаграммы";
            // 
            // chartExp_ZIE
            // 
            chartArea1.Name = "ChartArea1";
            chartExp_ZIE.ChartAreas.Add(chartArea1);
            chartExp_ZIE.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartExp_ZIE.Legends.Add(legend1);
            chartExp_ZIE.Location = new Point(3, 19);
            chartExp_ZIE.Name = "chartExp_ZIE";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartExp_ZIE.Series.Add(series1);
            chartExp_ZIE.Size = new Size(325, 428);
            chartExp_ZIE.TabIndex = 1;
            chartExp_ZIE.Text = "chart2";
            // 
            // chartPosition_ZIE
            // 
            chartArea2.Name = "ChartArea1";
            chartPosition_ZIE.ChartAreas.Add(chartArea2);
            chartPosition_ZIE.Dock = DockStyle.Right;
            legend2.Name = "Legend1";
            chartPosition_ZIE.Legends.Add(legend2);
            chartPosition_ZIE.Location = new Point(328, 19);
            chartPosition_ZIE.Name = "chartPosition_ZIE";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartPosition_ZIE.Series.Add(series2);
            chartPosition_ZIE.Size = new Size(203, 428);
            chartPosition_ZIE.TabIndex = 0;
            chartPosition_ZIE.Text = "chart1";
            // 
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxChart_ZIE);
            Controls.Add(groupBoxStats_ZIE);
            Name = "FormStats";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            groupBoxStats_ZIE.ResumeLayout(false);
            groupBoxStats_ZIE.PerformLayout();
            groupBoxChart_ZIE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartExp_ZIE).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPosition_ZIE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxStats_ZIE;
        private Label labelCount_ZIE;
        private GroupBox groupBoxChart_ZIE;
        private TextBox textBoxAvgAgeOut_ZIE;
        private Label labelAvgAge_ZIE;
        private TextBox textBoxMaxExpOut_ZIE;
        private Label labelMaxExp_ZIE;
        private TextBox textBoxMinExpOut_ZIE;
        private Label labelMinExp_ZIE;
        private TextBox textBoxAvgExpOut_ZIE;
        private Label labelAvgExp_ZIE;
        private TextBox textBoxCountOut_ZIE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExp_ZIE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPosition_ZIE;
    }
}