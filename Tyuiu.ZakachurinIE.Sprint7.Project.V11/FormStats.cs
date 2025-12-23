using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ZakachurinIE.Sprint7.Project.V11.Lib;

namespace Tyuiu.ZakachurinIE.Sprint7.Project.V11
{
    public partial class FormStats : Form

    {
        private DataService _ds;
        public FormStats(DataService ds)
        {
            InitializeComponent();
            _ds = ds;
            DisplayStats();
            LoadCharts();
        }
        DataService ds = new DataService();
        private void DisplayStats()
        {
            textBoxCountOut_ZIE.Text = _ds.GetEmployeeCount().ToString();
            textBoxAvgExpOut_ZIE.Text = $"{_ds.GetAverageExperience():F1} лет";
            textBoxMinExpOut_ZIE.Text = _ds.GetMinExperience().ToString() + " лет";
            textBoxMaxExpOut_ZIE.Text = _ds.GetMaxExperience().ToString() + " лет";
            textBoxAvgAgeOut_ZIE.Text = $"{_ds.GetAverageAge():F1} лет";
        }

        private void LoadCharts()
        {
            var employees = _ds.GetAllEmployees();         
            chartExp_ZIE.Series.Clear();
            Series seriesExp = new Series("Стаж");
            seriesExp.ChartType = SeriesChartType.Column;
            var expGroups = employees.GroupBy(e => e.ExperienceYears).OrderBy(g => g.Key).Select(g => new { Years = g.Key, Count = g.Count() });

            foreach (var group in expGroups)
            {
                seriesExp.Points.AddXY(group.Years, group.Count);
            }
            var positionGroups = employees.GroupBy(e => e.Position).Select(g => new { Position = g.Key, Count = g.Count() }).OrderByDescending(g => g.Count).ToList();
            chartExp_ZIE.Series.Add(seriesExp);

            chartPosition_ZIE.Series.Clear();
            Series seriesPosition = new Series("Должности");
            seriesPosition.ChartType = SeriesChartType.Pie;
            foreach (var group in positionGroups)
            {
                DataPoint point = seriesPosition.Points.Add(group.Count);
                point.AxisLabel = group.Position;
                point.LegendText = $"{group.Position}: {group.Count} чел.";
                point.Label = $"{group.Count}";
            }
            chartPosition_ZIE.Series.Add(seriesPosition);          
        }

    }
}

