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
            InitializeSortComboBox();
            dataGridViewOutPut_ZIE.DataSource = ds.GetAllEmployees();
            UpdatePositionComboBox();
        }

        private List<Employee> ApplySorting(List<Employee> employees)
        {
            if (comboBoxSort_ZIE.SelectedIndex <= 0)
                return employees;
            string sortType = comboBoxSort_ZIE.SelectedItem.ToString();
            switch (sortType)
            {
                case "Фамилия (А-Я)": return employees.OrderBy(e => e.Surname).ThenBy(e => e.Name).ToList();

                case "Фамилия (Я-А)": return employees.OrderByDescending(e => e.Surname).ThenBy(e => e.Name).ToList();

                case "Стаж (по возрастанию)": return ds.SortByExperience();

                case "Стаж (по убыванию)": return ds.SortByExperienceBack();

                case "Дата рождения (по возрастанию)": return ds.SortByBirthDate();

                case "Дата рождения (по убыванию)": return ds.SortByBirthDateBack();

                case "Дата приема (по возрастанию)": return ds.SortByStartDate();

                case "Дата приема (по убыванию)": return ds.SortByStartDateBack();

                default: return employees;
            }
        }
        private void InitializeSortComboBox()
        {
            comboBoxSort_ZIE.Items.Clear();
            comboBoxSort_ZIE.Items.AddRange(new string[]
            {"Без сортировки","Фамилия (А-Я)","Фамилия (Я-А)","Стаж (по возрастанию)","Стаж (по убыванию)","Дата рождения (по возрастанию)","Дата рождения (по убыванию)","Дата приема (по возрастанию)","Дата приема (по убыванию)"});
            comboBoxSort_ZIE.SelectedIndex = 0;
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
            DialogResult result = MessageBox.Show($"Удалить сотрудника {name}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show("Данные сохранены", "Отлично", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Employee> ApplyFilters()
        {
            var result = ds.GetAllEmployees();
            string surnameFilter = textBoxSurnameInput_ZIE.Text.Trim();
            if (!string.IsNullOrEmpty(surnameFilter))
            {
                result = ds.SearchBySurname(surnameFilter);
            }
            string phoneFilter = textBoxPhoneInput_ZIE.Text.Trim();
            if (!string.IsNullOrEmpty(phoneFilter))
            {
                result = result.Intersect(ds.SearchByPhone(phoneFilter)).ToList();
            }
            string positionFilter = comboBoxPositionInput_ZIE.Text.Trim();
            if (!string.IsNullOrEmpty(positionFilter) && positionFilter != "Все должности")
            {
                result = result.Intersect(ds.SearchByPositionContains(positionFilter)).ToList();
            }
            string expStartText = textBoxExpStartInput_ZIE.Text.Trim();
            string expStopText = textBoxExpStopInput_ZIE.Text.Trim();
            int minYears = 0;
            int maxYears = 100;
            int.TryParse(expStartText, out minYears);
            int.TryParse(expStopText, out maxYears);

            if (!string.IsNullOrEmpty(expStartText) || !string.IsNullOrEmpty(expStopText))
            {
                result = result.Intersect(ds.SearchByExperience(minYears, maxYears)).ToList();
            }
            result = ApplySorting(result);
            return result;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var filtered = ApplyFilters();
            dataGridViewOutPut_ZIE.DataSource = filtered;

            if (filtered.Count == 0)
            {
                MessageBox.Show("Нет сотрудников, соответствующих критериям поиска", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSurnameInput_ZIE.Clear();
            textBoxPhoneInput_ZIE.Clear();
            comboBoxPositionInput_ZIE.SelectedIndex = 0;
            textBoxExpStartInput_ZIE.Clear();
            textBoxExpStopInput_ZIE.Clear();
            comboBoxSort_ZIE.SelectedIndex = 0;
            dataGridViewOutPut_ZIE.DataSource = ds.GetAllEmployees();
        }
        private void UpdatePositionComboBox()
        {
            comboBoxPositionInput_ZIE.Items.Clear();
            comboBoxPositionInput_ZIE.Items.Add("Все должности");
            var positions = ds.GetAllEmployees().Select(e => e.Position).Distinct().OrderBy(p => p); // возвращаем список всех сотрудников
                                                                                                     // преобразуем в список только должностей и убираем повторы, сортируем по алфавиту
            foreach (string pos in positions)
            {
                comboBoxPositionInput_ZIE.Items.Add(pos);
            }
            comboBoxPositionInput_ZIE.SelectedIndex = 0;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Выберите файл с данными сотрудников";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.LoadFromFile(openFileDialog.FileName);
                    dataGridViewOutPut_ZIE.DataSource = ds.GetAllEmployees();
                    UpdatePositionComboBox();
                    MessageBox.Show($"Загружено {ds.GetEmployeeCount()} записей", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void toolStripButtonStats_ZIE_Click(object sender, EventArgs e)
        {
            FormStats statsForm = new FormStats(ds);
            statsForm.ShowDialog();
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.ShowDialog();
        }
        private void ToolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            FormHelp helpForm = new FormHelp();
            helpForm.ShowDialog();
        }
    }
}
