using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercice
{
	abstract class Employee
	{
		//Constructor
		public Employee(string name, double baseSalary)
		{
			this.Name = name;
			this.BaseSalary = baseSalary;
			this.Id = employeeCount++;
		}

		//Variables
		private string _name;
		private double _baseSalary;
		private int _id;

		// Creates integer variable called "employeeCount" and assigns value to 1
		private static int employeeCount = 1;

		//Properties
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public double BaseSalary
		{
			get
			{
				return _baseSalary;
			}
			set
			{
				_baseSalary = value;
			}
		}

		public int Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		//Methods
		// This method returns the employee's base salary
		public double getBaseSalary()
		{
			return this.BaseSalary;
		}

		// This method returns the employee's name
		public string getName()
		{
			return this.Name;
		}

		//This method returns the employee's id
		public int getEmployeeID()
		{
			return this.Id;
		}

		// This method returns the employee's ID and Name
		public string toString()
		{
			return this.Id + " " + this.Name;
		}

		// This method returns the employee's status
		public abstract string employeeStatus();
	}
}
