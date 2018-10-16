using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Home_Bookkeeper
{
    public partial class Analyze : Form
    {
        public Analyze()
        {
            Dictionary<string, double> chartsource = new Dictionary<string, double>();
            Dictionary<string, double> temp = new Dictionary<string, double>();
            double incomes = 0, extenses = 0;

            InitializeComponent();

            foreach (Finances.Category category in DataBase.PersonalAccount.Categories)
            {
                if (Convert.ToDouble(category.GetIncome) != 0)
                {
                    if (chartsource.ContainsKey(category.Name))
                        chartsource[category.Name] += Convert.ToDouble(category.GetIncome);
                    else
                        chartsource.Add(category.Name, Convert.ToDouble(category.GetIncome));
                    incomes += Convert.ToDouble(category.GetIncome);
                }
            }
            for (int i = 0; i < chartsource.Count; i++)
            {
                temp.Add(chartsource.ElementAt(i).Key + " " + chartsource.ElementAt(i).Value.ToString(), chartsource.ElementAt(i).Value);
            }
            chartsource = temp;

            Income.Series.Clear();
            Income.Series.Add("Income");
            Income.Series["Income"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            Income.Series["Income"].Points.DataBindXY(chartsource.Keys, chartsource.Values);

            chartsource = new Dictionary<string, double>();
            temp = new Dictionary<string, double>();

            foreach (Finances.Category category in DataBase.PersonalAccount.Categories)
            {
                if (Convert.ToDouble(category.GetExtense) != 0)
                {
                    if (chartsource.ContainsKey(category.Name))
                        chartsource[category.Name] += Convert.ToDouble(category.GetExtense);
                    else
                        chartsource.Add(category.Name, Convert.ToDouble(category.GetExtense));
                    extenses += Convert.ToDouble(category.GetExtense);
                }
            }

            for (int i = 0; i < chartsource.Count; i++)
            {
                temp.Add(chartsource.ElementAt(i).Key + " " + chartsource.ElementAt(i).Value.ToString(), chartsource.ElementAt(i).Value);
            }
            chartsource = temp;

            Extense.Series.Clear();
            Extense.Series.Add("Extense");
            Extense.Series["Extense"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            Extense.Series["Extense"].Points.DataBindXY(chartsource.Keys, chartsource.Values);

            Incomes.Text = "Доходы (" + incomes.ToString() + ")";
            Extenses.Text = "Расходы (" + extenses.ToString() + ")";
        }
    }
}
