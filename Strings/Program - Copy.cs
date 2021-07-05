using System.Collections.Generic;

interface ISwimming
{
    void Swim();
}
interface IPicking
{
    string PickAndSayName();
}

internal abstract class Person
{
    public abstract void GetSalary();

    public void Test1()
    {

    }

}
class Student : Person, ISwimming, IPicking
{
    public override void GetSalary()
    {
        System.Console.WriteLine("Merhaba Hocam");
    }

    public string PickAndSayName()
    {
        return "red";
    }

    public void Swim()
    {

    }
}
class Teacher : IPicking
{
    public string PickAndSayName()
    {
        return " red";
    }
}
class MyApplication
{
    //new static
    static void Main3(string[] args)
    {
        //student referance variable
        Person student;
        student = new Student();
        student.GetSalary();
        //inherit yaptık

        var list = new List<Student>()
        {
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student()
        };

        System.Console.WriteLine(list.Count);

        foreach (Student student2 in list)
        {
            OnlyCanSwim(student2);
        }

        ISwimming studentAbleToSwim = new Student();
        studentAbleToSwim.Swim();
    }

    static void Main(string[] args)
    {
        //IPicking[] ableToPickArr = new Teacher[5];
        List<IPicking> ableToPickList = new List<IPicking>();
        ableToPickList.Add(new Student());
        ableToPickList.Add(new Teacher());
        foreach (IPicking t1 in ableToPickList)
        {
            t1.PickAndSayName();
        }
    }
    static void OnlyCanSwim(ISwimming swimming)
    {

    }
}