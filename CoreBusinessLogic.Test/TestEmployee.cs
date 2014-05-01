using System;

namespace CoreBusinessLogic.Test
{
	public class TestEmployee : Employee
	{
		public TestEmployee()
		{
			PaymentMethod = "Test";
		}

		public bool CalculatedPay { get; set; }
		public Boolean ShouldGetPay { get; set; }

		public override double CalculatePay()
		{
			CalculatedPay = true;
			return 0;
		}

		public override bool IsPayDay()
		{
			return ShouldGetPay;
		}
	}
}