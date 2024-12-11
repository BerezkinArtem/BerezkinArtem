using Tyuiu.BerezkinAA.Sprint5.Task7.V5.Lib;
namespace Tyuiu.BerezkinAA.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {

        public void LoadDataAndSave()
        {
            DataService ds = new DataService();
            string p = @"C:\DataSprint5\InPutDataFileTask7V5.txt";

            FileInfo fileInfo = new FileInfo(p);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}