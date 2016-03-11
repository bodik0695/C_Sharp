using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Base
{
    public class CreateEmployerRecordBIN : ICreateEmployerRecordWithBIN
    {
        public CreateEmployerRecordBIN()
        { }

        public virtual void CreateEmpRecordBIN(BinaryFormatter bf, Employee[] people)
        {
            FileStream fs = new FileStream("baseEmployees.dat", FileMode.OpenOrCreate);
            if (fs.Length > 141)
            {
                Employee[] currentPeople = (Employee[])bf.Deserialize(fs);
                fs.Close();
                fs = new FileStream("baseEmployees.dat", FileMode.Create);
                using (fs)
                {
                    if (currentPeople.Length == 0)
                    {
                        bf.Serialize(fs, people);
                        fs.Close();
                    }
                    else
                    {
                        for (int z = 0; z < currentPeople.Length; z++)
                        {
                            if (people.Length > 1)
                            {
                                if (currentPeople[z].Name != people[people.Length - 1].Name && currentPeople[z].Surname != people[people.Length - 1].Surname && currentPeople[z].Patronymic != people[people.Length - 1].Patronymic)
                                {
                                    bf.Serialize(fs, people);
                                    fs.Close();
                                }
                                else
                                {
                                    bf.Serialize(fs, currentPeople);
                                    fs.Close();
                                }
                            }
                            else
                            {
                                bf.Serialize(fs, people);
                                fs.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                if (people.Length != 0)
                {
                    fs.Close();
                    FileStream fs1 = new FileStream("baseEmployees.dat", FileMode.Create);
                    using (fs1)
                    {
                        bf.Serialize(fs1, people);
                        fs1.Close();
                    }
                }
            }
            fs.Close();
        }
    }
}
