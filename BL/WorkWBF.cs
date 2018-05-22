using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL
{
    public class WorkWBF
    {
        public string InputFile { get; set; }
        public byte[] Number { get; set; }

        public WorkWBF(string inputFile)
        {
            InputFile = inputFile;
            Number = File.ReadAllBytes(inputFile);
        }

        public int HowMuch()
        {
            string number = Encoding.Default.GetString(Number);
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == ' ')
                {
                    result++;
                }
                else continue;
            }
            return result;
        }
    }
}
