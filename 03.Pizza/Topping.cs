using System;

public class Topping
{
	string typeTopping;
	double weight;
	public Topping(string typeTopping, double weight)
	{
		TypeTopping = typeTopping;
		Weight = weight;
	}
	public Topping()
	{
	}
	public string TypeTopping
	{
		get { return typeTopping; }
		set
		{
			if (value == "Meat" || value == "Cheese" || value == "Souse" || value == "Vegetables")
				typeTopping = value;
			else
				throw new ArgumentException($"Cannot place {value} on top of your pizza!");
		}
	}
	public double Weight
	{
		get { return weight; }
		set { if (value < 1 || value > 150)
				throw new ArgumentException($"{value} weight shoud be in range [1..50]!");
			} 
	}
	public double CaloriesPerGram
	{
		get
		{
			double modificatorType = 1.0;
			if (typeTopping == "Meat")
				modificatorType = 1.2;
			else if (typeTopping == "Vegetables")
				modificatorType = 0.8;
			else if (typeTopping == "Cheese")
				modificatorType = 1.1;
			else if (typeTopping == "Souse")
				modificatorType = 0.9;
			return 2 * modificatorType;
		}
	}
	public double CountCalories()
	{
		return CaloriesPerGram * Weight;
	}
}
