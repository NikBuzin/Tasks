using System.Collections.Generic;

public struct People : IComparer<People>
{
    public string Name { get; set; }
    public int? Age { get; set; }
    public People(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public int Compare(People p1, People p2)
    {
        if (p1.Name[0] > p2.Name[0])
            return 1;
        else if (p1.Name[0] < p2.Name[0])
            return -1;
        else
        {
            if (p1.Age > p2.Age)
                return 1;
            else if (p1.Age < p2.Age)
                return -1;
            else
                return 0;
        }
    }
}
