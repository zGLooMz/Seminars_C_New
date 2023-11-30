namespace Seminar8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directory = "H:\\New_C\\Seminars_C_New\\Seminar8"; 
            string fileName = "File.txt"; 
            string searchValue = "dfd";

            FindFile.SearchForFile(directory, fileName);
            FindFile.SearchForValueInFile(fileName, searchValue);
        }

        



    }
}