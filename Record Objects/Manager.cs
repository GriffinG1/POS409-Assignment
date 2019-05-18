using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Objects
{
    public class Manager : Employee
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

        public void SetCostCenter(string costCenter)
        {
            this.costCenter = costCenter;
        }

        public void SetSupervisor(string supervisor)
        {
            this.supervisor = supervisor;
        }
    }
}
