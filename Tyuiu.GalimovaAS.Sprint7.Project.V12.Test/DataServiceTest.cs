using Tyuiu.GalimovaAS.Sprint7.Project.V12.Lib;

namespace Tyuiu.GalimovaAS.Sprint7.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\alina\source\repos\Tyuiu.GalimovaAS.Sprint7\Tyuiu.GalimovaAS.Sprint7.Project.V12\laptopsinputfile.csv";

            string row = "Honor MagicBook X16";

            int column = 1;
            string res = ds.CollectTextFromFile(path, row, column);

            string wait = "Intel Core i5 12450H";
            Assert.AreEqual(wait, res);

        }
    }
}