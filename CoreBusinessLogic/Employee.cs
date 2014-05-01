using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusinessLogic
{
	public abstract class Employee
	{
		public abstract double CalculatePay();

		public abstract bool IsPayDay();

		public string PaymentMethod
		{
			get; protected set;
		}
	}
}
