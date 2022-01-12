using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doan.View.Import;

namespace Doan.Presenter.cImport
{
    public class DeleteCommand : Command
    {
        private ImportPresenter import;
        public DeleteCommand(ImportPresenter i)
        {
            this.import = i;
        }
        public override bool Execute()
        {
            import.DeleteDatainDataGridview();
            import.ClearInformation();
            import.CalculateTotalPrice();
            return true;
        }
    }
}
