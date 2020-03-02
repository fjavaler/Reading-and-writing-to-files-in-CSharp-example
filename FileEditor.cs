using System;
using System.IO;

namespace Source
{
    public class FileEditor
    {
        public string[] ReadFile()
        {
            try
            {
                string path = Path.Combine("/home","fred","Desktop", "Javalera_Fred_Ch3COLONIAL_logfile");
                string[] linesOfText = System.IO.File.ReadAllLines(path);
                return linesOfText;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Exception thrown: " + e.Message + e.StackTrace);
            }

            return null;
        }
    }
}