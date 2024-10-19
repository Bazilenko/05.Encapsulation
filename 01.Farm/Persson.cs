using System;

public class Person
{
	string name;
	decimal money;
	List<Product> products;
	public string Name
	{
		get
		{ return name; }
		set
		{
			if (value != "")
				name = value;
			else
				throw new ArgumentException("Name cannot be empty!");
		}
	}
	public decimal Money
	{
		get { return money; }
		set
		{
			if (value > 0)
				money = value;
			else
				throw new ArgumentException("Money cannot be negative number!");
		}
	}

	public Person(string name, decimal money)
	{
		this.name = name;
		this.money = money;
		products = new List<Product>();
	}
	public Person()
	{

	}

	public void BuyProduct(string nameOfProduct, List<Product> p)
	{
		for (int i = 0; i < p.Count; i++)
		{
			if (p[i].Name == nameOfProduct)
			{
				if (p[i].Price <= Money)
				{
					Money -= p[i].Price;
					products.Add(p[i]);
					Console.WriteLine($"{this.Name} bought {p[i].Name}");
					break;
				}

				else
					throw new ArgumentException($"{this.Name} can't afford {p[i].Name}");
				
			}

		}
	}
}
