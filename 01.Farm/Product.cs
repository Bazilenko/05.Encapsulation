using System;


public class Product
{
	string name;
	decimal price;
	public string Name { 
		get { return name; } 
		set {
			if (value != "")
				name = value;
			else
				throw new ArgumentException("Name cannot be empty!");	
		}
	}
	public decimal Price
	{
		get { return price; }
		set
		{
			if (value > 0)
				price = value;
			else
				throw new ArgumentException("Price cannot be negative!");
		}
	}
	public Product(string name, decimal price)
	{
		this.name = name;
		this.price = price;
	}
	public Product()
	{
	}

}
