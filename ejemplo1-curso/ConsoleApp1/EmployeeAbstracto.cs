using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	abstract class EmployeeAbstracto
	{
		//Variables
		private string empNumber;
		private string firstName;
		private string lastName;
		private string address;

		//Properties
		public string EmpNumber
		{
			get
			{
				return empNumber;
			}

			set
			{
				empNumber = value;
			}
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}

			set
			{
				firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}

			set
			{
				lastName = value;
			}
		}

		public string Address
		{
			get
			{
				return address;
			}

			set
			{
				address = value;
			}
		}

		//Methods
		public virtual void Login()
		{
			Console.WriteLine("Employee login");
		}

		public abstract void Hire();
	}
}
