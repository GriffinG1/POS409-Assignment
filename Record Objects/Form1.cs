using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record_Objects
{
    public partial class Form1 : Form
    {
        private string[] file;
        private int visibleRecs;
        private List<Developer> devs;
        private List<Manager> mgrs;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePathBox.Text = dialog.FileName;
                file = File.ReadAllLines(dialog.FileName);
                CreateObjs();
                UpdateRecChoice();
            }
        }

        private void UpdateRecChoice()
        {
            recordChoice.Items.Clear();
            for (int i = 1; i <= file.Length; i++)
            {
                recordChoice.Items.Add($"{i} records");
            }
            recordChoice.Enabled = true;
            recordChoice.SelectedIndex = file.Length-1;
        }

        private void CreateObjs()
        {
            devs = new List<Developer>();
            mgrs = new List<Manager>();
            for (int i = 0; i < file.Length; i++)
            {
                string[] empInfo = file[i].Split(',');
                if (empInfo[6] == "Developer")
                {
                    Developer dev = new Developer();
                    dev.SetName(empInfo[0], empInfo[1]);
                    dev.SetAddress(empInfo[2], empInfo[3], empInfo[4], empInfo[5]);
                    dev.SetEmpType(empInfo[6]);
                    dev.SetDevType(empInfo[7]);
                    dev.SetSupervisor(empInfo[9]);
                    dev.SetTaxType(empInfo[10]);
                    devs.Add(dev);
                }
                else
                {
                    Manager mgr = new Manager();
                    mgr.SetName(empInfo[0], empInfo[1]);
                    mgr.SetAddress(empInfo[2], empInfo[3], empInfo[4], empInfo[5]);
                    mgr.SetEmpType(empInfo[6]);
                    mgr.SetCostCenter(empInfo[8]);
                    mgr.SetSupervisor(empInfo[10]);
                    mgrs.Add(mgr);
                }
            }
        }

        private void UpdateArr()
        {
            while (dataArr.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataArr.Rows)
                {
                    dataArr.Rows.Remove(row);
                }
            }
            int index = 1;
            foreach (Developer dev in devs)
            {
                if (index > visibleRecs) break;
                DataGridViewRow row = (DataGridViewRow)cloneArr.Rows[0].Clone();
                row.Cells[0].Value = dev.GetName();
                row.Cells[1].Value = dev.GetAddress();
                row.Cells[2].Value = dev.GetEmpType();
                row.Cells[3].Value = dev.GetSupervisor();
                row.Cells[5].Value = dev.GetDevType();
                row.Cells[6].Value = dev.GetTaxType();
                dataArr.Rows.Add(row);
                index++;
            }
            foreach (Manager mgr in mgrs)
            {
                if (index > visibleRecs) break;
                DataGridViewRow row = (DataGridViewRow)cloneArr.Rows[0].Clone();
                row.Cells[0].Value = mgr.GetName();
                row.Cells[1].Value = mgr.GetAddress();
                row.Cells[2].Value = mgr.GetEmpType();
                row.Cells[3].Value = mgr.GetSupervisor();
                row.Cells[4].Value = mgr.GetCostCenter();
                dataArr.Rows.Add(row);
                index++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // null, as text box is not manual
        }

        private void infoArr_Paint(object sender, PaintEventArgs e)
        {
            // null
        }

        private void dataArr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // null
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void recordChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            visibleRecs = recordChoice.SelectedIndex + 1;
            UpdateArr();
        }
    }
}
