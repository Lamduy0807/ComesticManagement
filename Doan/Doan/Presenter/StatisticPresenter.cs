using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public bool GetBillMonth()
        {
            statisticview.BillMonth = statistics.GetNumberOfBillMonth();
            return true;
        }
        public bool GetBillToday()
        {
            statisticview.BillToday = statistics.GetNumberOfBillToday();
            return true;
        }
        public bool GetRevenueMonth()
        {
            float revenue = 0f;
            float r = float.Parse(statistics.GetNumberOfRevuewnueMonth());
            revenue = r;
            statisticview.RevenueMonth = revenue.ToString("###,###");
            return true;
        }
        public bool GetRevenueToday()
        {
            float revenue = 0f;
            float r = float.Parse(statistics.GetNumberOfRevuenueToday());
            revenue = r;
            statisticview.RevenueToday = revenue.ToString("###,###");
            return true;
        }
        public bool GetTopProduct()
        {
            DataTable dt = new DataTable();
            dt = statistics.GetTop10ProductData();
            statisticview.gvBestSeller.DataSource = dt;
            return true;
        }
    }
}
