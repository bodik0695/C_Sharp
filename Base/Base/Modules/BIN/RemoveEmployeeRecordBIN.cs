using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Base
{
    public class RemoveEmployeeRecordBIN : IRemoveEmployeeRecordWithBIN
    {
        public RemoveEmployeeRecordBIN()
        { }

        public virtual void RemoveEmpRecordBIN(string name, string surname, BinaryFormatter bf)
        {
            FileStream fs = new FileStream("baseEmployees.dat", FileMode.OpenOrCreate);
            Employee[] remPeople = (Employee[])bf.Deserialize(fs);
            using (fs)
            {
                List<Employee> allPeople = remPeople.ToList<Employee>();
                int counter = 0;
                foreach (Employee p in allPeople)
                {
                    if (p.Name == name && p.Surname == surname)
                    {

                        allPeople.RemoveAt(counter);
                        remPeople = allPeople.ToArray<Employee>();
                        break;
                    }
                    counter++;
                }
            }
            fs.Close();
            fs = new FileStream("baseEmployees.dat", FileMode.Create);
            using (fs)
            {
                bf.Serialize(fs, remPeople);
                fs.Close();
            }
        }
    }
}