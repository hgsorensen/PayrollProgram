using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusinessLogic.Test
{
	class TestPaymentDispatcherFactory : PaymentDispatcherFactory
	{
		private readonly PaymentDispatcher paymentDispatcher;

		public TestPaymentDispatcherFactory(PaymentDispatcher paymentDispatcher)
		{
			this.paymentDispatcher = paymentDispatcher;
		}

		public override PaymentDispatcher Create(string nameOfPaymentDispatcher)
		{
			return paymentDispatcher;
		}
	}
}
