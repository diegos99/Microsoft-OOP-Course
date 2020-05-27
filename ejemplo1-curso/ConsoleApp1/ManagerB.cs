using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class ManagerB : EmployeeAbstracto
	{
		private string departament;

		public string Departament { get; set; }

		public override void Login()
		{
			Console.WriteLine("Manager login");
		}

		public override void Hire()
		{
			Console.WriteLine("Hire someone");
		}


	}
}
