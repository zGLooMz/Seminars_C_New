using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    internal class FindFile
    {
        public static void SearchForFile(string directory, string fileName)
        {
            var files = Directory.EnumerateFiles(directory, fileName, SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine($"Искомый файл {fileName} находится по пути: {file}");
            }
        }

        public static void SearchForValueInFile(string fileName, string searchValue)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(searchValue))
                        {
                            Console.WriteLine($"Найдено значение {searchValue} в файле {fileName}: {line}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не существует");
            }
        }
    }
}