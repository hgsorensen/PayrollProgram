using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreBusinessLogic.Test
{
	/// <summary>
	/// Summary description for CoreObjectExistenceTest
	/// </summary>
	[TestClass]
	public class CoreObjectExistenceTest
	{
		[TestMethod]
		public void ThereIsAPayer()
		{
			Payer payer = new TestPayer(null, null);
			Assert.IsNotNull(payer);
		}

		[TestMethod]
		public void ThereIsAnEmployeeRepository()
		{
			EmployeeRepository employeeRepository = new TestEmployeeRepository();
			Assert.IsNotNull(employeeRepository);
		}

		[TestMethod]
		public void ThereIsAnEmployee()
		{
			Employee emloyee = new TestEmployee();
			Assert.IsNotNull(emloyee);
		}

		[TestMethod]
		public void ThereIsAPaymentDispatcher()
		{
			PaymentDispatcher paymentDispatcher = new TestPaymentDispatcher();
			Assert.IsNotNull(paymentDispatcher);
		}
	}
}
