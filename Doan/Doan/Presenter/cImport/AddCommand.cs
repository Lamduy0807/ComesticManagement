using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doan.Model;
using Doan.View.Import;

namespace Doan.Presenter.cImport
{
    public class AddCommand : Command
    {
        private ImportPresenter import;

        public AddCommand(ImportPresenter i)
        {
            this.import = i;
        }
        public override bool Execute()
        {
            if( import.AddDataToDataGridview())
            {
                import.CalculateTotalPrice();
                import.ClearInformation();
                return true;
            }
            return false;
        }
    }
}
