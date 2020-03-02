using System;
using System.Collections.Generic;
using System.IO;

namespace Source
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileEditor = new FileEditor();

            // Read file
            string[] fileLines = fileEditor.ReadFile();
            List<string> newFileLines = new List<string>();

            // Display Text
            System.Console.WriteLine("Contents of text file:\n");
            foreach (string line in fileLines)
            {
                if (line != "mysql> ")
                {
                    // Use a tab to indent each line of the file.
                    // Console.WriteLine("\t" + line);
                    newFileLines.Add(line);
                }
            }

            System.IO.File.WriteAllLines(Path.Combine("/home","fred","Desktop", "Javalera_Fred_Ch3COLONIAL_logfile_Output"), newFileLines);

            Console.WriteLine("Press any key to exit.");
            System.Console.Read();
        }
    }
}
