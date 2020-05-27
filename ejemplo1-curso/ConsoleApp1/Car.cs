using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Car
	{
		//initialitating variable
		private static int instances = 0;

		//Multiple contructors with diferent combinations...
		public Car(string color, int year)
		{
			this.Color = color;
			this.Year = year;

			//Every time the constructor runs, increment "intances"
			instances++;
		}

		public Car(int year, int mileage)
		{
			this.Year = year;
			this.Mileage = mileage;
			instances++;
		}

		public Car()
		{
			instances++;
		}


		//Properties
		public string Color { get; set; }
		public int Year { get; set; }
		public int Mileage { get; set; }

		//This method show the Instance count result (total cars):
		public static int CountCars()
		{
			return instances;
		}
	}
}
