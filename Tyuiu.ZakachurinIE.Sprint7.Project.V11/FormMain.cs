using System.Windows.Forms;
using Tyuiu.ZakachurinIE.Sprint7.Project.V11.Lib;
using static Tyuiu.ZakachurinIE.Sprint7.Project.V11.Lib.DataService;

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
        private void toolStripButtonEdit_ZIE_Click(object sender, EventArgs e)
        {
            if (dataGridViewOutPut_ZIE.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для редактирования");
                return;
            }

            int index = dataGridViewOutPut_ZIE.SelectedRows[0].Index;
            Employee emp = ds.GetEmployee(index);

            FormEmployee_ZIE form = new FormEmployee_ZIE(emp);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ds.UpdateEmployee(index, form.Employee);
                RefreshGrid();
            }
        }
        private void dataGridViewOutPut_ZIE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            toolStripButtonEdit_ZIE_Click(sender, e);
        }
        private void toolStripButtonDelete_ZIE_Click(object sender, EventArgs e)
        {
            if (dataGridViewOutPut_ZIE.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления");
                return;
            }
            int index = dataGridViewOutPut_ZIE.SelectedRows[0].Index;
            string name = ds.GetEmployee(index).Surname;
            DialogResult result = MessageBox.Show($"Удалить сотрудника {name}?","Подтверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ds.RemoveEmployee(index);
                RefreshGrid();
            }
        }
        private void toolStripButtonSave_ZIE_Click(object sender, EventArgs e)
        {
            try
            {
                ds.SaveToFile(@"C:\DataSprint7\Employees.csv");
                MessageBox.Show("Данные сохранены", "Отлично",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
