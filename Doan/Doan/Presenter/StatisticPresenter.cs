using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using Doan.Model;
using Doan.View.Statistic;

namespace Doan.Presenter
{
    public class StatisticPresenter
    {
        IStatistics statisticview;
        Model.Statistics statistics = new Model.Statistics();
        public StatisticPresenter(IStatistics i)
        {
            this.statisticview = i;
        }
        public bool GetBillMonth(string month, string year)
        {
            statisticview.BillMonth = statistics.GetNumberOfBillMonth(month, year);
            return true;
        }
        public bool GetBillToday(string day,string month, string year)
        {
            statisticview.BillToday = statistics.GetNumberOfBillToday(day, month, year);
            return true;
        }
        public bool GetRevenueMonth(string month, string year)
        {
            if (!String.IsNullOrEmpty(statistics.GetNumberOfRevuewnueMonth(month, year)))
            {
                float revenue = 0f;
                float r = float.Parse(statistics.GetNumberOfRevuewnueMonth(month, year));
                revenue = r;
                statisticview.RevenueMonth = revenue.ToString("###,###");
                return true;
            }
            else
            {
                statisticview.RevenueMonth = "0";
                return true;
            }
            //float revenue = 0f;
            //float r = float.Parse(statistics.GetNumberOfRevuewnueMonth());
            //revenue = r;
            //statisticview.RevenueMonth = revenue.ToString("###,###");
            //return true;
        }
        public bool GetRevenueToday(string day, string month, string year)
        {
            string test = statistics.GetNumberOfRevuenueToday(day,month, year);
            if (!String.IsNullOrEmpty(statistics.GetNumberOfRevuenueToday(day, month, year)))
            {
                float revenue = 0f;
                float r = float.Parse(statistics.GetNumberOfRevuenueToday(day, month, year));
                revenue = r;
                statisticview.RevenueToday = revenue.ToString("###,###");
                return true;
            }
            else
            {
                statisticview.RevenueToday = "0";
                return true;
            }
        }
        public bool GetTopProduct()
        {
            DataTable dt = new DataTable();
            dt = statistics.GetTop10ProductData();
            statisticview.gvBestSeller.DataSource = dt;
            return true;
        }
        public bool GetLineChart(string month, string year)
        {
            statisticview.data = statistics.GetChartData(month, year);
            return true;
        }
        public bool RetriveData()
        {
            string date = statisticview.Date;
            string[] arrayDate = date.Split('-');
            GetBillMonth(arrayDate[1], arrayDate[2]);
            GetBillToday(arrayDate[0], arrayDate[1], arrayDate[2]);
            GetRevenueMonth(arrayDate[1], arrayDate[2]);
            GetRevenueToday(arrayDate[0],arrayDate[1], arrayDate[2]);
            GetLineChart(arrayDate[1], arrayDate[2]);
            return true;
        }
    }
}
