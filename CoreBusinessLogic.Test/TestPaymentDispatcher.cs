using System;

namespace CoreBusinessLogic.Test
{
	public class TestPaymentDispatcher : PaymentDispatcher
	{
		public Boolean TransferMoneyWasCalled { get; private set; }
		public override void TransferMoney(double pay)
		{
			TransferMoneyWasCalled = true;
		}
	}
}