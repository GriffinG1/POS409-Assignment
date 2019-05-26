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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Record_Objects
{
    public partial class Form1 : Form
    {
        JToken file;
        private int visibleRecs;
        private int viableFileLength;
        private List<Developer> devs;
        private List<Manager> mgrs;
        private List<Developer> devSearch;
        private List<Manager> mgrSearch;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Loads file
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".json files (*.json)|*.json|All files (*.*)|*.*";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePathBox.Text = dialog.FileName;
                file = JToken.Parse(File.ReadAllText(dialog.FileName)); // Pulls file content into string[] file
                viableFileLength = file.Count();
                CreateObjs();
                UpdateRecChoice();
                searchInputs.Enabled = true;
            }
        }

        private void UpdateRecChoice() // Updates the items in the combo box
        {
            recordChoice.Items.Clear();
            for (int i = 1; i <= viableFileLength; i++)
            {
                recordChoice.Items.Add($"{i} records");
            }
            recordChoice.Enabled = true; // Enables combo box on first load
            recordChoice.SelectedIndex = viableFileLength - 1;
        }

        private void CreateObjs() // Resets the objects and their lists on new load
        {
            devs = new List<Developer>();
            mgrs = new List<Manager>();
            bool badLines = false;
            foreach (JObject emp in file.Children())
            {
                Dictionary<string, string> empDict = emp.ToObject<Dictionary<string, string>>(); // Convert each employee to a dict
                try
                {
                    if (empDict["empType"] == "Developer")
                    {
                        Developer dev = new Developer();
                        dev.SetName(empDict["firstName"], empDict["lastName"]);
                        dev.SetAddress(empDict["street"], empDict["city"], empDict["state"], empDict["zipCode"]);
                        dev.SetEmpType(empDict["empType"]);
                        dev.SetDevType(empDict["devType"]);
                        dev.SetSupervisor(empDict["supervisor"]);
                        dev.SetTaxType(empDict["taxType"]);
                        devs.Add(dev);
                    }
                    else
                    {
                        Manager mgr = new Manager();
                        mgr.SetName(empDict["firstName"], empDict["lastName"]);
                        mgr.SetAddress(empDict["street"], empDict["city"], empDict["state"], empDict["zipCode"]);
                        mgr.SetEmpType(empDict["empType"]);
                        mgr.SetCostCenter(empDict["costCenter"]);
                        mgr.SetSupervisor(empDict["supervisor"]);
                        mgrs.Add(mgr);
                    }
                }
                catch (KeyNotFoundException)
                {
                    viableFileLength--;
                    badLines = true;
                }
            }
            if (badLines) // Throws error at end of loading
            {
                MessageBox.Show("Some entries in your file were missing values, and as such were skipped", "Incorrect Line",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateArr() // Clears and adds objects to the Data Grid
        { 
            dataArr.Rows.Clear();
            int index = 1;
            foreach (Developer dev in devs)
            {
                if (index > visibleRecs) break; // Ensures only the selected amount show
                DataGridViewRow row = (DataGridViewRow)cloneArr.Rows[0].Clone(); // Creates a new row by cloning from a template
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
                if (index > visibleRecs) break; // Ensures only the selected amount show
                DataGridViewRow row = (DataGridViewRow)cloneArr.Rows[0].Clone(); // Creates a new row by cloning from a template
                row.Cells[0].Value = mgr.GetName();
                row.Cells[1].Value = mgr.GetAddress();
                row.Cells[2].Value = mgr.GetEmpType();
                row.Cells[3].Value = mgr.GetSupervisor();
                row.Cells[4].Value = mgr.GetCostCenter();
                dataArr.Rows.Add(row);
                index++;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close(); // Exits program
        }

        private void recordChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            visibleRecs = recordChoice.SelectedIndex + 1;
            UpdateArr();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form2 searchForm = new Form2(devSearch, mgrSearch);
            searchForm.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            devSearch = devs.Where(dev => dev.GetName().Contains(searchInputs.Text) || dev.GetAddress().Contains(searchInputs.Text)).ToList();
            mgrSearch = mgrs.Where(mgr => mgr.GetName().Contains(searchInputs.Text) || mgr.GetAddress().Contains(searchInputs.Text)).ToList();
        }
    }
}
