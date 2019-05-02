using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record_Objects
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zipCode;

        public Employee() { }

        public string GetName()
        {
            return $"{firstName} {lastName}";
        }

        public string GetAddress()
        {
            return $"{address}, {city}, {state}, {zipCode}";
        }

        public void SetName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void SetAddress(string address, string city, string state, string zipCode)
        {
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
        }
    }

    class Manager : Employee
    {
        private string costCenter;
        private string supervisor;

        public string GetCostCenter()
        {
            return costCenter;
        }

        public string GetSupervisor()
        {
            return supervisor;
        }

        public string GetDevType()
        {
            return "N/A";
        }

        public string GetTaxType()
        {
            return "N/A";
        }

        public void SetCostCenter(string costCenter)
        {
            this.costCenter = costCenter;
        }

        public void SetSupervisor(string supervisor)
        {
            this.supervisor = supervisor;
        }
    }

    class Developer : Employee
    {
        private string developerType;
        private string supervisor;
        private string taxType;

        public string GetDevType()
        {
            return developerType;
        }

        public string GetSupervisor()
        {
            return supervisor;
        }

        public string GetTaxType()
        {
            return taxType;
        }

        public string GetCostCenter()
        {
            return "0";
        }

        public void SetDevType(string developerType)
        {
            this.developerType = developerType;
        }

        public void SetSupervisor(string supervisor)
        {
            this.supervisor = supervisor;
        }

        public void SetTaxType(string taxType)
        {
            this.taxType = taxType;
        }
    }
}
