using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        Grade obj = new Grade();
        obj.printsdetails();


    }
}

class Animal
{

    public virtual void Eat()
    {
        Console.WriteLine("Every Animal eat something");
    }

}

class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cats Eats to love fish...");
    }

}


class student
{

    string _stdName = "Rizwan";
    string _address = "karachi";
    public virtual void printsdetails()
    {
        Console.WriteLine("Student Name is " + _stdName);
        Console.WriteLine("Student Address is " + _address);
    }

}
class Grade : student
{
    string _class = "Four";
    float _percent = 71.87f;

    public override void printsdetails()
    {
        Console.WriteLine("Student Class is " + _class);
        Console.WriteLine("Student percentage is " + _percent);
    }
}