using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record_Objects
{
    public partial class Form2 : Form
    {
        private List<Developer> devs;
        private List<Manager> mgrs;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Developer> devs, List<Manager> mgrs)
        {
            this.devs = devs;
            this.mgrs = mgrs;
            InitializeComponent();
            UpdateArr();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void UpdateArr() // Clears and adds objects to the Data Grid
        {
            /*while (dataArr.Rows.Count > 0) // Clears rows
            {
                foreach (DataGridViewRow row in dataArr.Rows)
                {
                    dataArr.Rows.Remove(row);
                }
            } */
            foreach (Developer dev in devs)
            {
                DataGridViewRow row = (DataGridViewRow)cloneArr.Rows[0].Clone(); // Creates a new row by cloning from a template
                row.Cells[0].Value = dev.GetName();
                row.Cells[1].Value = dev.GetAddress();
                row.Cells[2].Value = dev.GetEmpType();
                row.Cells[3].Value = dev.GetSupervisor();
                row.Cells[5].Value = dev.GetDevType();
                row.Cells[6].Value = dev.GetTaxType();
                dataArr.Rows.Add(row);
            }
            foreach (Manager mgr in mgrs)
            {
                DataGridViewRow row = (DataGridViewRow)cloneArr.Rows[0].Clone(); // Creates a new row by cloning from a template
                row.Cells[0].Value = mgr.GetName();
                row.Cells[1].Value = mgr.GetAddress();
                row.Cells[2].Value = mgr.GetEmpType();
                row.Cells[3].Value = mgr.GetSupervisor();
                row.Cells[4].Value = mgr.GetCostCenter();
                dataArr.Rows.Add(row);
            }
        }
    }
}
