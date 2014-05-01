using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreBusinessLogic.Test
{
	[TestClass]
	public class CoreBusinessLogicTest
	{
		private TestEmployee employee;
		private TestEmployeeRepository employeeRepository;
		private Payer payer;
		private TestPaymentDispatcherFactory paymentDispatcherFactory;
		private TestPaymentDispatcher paymentDispatcher;

		[TestInitialize]
		public void Setup()
		{
			employee = new TestEmployee();
			employeeRepository = new TestEmployeeRepository(employee);
			paymentDispatcher = new TestPaymentDispatcher();
			paymentDispatcherFactory = new TestPaymentDispatcherFactory(paymentDispatcher);

			payer = new TestPayer(employeeRepository, paymentDispatcherFactory);
		}

		[TestMethod]
		public void PayerCanGetEmployees()
		{
			payer.CheckPay();
			Assert.IsTrue(employeeRepository.GaveEmployees);
		}

		[TestMethod]
		public void When_TimeForPay_PayIsCalculated()
		{
			employee.ShouldGetPay = true;

			payer.CheckPay();
			Assert.IsTrue(employee.CalculatedPay);
		}

		[TestMethod]
		public void When_NotTimeForPay_PayIsNotCalculated()
		{
			payer.CheckPay();
			Assert.IsFalse(employee.CalculatedPay);
		}

		[TestMethod]
		public void PayerCanGetPaymentMethod()
		{
			employee.ShouldGetPay = true;

			payer.CheckPay();
			Assert.IsTrue(paymentDispatcher.TransferMoneyWasCalled);
		}
	}
}
