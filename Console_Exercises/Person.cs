namespace Console_Exercises;

public class Person
{
    public string Name { get; private set; }

    private int _age;
    public int Age => _age;
    
    public string Email { get; private set; }
    public string Adress { get; private set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetAge(int age)
    {
        if (age < 0)
        {
            Console.WriteLine("Age cannot be negative.");
            return;
        }
        
        _age = age;
    }

    public void SetEmail(string email)
    {
        Email = email;
    }

    public void SetAdress(string adress)
    {
        Adress = adress;
    }
}