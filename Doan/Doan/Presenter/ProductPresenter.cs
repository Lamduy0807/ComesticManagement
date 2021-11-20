using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doan.Model;
using Doan.View.Product;

namespace Doan.Presenter
{
    public class ProductPresenter
    {
        IProduct productview;
        Product product = new Product();


        public ProductPresenter(IProduct view)
        {
            productview = view;
        }
        public bool GetProductType()
        {
            foreach (string item in product.GetProductType())
            {
                productview.cbData.Add(item);
            }
            return true;
        }

        public bool GetProduct()
        {
            DataTable dt = new DataTable();
            dt = product.GetProductData();
            productview.gvData.DataSource = dt;
            return true;
        }
        public bool ClearInformation()
        {
            productview.ProductID = "";
            productview.ProductName = "";
            productview.ProductType = "";
            productview.Price = "";
            productview.Description = "";
            productview.Original = "";
            productview.Unit = "";
            return true;

        }
        public bool RetriveProduct(int index, string id, string name, string pri, string des, string ori, string unit, string type)
        {
            if (index != -1)
            {
                ClearInformation();
                productview.ProductID = id;
                productview.ProductName = name;
                productview.ProductType = "Test";
                productview.Price = pri;
                productview.Description = des;
                productview.Original = ori;
                productview.Unit = unit;
            }
            return true;
        }

        public bool AddData()
        {
            if (product.AddProduct(productview.ProductName, productview.Price, productview.Description, productview.Original, productview.Unit, productview.ProductType))
            {
                productview.message = "add thành công";
                return true;
            }
            else
            {
                productview.message = "Add không thành công";
                return false;
            }
        }
    }
}
