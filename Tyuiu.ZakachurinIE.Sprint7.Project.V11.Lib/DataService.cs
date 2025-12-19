using System.Text;

namespace Tyuiu.ZakachurinIE.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        public class Employee // каждый сотрудник в списке будет иметь такие х-ки
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Patronymic { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime BirthDate { get; set; }
            public string Position { get; set; }
            public DateTime StartDate { get; set; }
            public int ExperienceYears { get; set; }

            
        }

        
        private List<Employee> _employees;

        public DataService()
        {
            _employees = new List<Employee>(); // делаю списочек
        }

        public void LoadFromFile(string filePath) // этот метод читает данные из файла.ксв и заполняет колоночки в списке
        {            
            _employees.Clear();          
            string[] lines = File.ReadAllLines(filePath);           
            for (int i = 0; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(';');
                Employee sotrudnik = new Employee
                {Surname = columns[0],Name = columns[1],Patronymic = columns[2],Address = columns[3],PhoneNumber = columns[4],BirthDate = DateTime.Parse(columns[5]),Position = columns[6],StartDate = DateTime.Parse(columns[7]),ExperienceYears = int.Parse(columns[8])};
                _employees.Add(sotrudnik);
            }

        }
        public List<Employee> GetAllEmployees() // выводим весь список всех сотрудников
        {
            return _employees;
        }
        public List<Employee> SearchBySurname(string surname) // следуя из названия - поиск по фамилии, для которого не обязательна полная фамилия
        {
            return _employees.Where(e => e.Surname.IndexOf(surname, StringComparison.OrdinalIgnoreCase)>=0).ToList();
        }       
        public List<Employee> SearchByName(string name) // поиск по имени, можно написать лишь часть имени
        {
            return _employees.Where(e => e.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase)>=0).ToList();
        }        
        public List<Employee> SearchByPatronymic(string patronymic) // поиск по отчеству
        {
            return _employees.Where(e => e.Patronymic.IndexOf(patronymic, StringComparison.OrdinalIgnoreCase)>=0).ToList();

        }
        public List<Employee> SearchByPhone(string phone) // поиск по телефону, также можно написать только часть номера, а не весь
        {
            return _employees.Where(e => e.PhoneNumber.Contains(phone.Trim())).ToList();
        }


    }
}
