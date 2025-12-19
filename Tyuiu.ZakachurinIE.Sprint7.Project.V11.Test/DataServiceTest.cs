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
            Assert.AreEqual("Инженер",ds.GetAllEmployees()[0].Position);

        }
    }
}
