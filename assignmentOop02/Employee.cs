using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop02
{
    internal class Employee
    {
        #region attr
        private string gender; 
        #endregion

        #region properties
        public int ID { get; set; }
        public string Name { get; set; }
        //public int SecurityLevel { get; set; }
        public securityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
       // public DateTime HireDate { get; set; }
        public HiringDate HireDate { get; set; }
        //public string Gender { get; set; } 
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "m" || value == "f")
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("gender must be either 'm' male or 'f' female");
                }
            }
        }
        #endregion

        #region constructor
        public Employee(int id, string name, securityLevel securityLevel, decimal salary, HiringDate hireDate, string gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        #endregion

        #region method
        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSecurity Level: {SecurityLevel}\nSalary: {String.Format("{0:C}", Salary)}\nHire Date: {HireDate}\nGender: {Gender}";
        }
        #endregion
    }   


}   

