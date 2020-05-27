using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class DrinksMachine : ITarjetaFidelidad
	{
		//Constructor
		public DrinksMachine(string loc, string make, string model)
		{
			this.Location = loc;
			this.Make = make;
			this.Model = model;
		}

		public DrinksMachine()
		{
		}

		//These are Variables because are using the modifer access: "private"
		private string _location;
		private string _make;
		private string _model;

		//There are properties:
			//Accesesors
		public string Location {
			get { return _location; }
			set { _location = value; }
		}

		public string Make
		{
			get { return _make; }
			set { _make = value; }
		}

		public string Model
		{
			get { return _model; }
			set { _model = value; }
		}
		
		//Methods
		public void MakeCapuccino()
		{
			Console.WriteLine("Capuccino is made");
		}

		public void MakeExpresso()
		{
			//public logic goes here
		}


		//Implementation of the interface
		private int totalPoints;
		public int TotalPoints
		{
			get
			{
				return totalPoints;
			}
		}

		public int AddPoints(decimal transactionValue)
		{
			int points = Decimal.ToInt32(transactionValue);
			totalPoints += points;
			return totalPoints;
		}

		public void ResetPoints()
		{
			totalPoints = 0;
		}
	}
}
