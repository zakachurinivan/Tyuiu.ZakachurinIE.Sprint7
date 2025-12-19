using System.Text;

namespace Tyuiu.ZakachurinIE.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        public class Employee
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
            _employees = new List<Employee>();
        }

        public void LoadFromFile(string filePath)
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
        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }
    }
}
