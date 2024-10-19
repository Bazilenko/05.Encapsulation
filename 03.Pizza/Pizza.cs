using System;

public class Pizza
{
	string name;
	List<Topping> topping;
	Tisto tisto;


	public Pizza()
	{
	}
	public string Name{
		get { return name; }
		set { 
			if (value == "" || value.Length > 15)
				throw new ArgumentException("Name of the pizza shoud has from 1 to 15 characters!");
			else 
				name = value;
		}
		}
	public void AddTopping(Topping topping)
	{
		if (this.topping.Count() > 10)
			throw new ArgumentException("Number of toppings shoud be in range [1..10]");
		else
			this.topping.Add(topping);	
        {
            
        }
    }
	public double CountCalories(List<Topping>topping)
	{	
			double sum = 0;
		for (int i = 0; i < topping.Count; i++)
		{
			sum += topping[i].CountCalories();
		}
			return sum + tisto.CountCalories();
		
	}
}
