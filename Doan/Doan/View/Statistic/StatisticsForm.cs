using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void Statistics_Load(object sender, EventArgs e)
        {
            StatisticPresenter statisticPresenter = new StatisticPresenter(this);
            statisticPresenter.GetBillMonth();
            statisticPresenter.GetBillToday();
            statisticPresenter.GetRevenueMonth();
            statisticPresenter.GetRevenueToday();
            statisticPresenter.GetTopProduct();
        }
    }
}
