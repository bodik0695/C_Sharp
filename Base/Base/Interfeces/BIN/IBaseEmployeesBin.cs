using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base
{
    public interface IBaseEmployeesBIN
    {
        IEmployee[] AllEmployees { get; set; }
        ICreateEmployerRecordWithBIN Create { get; set; }
        IRemoveEmployeeRecordWithBIN Remove { get; set; }
        IViewAllEmployeeRecordsWithBIN ViewAll { get; set; }
        IViewRecordSpecificEmployeeBIN ViewSpec { get; set; }
    }
}