// Criação de propriedade.

using System;

class ClassUser
{
    protected string username = "";

    public string USERNAME
    {
        set
        {
            username = value;
        }
        get
        {
            return username;
        }
    }
}

class Program
{
    static void Main()
    {
        ClassUser testUser = new ClassUser();
        testUser.USERNAME = "Jonathan";
        string name = testUser.USERNAME;

        Console.WriteLine(name);
    }
}