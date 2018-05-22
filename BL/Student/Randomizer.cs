using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Randomizer
    {
        public static List<Student> StudentAdd()
        {
            List<Student> list = new List<Student>();
            /*double[] d = new double[] { 4.3, 4.2, 4.1, 4};
            double[] d1 = new double[] { 4.3, 4.2, 4.1, 4 };
            double[] d2 = new double[] { 4.2, 4.2, 4.1, 4, 4, 3.8, 3.7, 3.7, 3.6, 3.6 };
            double[] d3 = new double[] { 4, 4.2, 4.1, 4, 4, 4 };
            double[] d4 = new double[] { 4.4, 4.2};
            double[] d5 = new double[] { 3.2, 4.2, 4.1, 4, 4, 4,4.3,4.3 };
            double[] d6 = new double[] { 5, 4.2};
            double[] d7 = new double[] { 4.5, 4.2, 4.1, 4, 3.8, 4 };
            double[] d8 = new double[] { 4.1, 4.2, 4.1, 3.9, 3.8, 3.7,4,3.8,3.8,3.7 };
            double[] d9 = new double[] { 4.3, 4.2, 4.1, 3.8, 4, 4.6,4.5,4.4 };
            double[] d10 = new double[] { 4.3, 4.2, 4.1, 4.1};*/
            Student s = new Student { FIO = "Иванов Иван Иванович", Year = DateTime.Parse("1.07.1999"), Medb = new double[4] {4.3,4.2,4.1,4}, Kurs = 2, Group = 1 };
            Student s1 = new Student { FIO = "Степанов Степан Степанович", Year = DateTime.Parse("2.08.1999"), Medb = new double[4] { 4.3, 4.2, 4.1, 4 }, Kurs = 2, Group = 2 };
            Student s2 = new Student { FIO = "Макаров Макар Макарович", Year = DateTime.Parse("28.04.1996"), Medb = new double[6] { 4.2, 4.2, 4.1, 4, 4, 3.8 }, Kurs = 3, Group = 2 };
            Student s3 = new Student { FIO = "Ульянова Ульяна Павловна", Year = DateTime.Parse("15.02.1998"), Medb = new double[6] { 4, 4.2, 4.1, 4, 4, 4 }, Kurs = 3, Group = 4 };
            Student s4 = new Student { FIO = "Борисов Борис Бориславович", Year = DateTime.Parse("02.04.2000"), Medb = new double[2] { 4.4, 4.2 }, Kurs = 1, Group = 3};
            Student s5 = new Student { FIO = "Карасев Виктор Михайлович", Year = DateTime.Parse("09.08.1997"), Medb = new double[8] { 3.2, 4.2, 4.1, 4, 4, 4, 4.3, 4.3 }, Kurs = 4, Group = 1 };
            Student s6 = new Student { FIO = "Чернышов Алексей Викторович", Year = DateTime.Parse("03.03.1999"), Medb = new double[2] { 5, 4.2 }, Kurs = 1, Group = 2 };
            Student s7 = new Student { FIO = "Греков Андрей Валерьевич", Year = DateTime.Parse("05.11.1998"), Medb = new double[6] { 4.5, 4.2, 4.1, 4, 3.8, 4 }, Kurs = 3, Group = 3 };
            Student s8 = new Student { FIO = "Грудинин Павел Алексеевич", Year = DateTime.Parse("12.12.1996"), Medb = new double[10] { 4.1, 4.2, 4.1, 3.9, 3.8, 3.7, 4, 3.8, 3.8, 3.7 }, Kurs = 5, Group = 2 };
            Student s9 = new Student { FIO = "Керинский Илья Петрович", Year = DateTime.Parse("26.07.1997"), Medb = new double[8] { 4.3, 4.2, 4.1, 3.8, 4, 4.6, 4.5, 4.4 }, Kurs = 4, Group = 4 };
            Student s10 = new Student { FIO = "Быков Богдан Антонович", Year = DateTime.Parse("12.08.1999"), Medb =  new double[4] { 4.3, 4.2, 4.1, 4.1 }, Kurs = 2, Group = 1 };
            Student s11 = new Student { FIO = "Семенов Петр Анатольевич", Year = DateTime.Parse("14.07.1999"), Medb = new double[4] { 4.3, 4.2, 4.1, 4 }, Kurs = 2, Group = 1 };
            Student s12 = new Student { FIO = "Склярова Анастасия Викторовна", Year = DateTime.Parse("23.04.1999"), Medb = new double[4] { 4.3, 4.2, 4.1, 4 }, Kurs = 2, Group = 2 };
            Student s13 = new Student { FIO = "Белова Анна Валерьевна", Year = DateTime.Parse("27.01.2000"), Medb = new double[8] { 4.1, 4.2, 4, 4, 4, 3.8, 3.7, 3.7 }, Kurs = 4, Group = 2 };
            Student s14 = new Student { FIO = "Серов Андрей Сергеевич", Year = DateTime.Parse("15.05.1998"), Medb = new double[6] { 4, 4.2, 4.1, 4, 4, 4 }, Kurs = 3, Group = 4 };
            Student s15 = new Student { FIO = "Конев Владимир Павлович", Year = DateTime.Parse("02.09.2000"), Medb = new double[2] { 4.4, 4}, Kurs = 1, Group = 3 };
            Student s16 = new Student { FIO = "Антонов Виктор Антонович", Year = DateTime.Parse("02.05.1996"), Medb = new double[8] { 4.2, 3.2, 4.1, 4, 4, 4, 4.3, 4.3 }, Kurs = 4, Group = 1 };
            Student s17 = new Student { FIO = "Горбунов Сергей Анатольевич", Year = DateTime.Parse("03.03.2000"), Medb = new double[2] { 5, 4.2 }, Kurs = 1, Group = 2 };
            Student s18 = new Student { FIO = "Шаев Илья Олегович", Year = DateTime.Parse("05.11.1997"), Medb = new double[6] { 4.5, 4.2, 4.1, 4, 4, 3.6 }, Kurs = 3, Group = 3 };
            Student s19 = new Student { FIO = "Мелехов Юрий Владиславович ", Year = DateTime.Parse("12.12.1995"), Medb = new double[8] { 4.1, 4, 4.1, 3.9, 3.8, 3.7, 4, 3.8 }, Kurs = 4, Group = 2 };
            Student s20 = new Student { FIO = "Скворцов Павел Иванович", Year = DateTime.Parse("26.07.1997"), Medb = new double[8] { 4.8, 4.2, 4.2, 3.8, 4, 4.6, 4.5, 4.4 }, Kurs = 4, Group = 4 };
            Student s21 = new Student { FIO = "Суркова Алина Михайловна", Year = DateTime.Parse("12.08.1998"), Medb = new double[4] { 4.7, 4.3, 4.1, 4.1 }, Kurs = 2, Group = 1 };
            list.Add(s);
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            list.Add(s4);
            list.Add(s5);
            list.Add(s6);
            list.Add(s7);
            list.Add(s8);
            list.Add(s9);
            list.Add(s10);
            list.Add(s11);
            list.Add(s12);
            list.Add(s13);
            list.Add(s14);
            list.Add(s15);
            list.Add(s16);
            list.Add(s17);
            list.Add(s18);
            list.Add(s19);
            list.Add(s20);
            list.Add(s21);
            return list;
        }
    }
}
