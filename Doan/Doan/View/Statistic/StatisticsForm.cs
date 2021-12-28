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
using Doan.Presenter;

namespace Doan.View.Statistic
{
    public partial class StatisticsForm : Form, IStatistics
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        public string Date
        {
            get { return dateTimePicker1.Text.ToString(); }
            set { dateTimePicker1.Text = value; }
        }
        public string RevenueMonth
        {
            get { return lbRevenueThisMonth.Text; }
            set { lbRevenueThisMonth.Text = value; }
        }
        public string RevenueToday
        {
            get { return lbRevenueToday.Text; }
            set { lbRevenueToday.Text = value; }
        }
        public string SumProduct
        {
            get { return lbSumProduct.Text; }
            set { lbSumProduct.Text = value; }
        }
        public string BillMonth
        {
            get { return lbBillThisMonth.Text; }
            set { lbBillThisMonth.Text = value; }
        }
        public string BillToday
        {
            get { return lbBillToday.Text; }
            set { lbBillToday.Text = value; }
        }
        public DataGridView gvBestSeller
        {
            get { return dtgvBestSeller; }
            set { dtgvBestSeller = value; }
        }

        
        private DataTable _data;
        public DataTable data { set { _data = value; } }

        private void Statistics_Load(object sender, EventArgs e)
        {
            StatisticPresenter statisticPresenter = new StatisticPresenter(this);
            string sDay = DateTime.Now.ToString("dd");
            string sMonth = DateTime.Now.ToString("MM");
            string sYear = DateTime.Now.ToString("yyyy");
            statisticPresenter.GetBillMonth(sMonth,sYear);
            statisticPresenter.GetBillToday(sDay,sMonth,sYear);
            statisticPresenter.GetRevenueMonth(sMonth,sYear);
            statisticPresenter.GetRevenueToday(sDay, sMonth, sYear);
            statisticPresenter.GetTopProduct();
            statisticPresenter.GetLineChart(sMonth,sYear);
            ChartMoneydaybydate();
        }
        private void ChartMoneydaybydate()
        {
            //chart1.Series["Revenue"].ChartType = SeriesChartType.Line;
            chart1.Series["Revenue"].XValueType = ChartValueType.DateTime;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd";
;
            chart1.DataSource = _data; 
            chart1.Series["Revenue"].XValueMember = "Ngay";
            chart1.Series["Revenue"].YValueMembers = "Tong";
            chart1.Series["Revenue"].IsValueShownAsLabel = true;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            StatisticPresenter statisticPresenter = new StatisticPresenter(this);
            statisticPresenter.RetriveData();
            ChartMoneydaybydate();
        }
    }
}
