using System.IO;
using System.Text;

namespace BL.Spisok
{
    public class ReadFromFile
    {
        public string Input_File { get; set; }
       

        public ReadFromFile(string path)
        {
            Input_File = path;
        }
        public WorkWSpis FileToCharacter(string FileName)
        {
            WorkWSpis list = new WorkWSpis();
            string[] temp = File.ReadAllLines(FileName, Encoding.Default);
            int sep = 0;
            string fio, prof;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = temp[i].Length - 1; temp[i][j] != ' '; j--)
                {
                    sep = j;
                }
                fio = temp[i].Substring(0, sep-1);
                prof = temp[i].Substring(sep, temp[i].Length - sep);
                list.AddToFIO(fio, prof);
            }
            return list;
        }        
    }
}
