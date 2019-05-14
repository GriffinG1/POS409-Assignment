using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Objects
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string empType;

        public Employee() { }

        public string GetName()
        {
            return $"{firstName} {lastName}";
        }

        public string GetAddress()
        {
            return $"{address}, {city}, {state}, {zipCode}";
        }

        public string GetEmpType()
        {
            return empType;
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

        public void SetEmpType(string empType)
        {
            this.empType = empType;
        }
    }
}
