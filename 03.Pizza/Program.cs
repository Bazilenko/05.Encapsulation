using System;
class Program
{
    static void Main()
    {
        MenuForPizza();


    }
    public static void MenuForPizza()
    {
        Tisto tisto = new Tisto();
        Topping topping = new Topping();
        Pizza pizza = new Pizza();
        int n;
        do
        {
            try
            {
                Console.WriteLine("Enter name of pizza:");
                pizza.Name = Console.ReadLine();
                Console.WriteLine("Enter type of dough and weight:");
                tisto.Flour = Console.ReadLine();
                tisto.Technique = Console.ReadLine();
                tisto.Weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter quantity of topping:");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter type and weight of topping:");
                    topping = new Topping();
                    topping.TypeTopping = Console.ReadLine();
                    topping.Weight = double.Parse(Console.ReadLine());
                    pizza.AddTopping(topping);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        } while (Console.ReadLine() != "END");

    }
}