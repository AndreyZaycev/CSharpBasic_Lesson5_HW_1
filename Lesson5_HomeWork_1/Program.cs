using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Lesson5_HomeWork_1
{
    internal class Program
    {
        //ввод данных
        private static List<string> GetWriteData()
        {
            List<string> vData = new List<string>();

            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            do
            {
                Console.Write("Введите данные (по окончании ввода нажмите ENTER) : ");
                vData.Add(Console.ReadLine());
                Console.Write("Для продолжения ввода данных нажмите любую клавишу, для окончания клавишу n : ");
                cki = Console.ReadKey(true);
                Console.WriteLine();
            }
            while (cki.Key != ConsoleKey.N);

            return vData;
        }

        //запись данных в файл
        private static void WriteDataToFile(string fileName, List<string> vData)
        {
            try
            {
                File.WriteAllLines(fileName, vData);
                Console.WriteLine($"\nДанные записаны в файл {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }

        //считать данные файла и вывести на консоль
        private static void ReadAndPrintFileData(string fileName)
        {
            //считать данные
            string[] vData = File.ReadAllLines(fileName);

            //вывод данных на консоль
            Console.WriteLine($"\n -- Данные файла {fileName} -- ");
            foreach (string s in vData) Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            //
            Console.WriteLine("----- Урок № 5, задание № 1 -----");
            Console.WriteLine();

            //имя записываемого файла
            string fileName = "text.txt";

            //получить данные для записи и записать данные в файл
            WriteDataToFile(fileName, GetWriteData());

            //считать данные файла и вывести на консоль 
            ReadAndPrintFileData(fileName);

            //
            Console.ReadLine();
        }
    }
}
