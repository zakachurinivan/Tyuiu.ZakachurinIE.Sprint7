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

        
        private List<Employee> employees;

        public DataService()
        {
            employees = new List<Employee>(); // делаю списочек
        }

        public void LoadFromFile(string filePath) // этот метод читает данные из файла.ксв и заполняет колоночки в списке
        {            
            employees.Clear();          
            string[] lines = File.ReadAllLines(filePath);           
            for (int i = 0; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(';');
                Employee sotrudnik = new Employee
                {Surname = columns[0],Name = columns[1],Patronymic = columns[2],Address = columns[3],PhoneNumber = columns[4],BirthDate = DateTime.Parse(columns[5]),Position = columns[6],StartDate = DateTime.Parse(columns[7]),ExperienceYears = int.Parse(columns[8])};
                employees.Add(sotrudnik);
            }

        }
        public List<Employee> GetAllEmployees() // выводим весь список всех сотрудников
        {
            return employees;
        }
        public List<Employee> SearchBySurname(string surname) // следуя из названия - поиск по фамилии, для которого не обязательна полная фамилия
        {
            return employees.Where(e => e.Surname.IndexOf(surname, StringComparison.OrdinalIgnoreCase)>=0).ToList();
        }       
        public List<Employee> SearchByName(string name) // поиск по имени, можно написать лишь часть имени
        {
            return employees.Where(e => e.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase)>=0).ToList();
        }        
        public List<Employee> SearchByPatronymic(string patronymic) // поиск по отчеству
        {
            return employees.Where(e => e.Patronymic.IndexOf(patronymic, StringComparison.OrdinalIgnoreCase)>=0).ToList();
        }
        public List<Employee> SearchByPhone(string phone) // поиск по телефону, также можно написать только часть номера, а не весь
        {
            return employees.Where(e => e.PhoneNumber.Contains(phone.Trim())).ToList();
        }
        public List<Employee> SearchByExperience(int minYears, int maxYears) // поиск по стажу работы, где можно выставить от и до 
        {
            return employees.Where(e => e.ExperienceYears >= minYears && e.ExperienceYears <= maxYears).ToList();
        }
        public List<Employee> SearchByPositionContains(string positionPart) // поиск по должности ( можно написать только часть слова)
        {
            return employees.Where(e => e.Position.IndexOf(positionPart, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }
        public List<Employee> SortByExperience() // сортировка стажа по возрастанию
        {
            return  employees.OrderBy(e => e.ExperienceYears).ToList();
        }
        public List<Employee> SortByBirthDate() // сортировка по дате рождения по возрастанию
        {
            return employees.OrderBy(e => e.BirthDate).ToList();
        }
        public List<Employee> SortByStartDate() // сортировка по вступлению на работу по возрастанию
        {
            return employees.OrderBy(e => e.StartDate).ToList();
        }
        public List<Employee> SortByExperienceBack() // сортировка по стажу на убывание
        {
            return employees.OrderByDescending(e => e.ExperienceYears).ToList();
        }
        public List<Employee> SortByBirthDateBack() // сортировка по дате рождения по убыванию
        {
            return employees.OrderByDescending(e => e.BirthDate).ToList();
        }
        public List<Employee> SortByStartDateBack() // сортировка по вступлению на работу по убыванию
        {
            return employees.OrderByDescending(e => e.StartDate).ToList();
        }
        public int GetEmployeeCount() // количество сотрудников
        {
            return employees.Count;
        }
        public double GetAverageExperience() // средний стаж сотрудника
        {
            if (employees.Count == 0) return 0;
            return employees.Average(e => e.ExperienceYears);
        }
        public int GetMinExperience() // минимальный стаж
        {
            if (employees.Count == 0) return 0;
            return employees.Min(e => e.ExperienceYears);
        }
        public int GetMaxExperience() // максимальный стаж
        {
            if (employees.Count == 0) return 0;
            return employees.Max(e => e.ExperienceYears);
        }
        public double GetAverageAge() // средний возраст
        {
            if (employees.Count == 0) return 0;
            DateTime today = DateTime.Today;
            double totalAge = 0;
            foreach (var emp in employees)
            {
                int age = today.Year - emp.BirthDate.Year;
                if (emp.BirthDate.Date > today.AddYears(-age))
                    age--;
                totalAge += age;
            }
            return totalAge / employees.Count;
        }
        public void SaveToFile(string filePath) // сохранение в файл
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {                             
                foreach (var emp in employees)
                {
                    string line = $"{emp.Surname};{emp.Name};{emp.Patronymic};{emp.Address};{emp.PhoneNumber};{emp.BirthDate:dd.MM.yyyy};{emp.Position};{emp.StartDate:dd.MM.yyyy};{emp.ExperienceYears}";
                    writer.WriteLine(line);
                }
            }
        }
        public void AddEmployee(Employee emp) // добавление сотрудника
        {
            if (emp == null) return;
            employees.Add(emp);
        }
        public void RemoveEmployee(int index) // удаление сотрудника по индексу
        {
            if (index >= 0 && index < employees.Count)
            {
                employees.RemoveAt(index);
            }
        }
        public void UpdateEmployee(int index, Employee emp) // обновление данных о сотруднике
        {
            if (index >= 0 && index < employees.Count && emp != null)
            { 
                employees[index] = emp; 
            }
        }

    }
}
