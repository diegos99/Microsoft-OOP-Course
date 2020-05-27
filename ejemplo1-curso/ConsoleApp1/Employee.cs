using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Employee
	{
		//Constructor Method
		public Employee() {
			Name = "";
			DailySalary = 0.0m;
			Age = 0;
		}

		//Fields/Variables is when I set the name in private (if I set in public it's a propertie)
		private string _Name;
		private static decimal _DailySalary;
		private int _Age;

		//Accessors methods
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		public decimal DailySalary {
			get { return _DailySalary; }
			set { _DailySalary = value; }
		}

		public int Age
		{
			get { return _Age; }
			set { _Age = value; }
		}

		//Methods
		public static decimal CalculateSalary(int DaysNumber)
		{
			return _DailySalary * DaysNumber;
		}

		

	}
}
