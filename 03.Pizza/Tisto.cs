using System;

public class Tisto
{
	string flour;
	string technique;
	double weight;
	public Tisto(string flour, string tech, double weight)
	{
		Flour = flour;
		Technique = tech;
		Weight = weight;
	}
	public Tisto() { }
	public string Flour { get { return flour; }
		set
		{
			if (value == "White" || value == "Wholegrain")
			{
				flour = value;
			}
			else
				throw new ArgumentException("Unknown type!");
		}
	}
	public string Technique
	{
		get { return technique; }
		set
		{
			if (value == "Homemade" || value == "Crisp" || value == "Masticatory")
				technique = value;
			else throw new ArgumentException("Unknown type of dough");
		}
	}
	public double Weight { get { return weight; }
		set {
			if (value < 1 && value > 200)
				throw new ArgumentException("Dough weight should be in the range [1..200]!");
		else
				weight = value;
		}
	}
	public double CaloriesPerGram
	{
		get{
			double modificatorFlour = 1.0;
			double modificatorTech = 1.0;
			if (Flour == "White")
				modificatorFlour = 1.5;
			if (Technique == "Crisp")
				modificatorTech = 0.9;
			else if (Technique == "Masticatory")
				modificatorTech = 1.1;
			return 2.0 * modificatorFlour * modificatorTech;
		}
	}
	public double CountCalories()
	{
		return CaloriesPerGram * Weight;
	}

}
