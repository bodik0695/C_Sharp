﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Base
{
    public class ViewAllEmployeeRecordsBIN : IViewAllEmployeeRecordsWithBIN
    {
        public ViewAllEmployeeRecordsBIN()
        { }
        public virtual void ViewAllEmpRecordsBIN(BinaryFormatter bf)
        {
            FileStream fs = new FileStream("baseEmployees.dat", FileMode.OpenOrCreate);
            Employee[] newPeople = (Employee[])bf.Deserialize(fs);
            using (fs)
            {
                List<Employee> allPeople = newPeople.ToList<Employee>();
                int counter = 0;
                foreach (Employee p in allPeople)
                {
                    Console.WriteLine("Пользователь найден:");
                    Console.WriteLine("Фамилия: " + allPeople[counter].Surname + "\r\nИмя: " + allPeople[counter].Name + "\r\nОтчество: " + allPeople[counter].Patronymic + "\r\nВозраст: " + allPeople[counter].Age + "\r\nДолжность: " + allPeople[counter].Position + "\r\nМобильный телефон: " + allPeople[counter].MobilePhoneNumber + "\r\nEmail: " + allPeople[counter].Email);
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            fs.Close();
        }
    }
}