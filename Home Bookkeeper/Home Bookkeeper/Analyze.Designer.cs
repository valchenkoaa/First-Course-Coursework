namespace Home_Bookkeeper
{
    partial class Analyze
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Income = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Extense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Incomes = new System.Windows.Forms.Label();
            this.Extenses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Income)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Extense)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Home_Bookkeeper.Finances.Category);
            // 
            // Income
            // 
            chartArea3.Name = "ChartArea1";
            this.Income.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Income.Legends.Add(legend3);
            this.Income.Location = new System.Drawing.Point(13, 31);
            this.Income.Name = "Income";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Income.Series.Add(series3);
            this.Income.Size = new System.Drawing.Size(391, 375);
            this.Income.TabIndex = 0;
            this.Income.Text = "chart1";
            // 
            // Extense
            // 
            chartArea4.Name = "ChartArea1";
            this.Extense.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Extense.Legends.Add(legend4);
            this.Extense.Location = new System.Drawing.Point(410, 31);
            this.Extense.Name = "Extense";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.Extense.Series.Add(series4);
            this.Extense.Size = new System.Drawing.Size(391, 375);
            this.Extense.TabIndex = 1;
            this.Extense.Text = "chart2";
            // 
            // Incomes
            // 
            this.Incomes.AutoSize = true;
            this.Incomes.Location = new System.Drawing.Point(171, 12);
            this.Incomes.Name = "Incomes";
            this.Incomes.Size = new System.Drawing.Size(47, 13);
            this.Incomes.TabIndex = 2;
            this.Incomes.Text = "Доходы";
            // 
            // Extenses
            // 
            this.Extenses.AutoSize = true;
            this.Extenses.Location = new System.Drawing.Point(590, 12);
            this.Extenses.Name = "Extenses";
            this.Extenses.Size = new System.Drawing.Size(51, 13);
            this.Extenses.TabIndex = 3;
            this.Extenses.Text = "Расходы";
            // 
            // Analyze
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(813, 418);
            this.Controls.Add(this.Extenses);
            this.Controls.Add(this.Incomes);
            this.Controls.Add(this.Extense);
            this.Controls.Add(this.Income);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Analyze";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyze";
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Income)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Extense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart Income;
        private System.Windows.Forms.DataVisualization.Charting.Chart Extense;
        private System.Windows.Forms.Label Incomes;
        private System.Windows.Forms.Label Extenses;
    }
}