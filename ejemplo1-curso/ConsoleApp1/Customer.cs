using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	//Here we are implementing an interface properties and methods.
	public class Customer : ITarjetaFidelidad
	{

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
