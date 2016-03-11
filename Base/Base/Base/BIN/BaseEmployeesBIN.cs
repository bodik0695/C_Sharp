using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base
{
    public class BaseEmployeesBIN : IBaseEmployeesBIN
    {
        public IEmployee[] AllEmployees { get; set; }
        public ICreateEmployerRecordWithBIN Create { get; set; }
        public IRemoveEmployeeRecordWithBIN Remove { get; set; }
        public IViewAllEmployeeRecordsWithBIN ViewAll { get; set; }
        public IViewRecordSpecificEmployeeBIN ViewSpec { get; set; }

        public BaseEmployeesBIN()
        { }
        public BaseEmployeesBIN(ICreateEmployerRecordWithBIN create, IRemoveEmployeeRecordWithBIN remove, IViewAllEmployeeRecordsWithBIN viewAll, IViewRecordSpecificEmployeeBIN viewSpe)
        {
            Create = create;
            Remove = remove;
            ViewAll = viewAll;
            ViewSpec = viewSpe;
        }
    }
}