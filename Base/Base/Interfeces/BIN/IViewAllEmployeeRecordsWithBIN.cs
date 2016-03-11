using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Base
{
    public interface IViewAllEmployeeRecordsWithBIN
    {
        void ViewAllEmpRecordsBIN(BinaryFormatter bf);
    }
}