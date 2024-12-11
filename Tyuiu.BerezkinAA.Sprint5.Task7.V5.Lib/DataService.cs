using System.Text.RegularExpressions;

namespace Tyuiu.BerezkinAA.Sprint5.Task7.V5.Lib
{
    public class DataService
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V5.txt");
            string outText = "";
            string alp = "[a-zA-Z]";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    outText += Regex.Replace(line, alp, "", RegexOptions.IgnoreCase);
                    outText = outText.Replace("    ", "");
                }
                File.AppendAllText(pathSaveFile, outText);
                return pathSaveFile;
            }
        }
    }
}