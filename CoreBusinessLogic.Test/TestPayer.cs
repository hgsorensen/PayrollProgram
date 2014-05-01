using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusinessLogic.Test
{
	class TestPayer : Payer
	{
		public TestPayer(EmployeeRepository employeeRepository, PaymentDispatcherFactory paymentDispatcher) : base(employeeRepository, paymentDispatcher)
		{
		}
	}
}
