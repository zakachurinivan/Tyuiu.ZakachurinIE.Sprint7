using System.Windows.Forms;
using Tyuiu.ZakachurinIE.Sprint7.Project.V11.Lib;

namespace Tyuiu.ZakachurinIE.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dataGridViewOutPut_ZIE.AutoGenerateColumns = true;
            ds = new DataService();
            ds.LoadFromFile(@"C:\DataSprint7\Employees.csv");
            dataGridViewOutPut_ZIE.DataSource = ds.GetAllEmployees();
        }
        DataService ds = new DataService();
        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {   
            FormEmployee_ZIE form = new FormEmployee_ZIE();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ds.AddEmployee(form.Employee);
                RefreshGrid();
            }
        }
        private void RefreshGrid()
        {
            dataGridViewOutPut_ZIE.DataSource = null;
            dataGridViewOutPut_ZIE.DataSource = ds.GetAllEmployees();
        }

    }
}
