using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doan.View.Import;

namespace Doan.Presenter.cImport
{
    public class Invorker
    {
        private Command add;
        private Command delete;
        private Command cancel;
        private Command edit;
        public Invorker (Command AC, Command DC, Command CC, Command EC)
        {
            this.add = AC;
            this.delete = DC;
            this.cancel = CC;
            this.edit = EC;
        }
        public void AddData()
        {
            add.Execute();
        }
        public void DeleteData()
        {
            delete.Execute();
        }
        public void EditData()
        {
            edit.Execute();
        }
        public void CancelData()
        {
            cancel.Execute();
        }
    }
}
