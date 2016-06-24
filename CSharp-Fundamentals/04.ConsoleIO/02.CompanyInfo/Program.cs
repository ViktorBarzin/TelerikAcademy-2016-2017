using System;

class Program
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phone = Console.ReadLine();
        string fax = Console.ReadLine();
        string website = Console.ReadLine();
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        if (fax == string.Empty)
        {
            fax = "(no fax)";
        }

        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, phone, fax, website, firstName,
            lastName, age, managerPhone);


    }
}

