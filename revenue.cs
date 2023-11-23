using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Project
{
    public partial class revenue : Form
    {
        public revenue()
        {
            InitializeComponent();
        }

        Func<ChartPoint, string> labelpoint = chartpoint => string.Format("{0}({1:P})", chartpoint.Y, chartpoint.Participation);

        private void button1_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in dataSet1.Revenue)
                series.Add(new PieSeries() { Title = obj.Year.ToString(), Values = new ChartValues<int> { obj.Total }, DataLabels = true, LabelPoint = labelpoint });
            pieChart1.Series = series;
        }
        

        private void revenue_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Seller().Show();
        }
    }
}
