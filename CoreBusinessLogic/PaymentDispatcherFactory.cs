using System;

namespace CoreBusinessLogic
{
	public abstract class PaymentDispatcherFactory
	{
		public abstract PaymentDispatcher Create(String nameOfPaymentDispatcher);
	}
}
