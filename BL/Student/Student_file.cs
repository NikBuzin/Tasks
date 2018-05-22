using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Student
{
   public class Student_file:List_Student
    {
        public List<Student> List_std { get; set; }

        public Student_file()
        {

        }

        public Student_file(string FileName)
        {
            List_std = Reader(FileName);
        }

        public void Write_to(string FileName)
        {
            List<Student> s;
            s = Randomizer.StudentAdd();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = new FileStream(FileName, FileMode.Create))
            {
                formatter.Serialize(f, s);
            }
        }

        public List<Student> Reader(string FileName)
        {
            List<Student> list = new List<Student>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = new FileStream(FileName, FileMode.Open))
            {
                List<Student> deserilizeStd = (List<Student>)formatter.Deserialize(f);
                foreach (Student s in deserilizeStd)
                {
                    list.Add(s);
                }
            }
            return list;
        }
    }
}
