using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercice
{
	class BusinessEmployee : Employee
	{
		// BusinessEmployee Class inheriting from Employee Class
		public BusinessEmployee(string name) : base(name, 50000)
		{

		}
		// Creates double variable called "bonusBudget" and assigns value to 1000
		public double bonusBudget = 1000;

		public override string employeeStatus()
		{
			return this.toString() + " whith a budget of " + this.bonusBudget;
		}

	}
}
