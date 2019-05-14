using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Objects
{
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
