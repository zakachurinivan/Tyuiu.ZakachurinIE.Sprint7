using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tyuiu.ZakachurinIE.Sprint7.Project.V11.Lib.DataService;

namespace Tyuiu.ZakachurinIE.Sprint7.Project.V11
{
    public partial class FormEmployee_ZIE : Form

    {
        public Employee Employee { get; private set; }
        public FormEmployee_ZIE()
        {
            InitializeComponent();
            Employee = new Employee();
        }

        public FormEmployee_ZIE(Employee emp) : this()
        {
            Employee = emp;
            Fill();
        }

        private void Fill()
        {
            textBoxSurnameInput_ZIE.Text = Employee.Surname;
            textBoxNameInput_ZIE.Text = Employee.Name;
            textBoxPatronymicInput_ZIE.Text = Employee.Patronymic;
            textBoxAdressInput_ZIE.Text = Employee.Address;
            textBoxPhoneInput_ZIE.Text = Employee.PhoneNumber;
            dateTimePickerBirthDateInput_ZIE.Value = Employee.BirthDate;
            textBoxPositionInput_ZIE.Text = Employee.Position;
            dateTimePickerStartDateInput_ZIE.Value = Employee.StartDate;
            textBoxExperienceInput_ZIE.Text = Employee.ExperienceYears.ToString();
        }

        private void buttonSave_ZIE_Click(object sender, EventArgs e)
        {
            Employee.Surname = textBoxSurnameInput_ZIE.Text;
            Employee.Name = textBoxNameInput_ZIE.Text;
            Employee.Patronymic = textBoxPatronymicInput_ZIE.Text;
            Employee.Address = textBoxAdressInput_ZIE.Text;
            Employee.PhoneNumber = textBoxPhoneInput_ZIE.Text;
            Employee.BirthDate = dateTimePickerBirthDateInput_ZIE.Value;
            Employee.Position = textBoxPositionInput_ZIE.Text;
            Employee.StartDate = dateTimePickerStartDateInput_ZIE.Value;
            if (int.TryParse(textBoxExperienceInput_ZIE.Text, out int exp))
            {
                Employee.ExperienceYears = exp;
            }
            else
            {
                Employee.ExperienceYears = 0;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        private void buttonBack_ZIE_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
