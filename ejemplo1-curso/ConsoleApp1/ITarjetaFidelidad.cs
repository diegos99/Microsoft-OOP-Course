using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public interface ITarjetaFidelidad
	{
		int TotalPoints { get; }
		int AddPoints(decimal transactionValue);
		void ResetPoints();
	}
}
