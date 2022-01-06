using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doan.Model;
using Doan.View.Suplier;

namespace Doan.Presenter
{
    public class SuplierPresenter
    {
        ISuplier suplierview;
        Suplier suplier = new Suplier();
        public SuplierPresenter(ISuplier view)
        {
            this.suplierview = view;
        }
        public bool GetSuplier()
        {
            DataTable dt = new DataTable();
            dt = suplier.GetSuplierData();
            suplierview.gvData.DataSource = dt;
            return true;
        }
        public bool ClearInformation()
        {
            suplierview.SuplierId = "";
            suplierview.SuplierName = "";
            suplierview.SuplierAddress = "";
            suplierview.SuplierPhone = "";
            suplierview.SuplierEmail = "";
            return true;

        }
        public bool RetriveSuplier(int index, string id, string name, string address, string phone, string email)
        {
            if (index != -1)
            {
                ClearInformation();
                suplierview.SuplierId = id;
                suplierview.SuplierName = name;
                suplierview.SuplierAddress = address;
                suplierview.SuplierPhone = phone;
                suplierview.SuplierEmail = email;

            }
            return true;
        }
        public bool AddData()
        {
            if (suplier.AddSuplier(suplierview.SuplierName, suplierview.SuplierAddress, suplierview.SuplierPhone, suplierview.SuplierEmail))
            {
                suplierview.message = "Add new suplier successfully";
                return true;
            }
            else
            {
                suplierview.message = "Add new suplier fail";
                return false;
            }
        }
        public bool DeleteData()
        {
            if (suplier.DeleteSuplier(suplierview.SuplierId))
            {
                suplierview.message = "Deleted suplier successfully";
                return true;
            }
            else
            {
                suplierview.message = "Deleted suplier fail";
                return false;
            }
        }

        public bool EditData()
        {
            if (suplier.UpdateSuplier(suplierview.SuplierId, suplierview.SuplierName, suplierview.SuplierAddress, suplierview.SuplierPhone, suplierview.SuplierEmail))
            {
                suplierview.message = "Update suplier successfully";
                return true;
            }
            else
            {
                suplierview.message = "Update suplier fail";
                return false;
            }
        }
        public bool CheckInformationEdit()
        {
            if (suplierview.SuplierId == "" ||
            suplierview.SuplierName == "" ||
            suplierview.SuplierAddress == "" ||
            suplierview.SuplierPhone == "" ||
            suplierview.SuplierEmail == "")
                return false;
            else
                return true;
        }
        public bool CheckInformation()
        {
            if (suplierview.SuplierId != "" ||
            suplierview.SuplierName == "" ||
            suplierview.SuplierAddress == "" ||
            suplierview.SuplierPhone == "" ||
            suplierview.SuplierEmail == "")
                return false;
            else
                return true;
        }
    }
}
