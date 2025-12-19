using System.Text;
using Tyuiu.ZakachurinIE.Sprint7.Project.V11.Lib;
using static Tyuiu.ZakachurinIE.Sprint7.Project.V11.Lib.DataService;

namespace Tyuiu.ZakachurinIE.Sprint7.Project.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromFile()
        {
            string path = $@"C:\DataSprint7\Employees.csv";
            DataService ds = new DataService();

            ds.LoadFromFile(path);
            Assert.AreEqual(2, ds.GetAllEmployees().Count);
            Assert.AreEqual("Инженер", ds.GetAllEmployees()[0].Position);

        }
        [TestMethod]
        public void SearchBySurnameValid()
        {

            DataService ds = new DataService();
            string path = $@"C:\DataSprint7\Employees.csv";
            ds.LoadFromFile(path);
            var result = ds.SearchBySurname("Иванов");
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.All(e => e.Surname == "Иванов"));
        }
        [TestMethod]
        public void SearchByNameValid()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint7\Employees.csv";
            ds.LoadFromFile(path);
            var result = ds.SearchByName("Ива");
            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result.All(e => e.Name == "Иван"));
        }
        [TestMethod]
        public void SearchByPatronymicValid()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint7\Employees.csv";
            ds.LoadFromFile(path);
            var result = ds.SearchByPatronymic("Ива");
            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result.All(e => e.Patronymic == "Иванович"));

        }
        [TestMethod]
        public void SearchByPhoneValid()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint7\Employees.csv";
            ds.LoadFromFile(path);
            var result = ds.SearchByPhone("8999");
            Assert.IsTrue(result.Count > 0);
            Assert.IsTrue(result.All(e => e.PhoneNumber.Contains("8999")));
        }
    }
}
