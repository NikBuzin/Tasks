using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BL
{
    public class WorkWSpisok
    {
        public string InputFile { get; set; }
        public List<string> Lines { get; set; }

        public WorkWSpisok(string inputFile)
        {
            InputFile = inputFile;
            Lines = File.ReadAllLines(inputFile, Encoding.Default).ToList();
        }

        public void SaveFile()
        {
            File.WriteAllLines(InputFile, Lines);
        }

        public string[] DeleteString (int n)
        {
            Lines.RemoveAt(n);
            SaveFile();
            return Lines.ToArray();
        }
    }
}
