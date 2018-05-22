using System;
using System.IO;
using System.Text;

namespace BL.Sort2Kyes
{
    public class LoadPeople
    {
        public string Input_File { get; set; }
        
        public LoadPeople(string path)
        {
            Input_File = path;
        }
        public WorkWSort FileToPeople(string FileName)
        {
            WorkWSort work = new WorkWSort();
            string[] temp = File.ReadAllLines(FileName, Encoding.Default);
            int sep = 0;
            string name; 
            int age;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = temp[i].Length - 1; temp[i][j] != ' '; j--)
                {
                    sep = j;
                }
                name = temp[i].Substring(0, sep - 1);
                age = Convert.ToInt32(temp[i].Substring(sep, temp[i].Length - sep));
                work.AddToPeople(name, age);
            }
            return work;
        }
    }
}
