using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_methods
{
    internal class Employee
    {
        public int id;
        public string name;
        public string surname;
        public string address;
        public string email;
        public int age;


        public string getFullData()
        {
            return $"{id} - {name} - {surname} - {address} - {email} - {age}";
        }

    }

}