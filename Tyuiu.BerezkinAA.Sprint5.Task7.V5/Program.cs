using Tyuiu.BerezkinAA.Sprint5.Task7.V5.Lib;
namespace Tyuiu.BerezkinAA.Sprint5.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Березкин А.А | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #6                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. удалить латиницу       *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V5.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V5.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists) File.Delete(pathSaveFile);

            Console.WriteLine("находится в файле: " + pathSaveFile);
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Полученная стока: " + pathSaveFile);
            Console.ReadKey();
        }
    }
}