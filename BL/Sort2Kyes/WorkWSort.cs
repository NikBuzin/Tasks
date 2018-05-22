using System;
using System.Collections.Generic;

namespace BL.Sort2Kyes
{
    /* Примером сортировки по двум ключам может служить список файлов, имеющих одинаковые имена и разные расшиерния.
     * Список упорядочен по именам, а для каждого имени - по расширениям.
     * Написать программу, которая сортирует элементы массива по двум ключам.
     * Элементом массива является запись, два поля которойй - два ключа.*/
    public class WorkWSort
    {
        public List<People> Peoples = new List<People>(); 

        public void AddToPeople(string name, int age)
        {
        Peoples.Add(new People(name, age));
        }

        public string Printer()
        {
            string result = "";
            for (int i = 0; i < Peoples.Count; i++)
            { 
                    result += Peoples[i].Name + ' ' + Peoples[i].Age + Environment.NewLine;
            }
            return result;
        }
        
        public void SortName()  
        {
            Peoples.Sort(new People());            
        }        
    }
}
