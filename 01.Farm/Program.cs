using System;
class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();
        MenuForAddingPerson(people);
        MenuForAddingProduct();
        string[] comm;
        do
        {
            Console.WriteLine("Enter name of person and name of product:");
            comm = Console.ReadLine().Split();



        } while (Console.ReadLine() != "End");
    }


    public static void MenuForAddingPerson(List<Person> p)
    {
        int n;
        Console.WriteLine("Enter quantity of people:");
        n = int.Parse(Console.ReadLine());
        if (n <= 0)
            Console.WriteLine("Quantity of people cannot be negative or zero!");

        else
        {
            for (int i = 0; i < n; i++)
            {
                Person person = new Person();
                try
                {
                    Console.WriteLine($"Enter name of {i + 1} person:");
                    person.Name = Console.ReadLine();
                    Console.WriteLine($"Enter balance of {i + 1} person:");
                    person.Money = decimal.Parse(Console.ReadLine());
                    p.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }

            }
        }

    }
    public static void MenuForAddingProduct()
    {
        int n;
        Console.WriteLine("Enter quantity of products:");
        n = int.Parse(Console.ReadLine());
        if (n <= 0)
            Console.WriteLine("Quantity cannot be less than zero or equal zero!");
        else
        {
            for (int i = 0; i < n; i++)
            {
                Product product = new Product();
                try
                {
                    Console.WriteLine($"Enter name of {i + 1} product:");
                    product.Name = Console.ReadLine();
                    Console.WriteLine($"Enter price of {i + 1} product: ");
                    product.Price = decimal.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }
    }
}

    

