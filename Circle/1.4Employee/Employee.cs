using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4Employee
{
    class Employee
    {
        private int ID;
        private String FirstName;
        private String LastName;
        private int Salary;

        public Employee(int ID , int Salary , String FirstName , String LastName)
        {
            this.ID = ID;
            this.Salary = Salary;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public int getID()
        {
            return ID;
        }
        public string getFirstName()
        {
            return FirstName;
        }
        public string getLastName()
        {
            return LastName;
        }
        public string getName()
        {
            return FirstName + LastName;
        }
        public int getSalary()
        {
            return Salary;
        }
        public void setSalary()
        {
            this.Salary = Salary;
        }
        public int getAnnualSalary()
        {
            return Salary * 12;
        }
        public int raiseSalary( int percent)
        {
            int a = Salary;
            a = Salary + Salary * 5 / 100;
            return a;
        }
        public override string ToString()
        {
            return "Employee[ID=" + ID + "], " + "Name = " + FirstName + " " + LastName + "salary = " + Salary;
        }

    }
}
