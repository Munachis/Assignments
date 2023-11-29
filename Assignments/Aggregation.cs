// See https://aka.ms/new-console-template for more information

using System.Net;

public class Name
{
    public string FirstName, MiddleName, LastName;
    public Name(string FirstName, string MiddleName, string LastName)
    {
        this.FirstName = FirstName;
        this.MiddleName = MiddleName;
        this.LastName = LastName;
    }
}

public class Person
{
    public int id;
    public Name name;
    public int age;
    public Person(int id, Name name, int age)
    {
        this.name = name;
        this.age = age;
        this.id = id;
    }
    public void display()
    {
        Console.WriteLine($"My name is  {name.FirstName} {name.MiddleName} {name.LastName}. I am {age} years old ");
    }

}
public class Mainsy
{
    //public static void Main(string[] args)
    //{
    //    Name na = new Name("Ofiligo", "Munachiso", "Momife");
    //    Person person = new Person(1, na, 17);
    //    person.display();
    //}
}
internal class Substring
{
    static void Main(string[] args)
    {
        Muna();
    }
    static void Muna()
    {
        Console.WriteLine("Enter the String and substring respectively");
        string Name = Console.ReadLine();
        string[] NameArr = Name.Split(' ');
        string substring = Console.ReadLine();
        int substringCount = 0;

        for (int i = 0; i < NameArr.Length; i++)
        {
            if (NameArr[i].Equals(substring))
            {
                substringCount++;
            }
        }
        Console.WriteLine($"The number is {substringCount}");

    }


}